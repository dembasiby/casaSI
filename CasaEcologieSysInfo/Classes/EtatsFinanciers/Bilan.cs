using CasaEcologieSysInfo.Classes.CalculDesCouts;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Bilan
    {
       
        public static void AfficherBilan(DataGridView grid, DateTimePicker debut, DateTimePicker fin)
        {
            DateTime deb = debut.Value.Date;
            DateTime fn = fin.Value.Date;
            Single totalActifCirculant = float.Parse(Tresorerie.CalculerSoldeInitialTresorerie(fn.AddDays(1)))
                + Tresorerie.CalculerTotalCreancesClientsALaDateDu(fn)
                + GestionStocks.ValeurTotalDesStocks(fn);
            Single totalDettesACourtTerme = (Single)Tresorerie.CalculerTotalDettesFournisseursALaDateDu(fn) + 0 /* autres dettes à court terme */;
            Single totalDettes = totalDettesACourtTerme + 0 /* emprunts et autres dettes à long terme */;
            Single immobilisationsBrutes = ImmobilisationsBrutes(fn);
            Single amortissementsCumules = AmortissementsCumules(fn);
            Single immobilisationsNettes = immobilisationsBrutes - amortissementsCumules ;
            Single totalActif = totalActifCirculant + immobilisationsNettes;
            Decimal crediteursDivers = Tresorerie.CalculerTotalDettesFournisseursALaDateDu(fn);
            String valeurNette = FormatNumber(totalActif - totalDettes);
            Single totalCapitauxPropres = CapitauxPropres(fn) + BeneficesRepartis(fn) + BeneficesNonRepartis(fn);
            Single totalPassif = totalCapitauxPropres + totalDettes;

            grid.Rows.Add("Trésorerie disponible en fin de période", Tresorerie.CalculerSoldeInitialTresorerie(fn.AddDays(1))); // 0
            grid.Rows.Add("Débiteurs divers", Tresorerie.CalculerTotalCreancesClientsALaDateDu(fn)); // 1
            grid.Rows.Add("Stocks", GestionStocks.ValeurTotalDesStocks(fn).ToString("n0")); // 2
            grid.Rows.Add("Total Actif Circulant", FormatNumber(totalActifCirculant)); // 3
            grid.Rows.Add("Immobilisations brutes", FormatNumber(immobilisationsBrutes)); // 4
            grid.Rows.Add("Amortissements cumulés", FormatNumber(amortissementsCumules)); // 5
            grid.Rows.Add("Immobilisations nettes", FormatNumber(immobilisationsNettes)); // 6
            grid.Rows.Add("TOTAL ACTIF", FormatNumber(totalActif)); // 7

            grid.Rows.Add("Créditeurs divers", FormatNumber(crediteursDivers)); // 8
            grid.Rows.Add("Autres dettes à Court Terme", 0); // 9
            grid.Rows.Add("Total dettes à Court Terme", FormatNumber(totalDettesACourtTerme)); // 10
            grid.Rows.Add("Emprunts et autres dettes à Long Terme", 0); // 11
            grid.Rows.Add("Total Dettes", FormatNumber(totalDettes)); // 12
            grid.Rows.Add("Capitaux propres (Capitaux et Subventions)", FormatNumber(CapitauxPropres(fn))); // 13
            grid.Rows.Add("Bénéfices Non Répartis", FormatNumber(BeneficesNonRepartis(fn))); // 14 
            grid.Rows.Add("Bénéfices Répartis", FormatNumber(BeneficesRepartis(fn))); // 15
            grid.Rows.Add("Total Capitaux Propres", FormatNumber(totalCapitauxPropres)); // 16
            grid.Rows.Add("TOTAL PASSIF ET CAPITAL", FormatNumber(totalPassif)); // 17
            grid.Rows.Add("Valeur nette", valeurNette); // 18

            // 
            Formattage.FormatterLigneEnGras(grid, 3);

            // 
            Formattage.FormatterLigneEnGras(grid, 7);

            // 
            Formattage.FormatterLigneEnGras(grid, 10);

            // 
            Formattage.FormatterLigneEnGras(grid, 12);

            // 
            Formattage.FormatterLigneEnGras(grid, 16);

            // 
            Formattage.FormatterLigneEnGras(grid, 17);

            // 
            Formattage.FormatterLigneEnGras(grid, 18);
        }

        private static Single ImmobilisationsBrutes(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return (from inE in db.ResEquipementsInfrastructures
                                                where (inE.DateAcquisition.Year + inE.DureeDeVie) >= date.Year
                                                where inE.DateAcquisition <= date
                                                select (Single?)inE.Montant).Sum() ?? 0f;
            }
        }

        private static Single AmortissementsCumules (DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single amortissementsCumulesImmoNonAmortis = (from inE in db.ResEquipementsInfrastructures
                                                   where (inE.DateAcquisition.Year + inE.DureeDeVie) > date.Year
                                                   where inE.DateAcquisition < date
                                                   select new
                                                   {
                                                       Immobilisation = inE.Nom,
                                                       inE.Quantite,
                                                       ValeurDOrigine = inE.Montant,
                                                       inE.DateAcquisition,
                                                       nombreJours = DbFunctions.DiffDays(inE.DateAcquisition, date),
                                                       inE.DureeDeVie,
                                                       AmortissementAnnuel = inE.Montant / (inE.DureeDeVie),
                                                   })
                        .Select(a => (Single?)(a.AmortissementAnnuel / 365) * a.nombreJours)
                        .Sum() ?? 0f;

                Single amortissementsCumulesImmoAmortis = (from inE in db.ResEquipementsInfrastructures
                                                           where (inE.DateAcquisition.Year + inE.DureeDeVie) <= date.Year
                                                           select (Single)inE.Montant).Sum();

                return (Single)amortissementsCumulesImmoNonAmortis + amortissementsCumulesImmoAmortis;
            }
        }

        public static Single CapitauxPropres(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {              
                Single investissements = (from inE in db.ResEquipementsInfrastructures
                                                where (inE.DateAcquisition.Year + inE.DureeDeVie) >= date.Year
                                                where inE.DateAcquisition <= date
                                                select (Single?)inE.Montant).Sum() ?? 0f;

                // Single valeurResiduelle = investissements - AmortissementsCumules(date);
                Single subventionsEtAutresFonds = (from af in db.EveEncaissementsAutres
                                                   where af.DateEncaissement <= date
                                                   select (Single?)af.MontantEncaisse).Sum() ?? 0;

                Single dettesFournisseurs = (Single)Tresorerie.CalculerTotalDettesFournisseursALaDateDu(date);

                Single tresorerie = float.Parse(Tresorerie.CalculerSoldeInitialTresorerie(date.AddDays(1)));

                Single stocks = GestionStocks.ValeurTotalDesStocks(date);

                Single creances = Tresorerie.CalculerTotalCreancesClientsALaDateDu(date);

                return investissements + subventionsEtAutresFonds + tresorerie + creances + stocks - dettesFournisseurs;
            }        
        }

        public static Single BeneficesRepartis(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return (from br in db.EveAcquisitionServicesFournitures
                        where br.ResServicesFourniture.NomServiceFourniture == "Retrait des propriétaires"
                        where br.Date <= date
                        select (Single?)br.Montant).Sum() ?? 0;
            }
        }

        public static Single BeneficeNet(DateTime date)
        {
            DateTime debut = new DateTime(2019, 1, 1);
            Single ventes = CompteDeResultat.CumulVentes(date);
            Single coutDesProduitsVendus = InventaireStocksProduitsFinis.CoutDesProduitsVendus(debut, date);
            Single fraisGeneraux = float.Parse(CompteDeResultat.FraisGenerauxDeLaPeriode(debut, date));
            Single amortissements = AmortissementsCumules(date);
            Single impotsEtTaxes = float.Parse(CompteDeResultat.ImpotsEtTaxesDeLaPeriode(debut, date));

            return ventes - coutDesProduitsVendus - fraisGeneraux - amortissements - impotsEtTaxes;
        }

        public static Single BeneficesNonRepartis(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return BeneficeNet(date) - BeneficesRepartis(date);
            }
        }

        public static string FormatNumber(Single number)
        {
            return number.ToString("n0");
        }

        public static string FormatNumber(Decimal number)
        {
            return number.ToString("n0");
        }
    }
}

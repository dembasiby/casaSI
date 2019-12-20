using CasaEcologieSysInfo.Classes.CalculDesCouts;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class CompteDeResultat
    {
        public static void AfficherCompteDeResultats(DataGridView grid, DateTimePicker debut, DateTimePicker fin)
        {
            DateTime deb = debut.Value.Date;
            DateTime fn = fin.Value.Date;


            grid.Rows.Add("Chiffre d'affaires",
                CalculerVentesPeriode(deb, fn));

            grid.Rows.Add("Cout des produits vendus", InventaireStocksProduitsFinis.CoutDesProduitsVendus(deb, fn));

            grid.Rows.Add("Marge brute", CalculerMargeBrute(grid));

            grid.Rows.Add("Autres revenus", 0);
            grid.Rows.Add("Frais afférents aux autres revenus", 0);

            grid.Rows.Add("Frais généraux et autres charges",
                FraisGenerauxDeLaPeriode(deb, fn));

            grid.Rows.Add("Résultats avant impôts et  amortissements",
                ResultatAvantImpotsEtAmortissements(grid));

            grid.Rows.Add("Amortissements de la période",
                AmortissementsDeLaPeriode(deb, fn));

            grid.Rows.Add("Impôts et taxes",
                ImpotsEtTaxesDeLaPeriode(deb, fn));

            grid.Rows.Add("Résultat net", ResultatNet(grid));

            // Ligne de la marge brute
            Formattage.FormatterLigneEnGras(grid, 2);

            // Ligne du résultat avant impôts
            Formattage.FormatterLigneEnGras(grid, 6);

            // Ligne du résultat net
            Formattage.FormatterLigneEnGras(grid, 9);
        }

        private static string CalculerVentesPeriode(DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return ((from v in db.EveVentes
                         join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                         where v.DateVente >= debut && v.DateVente <= fin
                         select (decimal?)vp.Montant).Sum() ?? 0m).ToString("n0");
            }
        }

        public static Single CumulVentes(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return (from v in db.EveVentes
                         join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                         where v.DateVente <= date
                         select (Single?)vp.Montant).Sum() ?? 0;
            }
        }

        private static string CalculerMargeBrute(DataGridView grid)
        {
            string ventes = grid.Rows[0].Cells[1].Value.ToString();
            string cogs = grid.Rows[1].Cells[1].Value.ToString();

            double ventesNumber = 0;
            double cogsNumber = 0;
            if (ventes != null)
                ventesNumber = Double.Parse(ventes);
            if (cogs != null)
                cogsNumber = Double.Parse(cogs);
            return (ventesNumber - cogsNumber).ToString("n0");
        }

        private static string ResultatAvantImpotsEtAmortissements(DataGridView grid)
        {
            string autresRevenus = grid.Rows[3].Cells[1].Value.ToString();
            string margeBrute = grid.Rows[2].Cells[1].Value.ToString();
            string fraisAutresRev = grid.Rows[4].Cells[1].Value.ToString();
            string fraisGeneraux = grid.Rows[5].Cells[1].Value.ToString();

            double autreRevNumber = 0;
            double margeBruteNumber = 0;
            double fraisAutresRevNumber = 0;
            double fraisGenerauxNumber = 0;

            if (autresRevenus != null)
                autreRevNumber = Double.Parse(autresRevenus);
            if (margeBrute != null)
                margeBruteNumber = Double.Parse(margeBrute);
            if (fraisAutresRev != null)
                fraisAutresRevNumber = Double.Parse(fraisAutresRev);
            if (fraisGeneraux != null)
                fraisGenerauxNumber = Double.Parse(fraisGeneraux);

            return (autreRevNumber + margeBruteNumber - fraisAutresRevNumber - fraisGenerauxNumber).ToString("n0");
        }

        private static string ResultatNet(DataGridView grid)
        {
            string resultatAvantImpot = grid.Rows[6].Cells[1].Value.ToString();
            string amortissements = grid.Rows[7].Cells[1].Value.ToString();
            string impots = grid.Rows[8].Cells[1].Value.ToString();
        

            double resultatAvantImpotNumber = 0;
            double amortissementsNumber = 0;
            double impotsNumber = 0;

            if (resultatAvantImpot != null)
                resultatAvantImpotNumber = Double.Parse(resultatAvantImpot);
            if (amortissements != null)
                amortissementsNumber = Double.Parse(amortissements);
            if (impots != null)
                impotsNumber = Double.Parse(impots);
           
            return (resultatAvantImpotNumber - amortissementsNumber - impotsNumber).ToString("n0");
        }

        public static float MainDOeuvre(DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return (from rem in db.EvePresenceEmployes
                        where rem.Date >= debut.Date
                        where rem.Date <= fin.Date
                        select (float?)rem.RemunerationJournaliere).Sum() ?? 0f; 
            }
        }

        public static string FraisGenerauxDeLaPeriode(DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var fraisGeneraux = ((from asf in db.EveAcquisitionServicesFournitures
                                      where asf.Date >= debut.Date
                                      where asf.Date <= fin.Date
                                      where asf.ResServicesFourniture.NomServiceFourniture != "Taxes"
                                      where asf.ResServicesFourniture.NomServiceFourniture != "Retrait des propriétaires"
                                      select (float?)asf.Montant).Sum() ?? 0f);

                return (fraisGeneraux + MainDOeuvre(debut, fin)).ToString("n0");
            }
        }

        public static string ImpotsEtTaxesDeLaPeriode(DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return ((from asf in db.EveAcquisitionServicesFournitures
                        where asf.Date >= debut.Date
                        where asf.Date <= fin.Date
                        where asf.ResServicesFourniture.NomServiceFourniture == "Taxes"
                        select (decimal?)asf.Montant).Sum() ?? 0m).ToString("n0");
            }
        }

        public static string AmortissementsDeLaPeriode(DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                float amortissementsJournaliers = (from inE in db.ResEquipementsInfrastructures
                        where (inE.DateAcquisition.Year + inE.DureeDeVie) > debut.Year
                        select new
                        {
                            Immobilisation = inE.Nom,
                            inE.Quantite,
                            ValeurDOrigine = inE.Montant,
                            inE.DateAcquisition,
                            inE.DureeDeVie,
                            nombreJoursPeriode = DbFunctions.DiffDays(debut, fin),
                            AmortissementAnnuel = inE.Montant / (inE.DureeDeVie),
                        })
                        .Select(a => (float?)(a.AmortissementAnnuel/365) * a.nombreJoursPeriode)
                        .Sum() ?? 0f;

                return amortissementsJournaliers.ToString("n0");
            }
        }

    }
}

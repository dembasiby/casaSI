using System;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Tresorerie
    {
        private static string CalculerSoldeInitialTresorerie(DateTime debutPeriode)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitiaux = (from c in db.ResComptesTresoreries
                                     select (decimal?)c.SoldeCompte).Sum() ?? 0m;

                var totalEncaissements = (from c in db.EveEncaissements
                                          from env in db.EveEncaissementsVentes
                                          where c.CodeEncaissement == env.CodeEncaissement
                                          where env.DateEncaissement < debutPeriode.Date
                                          select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

                var encaissementCreance = (from c in db.EveEncaissements
                                           from env in db.EveEncaissementsCreances
                                           where c.CodeEncaissement == env.CodeEncaissement
                                           where env.DateEncaissement < debutPeriode
                                           select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

                var totalAutresEn = (from enc in db.EveEncaissements
                                     from aut in db.EveEncaissementsAutres
                                     where enc.CodeEncaissement == aut.CodeEncaissement
                                     where aut.DateEncaissement < debutPeriode.Date
                                     select (decimal?)aut.MontantEncaisse).Sum() ?? 0m;

                var totalDecaissements = (from d in db.EveDecaissements
                                          where d.DateDecaissement < debutPeriode.Date
                                          select (decimal?)d.Montant).Sum() ?? 0m;

                var fondsDisponibleEnCaissesEtEnBanques = soldeInitiaux
                    + totalEncaissements + totalAutresEn + encaissementCreance
                    - totalDecaissements;

                return fondsDisponibleEnCaissesEtEnBanques.ToString("n0");
            }
        }

        public static void AfficherTresorerie(DataGridView grid, DateTimePicker debut, DateTimePicker fin)
        {
            // ligne 0
            grid.Rows.Add("Fonds disponible en début de période", CalculerSoldeInitialTresorerie(debut.Value.Date));
            // ligne 1
            grid.Rows.Add("");

            // ligne 2
            grid.Rows.Add("RECETTES DE TRESORERIE");

            // ligne 3
            grid.Rows.Add("Ventes en cash", TotalVentesCashPeriode(debut, fin));

            // ligne 4
            grid.Rows.Add("Remboursement des créances", RemboursementCreances(debut, fin));

            // ligne 5
            grid.Rows.Add("Prêts et autres fonds reçus", PretEtAutresFondsRecus(debut, fin));

            // ligne 6
            grid.Rows.Add("TOTAL RECETTES DE TRESORERIE", TotalRecettesTresorerie(grid));

            // ligne 7
            grid.Rows.Add("Total Fonds Disponibles(avant sorties de fonds)", TotalFondsAvantDepenses(grid));

            // ligne 8
            grid.Rows.Add("");

            // ligne 9
            grid.Rows.Add("DEPENSES DE TRESORERIE");
            // ligne 10
            grid.Rows.Add("Achat de matières premières", AchatMatieresPremieres(debut, fin));
            // ligne 11
            grid.Rows.Add("Achat emballages", AchatEmballage(debut, fin));
            // ligne 12
            grid.Rows.Add("Salaires", PaiementSalaires(debut, fin));
            // ligne 13
            grid.Rows.Add("Services extérieurs", ServicesExterieurs(debut, fin));
            // ligne 14
            grid.Rows.Add("Fournitures", Fournitures(debut, fin));
            // ligne 15
            grid.Rows.Add("Réparations et maintenance", ReparationsEtMaintenance(debut, fin));
            // ligne 16
            grid.Rows.Add("Location", Location(debut, fin));
            // ligne 17
            grid.Rows.Add("Téléphone et internet", TelephoneEtInternet(debut, fin));
            // ligne 18
            grid.Rows.Add("Electricité et eau", ElectriciteEtEau(debut, fin));
            // ligne 19
            grid.Rows.Add("Taxes", Taxes(debut, fin));
            // ligne 20
            grid.Rows.Add("Intérêts payés", InteretsPayes(debut, fin));
            // ligne 21
            grid.Rows.Add("Frais bancaires", FraisBancaires(debut, fin));
            // ligne 22
            grid.Rows.Add("Transport (autre que matière première)", AutresTransport(debut, fin));

            // ligne 23 = Total ligne 10 à ligne 22
            grid.Rows.Add("SOUS TOTAL", SousTotalDepenses(grid));
            // ligne 24
            grid.Rows.Add("Paiement des échéances de prêts (principal)", PaiementPrincipal(debut, fin));
            // ligne 25
            grid.Rows.Add("Investissements de la période", InvestissementsDeLaPeriode(debut, fin));
            // ligne 26
            grid.Rows.Add("Retrait des propriétaires", RetraitDesProprietaires(debut, fin));
            // ligne 27 = ligne 23 + ligne 24 + ligne 25 + ligne 26
            grid.Rows.Add("TOTAL DEPENSES DE TRESORERIE", TotalDepenses(grid));
            // ligne 28
            grid.Rows.Add("");
            // ligne 29 = ligne 7 - ligne 27
            grid.Rows.Add("Trésorerie Disponible en fin de période", TresorerieDisponibleEnFinDePeriode(grid));

            MettreLesLignesEnGras(grid);          
        }

        private static object Location(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Location");
        }

        private static object ServicesExterieurs(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Services extérieurs");
        }

        private static object Fournitures(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Fournitures");
        }

        private static object PretEtAutresFondsRecus(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var autresFondsRecus = (from aenc in db.EveEncaissementsAutres
                                        where aenc.FondsExternes == true
                                        where aenc.DateEncaissement >= debut.Value.Date
                                        where aenc.DateEncaissement <= fin.Value.Date
                                        select (decimal?)aenc.MontantEncaisse).Sum() ?? 0m;

                return autresFondsRecus.ToString("n0");
            }
        }

        private static object TresorerieDisponibleEnFinDePeriode(DataGridView grid)
        {
            // ligne 7 - ligne 27
            double fondsDisponibles = Double.Parse(grid.Rows[7].Cells[1].Value.ToString());
            double totalDepenses = Double.Parse(grid.Rows[27].Cells[1].Value.ToString());

            double total = fondsDisponibles - totalDepenses;

            return total.ToString("n0");
        }

        private static string TotalDepenses(DataGridView grid)
        {
            // ligne 24 = ligne 21 + ligne 22 + ligne 23 + ligne 24
            double paiementPrincipal = Double.Parse(grid.Rows[23].Cells[1].Value.ToString());
            double sousTotalDepenses = Double.Parse(grid.Rows[24].Cells[1].Value.ToString());
            double investissements = Double.Parse(grid.Rows[25].Cells[1].Value.ToString());
            double retraitProprietaires = Double.Parse(grid.Rows[26].Cells[1].Value.ToString());

            double total = paiementPrincipal + sousTotalDepenses + investissements + retraitProprietaires;

            return total.ToString("n0");
        }

        private static object RetraitDesProprietaires(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Retrait des propriétaires");
        }

        private static string InvestissementsDeLaPeriode(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                decimal investissements = (from d in db.EveDecaissements
                                           where d.CodeReceptionEquipementInfrastructure != null
                                           where d.DateDecaissement >= debut.Value.Date
                                           where d.DateDecaissement <= fin.Value.Date
                                           select (decimal?)d.Montant).Sum() ?? 0m;

                return investissements.ToString("n0");
            }
        }

        private static string PaiementPrincipal(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Paiement des écheances de prêt (principal)");
        }

        private static string SousTotalDepenses(DataGridView grid)
        {
            // Total ligne 10 à ligne 22 
            double matieresPremieres  = Double.Parse(grid.Rows[10].Cells[1].Value.ToString());
            double emballages         = Double.Parse(grid.Rows[11].Cells[1].Value.ToString());
            double salaires           = Double.Parse(grid.Rows[12].Cells[1].Value.ToString());
            double servicesExterieurs = Double.Parse(grid.Rows[13].Cells[1].Value.ToString());
            double fournitures        = Double.Parse(grid.Rows[14].Cells[1].Value.ToString());
            double reparations        = Double.Parse(grid.Rows[15].Cells[1].Value.ToString());
            double location           = Double.Parse(grid.Rows[16].Cells[1].Value.ToString());
            double telephone          = Double.Parse(grid.Rows[17].Cells[1].Value.ToString());
            double electricite        = Double.Parse(grid.Rows[18].Cells[1].Value.ToString());
            double taxes              = Double.Parse(grid.Rows[19].Cells[1].Value.ToString());
            double interets           = Double.Parse(grid.Rows[20].Cells[1].Value.ToString());
            double fraisBancaires     = Double.Parse(grid.Rows[21].Cells[1].Value.ToString());
            double transport          = Double.Parse(grid.Rows[22].Cells[1].Value.ToString());

            double total = matieresPremieres + emballages + salaires + servicesExterieurs +
                           fournitures + reparations + location + telephone + electricite + 
                           taxes + interets + fraisBancaires + transport;

            return total.ToString("n0");

        }

        private static string AutresTransport(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Transport (autre que matière première)");
        }

        private static string FraisBancaires(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Frais bancaires");
        }

        private static string InteretsPayes(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Intérêts payés");
        }

        private static string Taxes(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Taxes");
        }

        private static string ElectriciteEtEau(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Eau et éléctricité");
        }

        private static string TelephoneEtInternet(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Téléphone et internet");
        }

        private static string ReparationsEtMaintenance(DateTimePicker debut, DateTimePicker fin)
        {
            return DepenseServiceFourniture(debut, fin, "Réparations et maintenance");
        }

        private static object PaiementSalaires(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                // Salaires liés à la production
                var paiementSalaires = (from ps in db.EvePaiementEmployes
                                              join d in db.EveDecaissements on ps.CodePaiementEmploye equals d.CodePaiementEmploye
                                              where d.DateDecaissement >= debut.Value.Date
                                              where d.DateDecaissement <= fin.Value.Date
                                              select (decimal?)d.Montant).Sum() ?? 0m;

                // Les salaires indirects non liés à la production
                var autresSalaires = Decimal.Parse(DepenseServiceFourniture(debut, fin, "Autres Salaires"));

                return (paiementSalaires + autresSalaires).ToString("n0");
            }
        }

        private static string AchatEmballage(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var achatEmballages = (from amp in db.EveReceptionMatieresPremieres
                                              join d in db.EveDecaissements on amp.CodeReceptionMatierePremiere equals d.CodeReceptionMatierePremiere
                                              join mp in db.ResStockMatieresPremieres on amp.CodeMatierePremiere equals mp.CodeMatierePremiere
                                              where mp.TypeMatiere == "emballage"
                                              where d.DateDecaissement >= debut.Value.Date
                                              where d.DateDecaissement <= fin.Value.Date
                                              select (decimal?)d.Montant).Sum() ?? 0m;

                return achatEmballages.ToString("n0");
            }
        }

        private static string AchatMatieresPremieres(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var achatMatieresPremieres = (from amp in db.EveReceptionMatieresPremieres
                                              join d in db.EveDecaissements on amp.CodeReceptionMatierePremiere equals d.CodeReceptionMatierePremiere
                                              join mp in db.ResStockMatieresPremieres on amp.CodeMatierePremiere equals mp.CodeMatierePremiere
                                              where mp.TypeMatiere != "emballage"
                                              where d.DateDecaissement >= debut.Value.Date
                                              where d.DateDecaissement <= fin.Value.Date
                                              select (decimal?)d.Montant).Sum() ?? 0m;

                var remboursementDettesFournisseurs = (from d in db.EveDecaissements
                                                       where d.CodeFournisseurMatierePremiere != null
                                                       where d.CodeReceptionMatierePremiere == null
                                                       where d.DateDecaissement >= debut.Value.Date
                                                       where d.DateDecaissement <= fin.Value.Date
                                                       select (decimal?)d.Montant).Sum() ?? 0m;

                // Le coût du gaz utilisé dans la production. Pour faciliter l'exploitation des données,
                // les dépenses de gaz ont été ajoutées à la table ResServicesFournitures.
                var gaz = Decimal.Parse(DepenseServiceFourniture(debut, fin, "Gaz"));

                return (achatMatieresPremieres + remboursementDettesFournisseurs + gaz).ToString("n0");
            }
        }

        private static string RemboursementCreances(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var remboursements = (from r in db.EveEncaissementsCreances
                                  where r.DateEncaissement >= debut.Value.Date
                                  where r.DateEncaissement <= fin.Value.Date
                                  select (decimal?)r.MontantEncaisse).Sum() ?? 0m;

                return remboursements.ToString("n0");
            }
        }

        private static string TotalFondsAvantDepenses(DataGridView grid)
        {
            // total ligne 0 et 6
            double fondsDebut = Double.Parse(grid.Rows[0].Cells[1].Value.ToString());
            double recettesTres = Double.Parse(grid.Rows[6].Cells[1].Value.ToString());

            return (fondsDebut + recettesTres).ToString("n0");
        }

        private static string TotalRecettesTresorerie(DataGridView grid)
        {
            // total lignes 3, 4 et 5
            double ventes = Double.Parse(grid.Rows[3].Cells[1].Value.ToString());
            double creances = Double.Parse(grid.Rows[4].Cells[1].Value.ToString());
            double pretSubv = Double.Parse(grid.Rows[5].Cells[1].Value.ToString());
            
            return (ventes + creances + pretSubv).ToString("n0");
        }

        private static string TotalVentesCashPeriode(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventesCash = (from ev in db.EveEncaissementsVentes
                                  where ev.DateEncaissement >= debut.Value.Date
                                  where ev.DateEncaissement <= fin.Value.Date
                                  select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;

                return ventesCash.ToString("n0");
            }
        }

        private static string DepenseServiceFourniture(DateTimePicker debut, DateTimePicker fin, string typeDepense)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                decimal depense = (from sf in db.EveAcquisitionServicesFournitures
                                   join d in db.EveDecaissements on sf.CodeAcquisitionServiceFourniture
                                          equals d.CodeAcquisitionServiceFourniture
                                   where sf.ResServicesFourniture.NomServiceFourniture == typeDepense
                                   where d.DateDecaissement >= debut.Value.Date
                                   where d.DateDecaissement <= fin.Value.Date
                                   select (decimal?)d.Montant).Sum() ?? 0m;

                return depense.ToString("n0");
            }
        }

        private static void MettreLesLignesEnGras(DataGridView grid)
        {
            Formattage.FormatterLigneEnGras(grid, 2);
            Formattage.FormatterLigneEnGras(grid, 6);
            Formattage.FormatterLigneEnGras(grid, 7);
            Formattage.FormatterLigneEnGras(grid, 9);
            Formattage.FormatterLigneEnGras(grid, 23);
            Formattage.FormatterLigneEnGras(grid, 27);
            Formattage.FormatterLigneEnGras(grid, 29);
        }
    
    }
}

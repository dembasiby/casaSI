using System;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Tresorerie
    {
        public static string CalculerSoldeTresorerie(DateTime debutPeriode)
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
            grid.Rows.Add("Fonds disponible en début de période", CalculerSoldeTresorerie(debut.Value.Date));
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
                                        //where aenc.FondsExternes == true
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
            float matieresPremieres  = float.Parse(grid.Rows[10].Cells[1].Value.ToString());
            float emballages         = float.Parse(grid.Rows[11].Cells[1].Value.ToString());
            float salaires           = float.Parse(grid.Rows[12].Cells[1].Value.ToString());
            float servicesExterieurs = float.Parse(grid.Rows[13].Cells[1].Value.ToString());
            float fournitures        = float.Parse(grid.Rows[14].Cells[1].Value.ToString());
            float reparations        = float.Parse(grid.Rows[15].Cells[1].Value.ToString());
            float location           = float.Parse(grid.Rows[16].Cells[1].Value.ToString());
            float telephone          = float.Parse(grid.Rows[17].Cells[1].Value.ToString());
            float electricite        = float.Parse(grid.Rows[18].Cells[1].Value.ToString());
            float taxes              = float.Parse(grid.Rows[19].Cells[1].Value.ToString());
            float interets           = float.Parse(grid.Rows[20].Cells[1].Value.ToString());
            float fraisBancaires     = float.Parse(grid.Rows[21].Cells[1].Value.ToString());
            float transport          = float.Parse(grid.Rows[22].Cells[1].Value.ToString());
            
            float total = matieresPremieres + emballages + salaires + servicesExterieurs +
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
                float paiementSalaires = (from ps in db.EvePaiementEmployes
                                              join d in db.EveDecaissements on ps.CodePaiementEmploye equals d.CodePaiementEmploye
                                              where d.DateDecaissement >= debut.Value.Date
                                              where d.DateDecaissement <= fin.Value.Date
                                              select (float?)d.Montant).Sum() ?? 0;

                // Les salaires indirects non liés à la production
                float autresSalaires = float.Parse(DepenseServiceFourniture(debut, fin, "Autres Salaires"));

                return (paiementSalaires + autresSalaires).ToString("n0");
            }
        }

        private static string AchatEmballage(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                float achatEmballages = (from amp in db.EveReceptionMatieresPremieres
                                              join d in db.EveDecaissements on amp.CodeReceptionMatierePremiere equals d.CodeReceptionMatierePremiere
                                              join mp in db.ResStockMatieresPremieres on amp.CodeMatierePremiere equals mp.CodeMatierePremiere
                                              where mp.TypeMatiere == "emballage"
                                              where d.DateDecaissement >= debut.Value.Date
                                              where d.DateDecaissement <= fin.Value.Date
                                              select (float?)d.Montant).Sum() ?? 0;

                return achatEmballages.ToString("n0");
            }
        }

        private static string AchatMatieresPremieres(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                float achatMatieresPremieres = (from amp in db.EveReceptionMatieresPremieres
                                              join d in db.EveDecaissements on amp.CodeReceptionMatierePremiere equals d.CodeReceptionMatierePremiere
                                              join mp in db.ResStockMatieresPremieres on amp.CodeMatierePremiere equals mp.CodeMatierePremiere
                                              where mp.TypeMatiere != "emballage"
                                              where d.DateDecaissement >= debut.Value.Date
                                              where d.DateDecaissement <= fin.Value.Date
                                              select (float?)d.Montant).Sum() ?? 0;

                float remboursementDettesFournisseurs = (from d in db.EveDecaissements
                                                       where d.CodeFournisseurMatierePremiere != null
                                                       where d.CodeReceptionMatierePremiere == null
                                                       where d.DateDecaissement >= debut.Value.Date
                                                       where d.DateDecaissement <= fin.Value.Date
                                                       select (float?)d.Montant).Sum() ?? 0;

                // Le coût du gaz utilisé dans la production. Pour faciliter l'exploitation des données,
                // les dépenses de gaz ont été ajoutées à la table ResServicesFournitures.
                float gaz = float.Parse(DepenseServiceFourniture(debut, fin, "Gaz"));

                return (achatMatieresPremieres + remboursementDettesFournisseurs + gaz).ToString("n0");
            }
        }

        private static string RemboursementCreances(DateTimePicker debut, DateTimePicker fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                float remboursements = (from r in db.EveEncaissementsCreances
                                  where r.DateEncaissement >= debut.Value.Date
                                  where r.DateEncaissement <= fin.Value.Date
                                  select (float?)r.MontantEncaisse).Sum() ?? 0;

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


        public static decimal CalculerTotalCreancesClients()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventesClients = (from c in db.AgeClients
                                     from vf in db.EveVenteStockProduitsFinis
                                     from v in db.EveVentes
                                     where v.CodeClient == c.CodeClient
                                     where vf.CodeVente == v.CodeVente
                                     select (decimal?)vf.Montant).Sum() ?? 0m;

                var totalPaiementClient = (from c in db.AgeClients
                                           from ev in db.EveEncaissementsVentes
                                           where c.CodeClient == ev.CodeClient
                                           select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;
                var encaissementCreances = (from c in db.AgeClients
                                            from ec in db.EveEncaissementsCreances
                                            where c.CodeClient == ec.CodeClient
                                            select (decimal?)ec.MontantEncaisse).Sum() ?? 0m;

                var creanceInitialClient = (from c in db.AgeClients
                                            select (decimal?)c.SoldeInitialeCreance).Sum() ?? 0m;

                return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
            }
        }

        public static Single CalculerTotalCreancesClientsALaDateDu(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventesClients = (from c in db.AgeClients
                                     from vf in db.EveVenteStockProduitsFinis
                                     from v in db.EveVentes
                                     where v.CodeClient == c.CodeClient
                                     where vf.CodeVente == v.CodeVente
                                     where v.DateVente <= date
                                     select (Single?)vf.Montant).Sum() ?? 0f;

                var totalPaiementClient = (from c in db.AgeClients
                                           from ev in db.EveEncaissementsVentes
                                           where c.CodeClient == ev.CodeClient
                                           where ev.DateEncaissement <= date
                                           select (Single?)ev.MontantEncaisse).Sum() ?? 0f;
                var encaissementCreances = (from c in db.AgeClients
                                            from ec in db.EveEncaissementsCreances
                                            where c.CodeClient == ec.CodeClient
                                            where ec.DateEncaissement <= date
                                            select (Single?)ec.MontantEncaisse).Sum() ?? 0f;

                var creanceInitialClient = (from c in db.AgeClients
                                            select (Single?)c.SoldeInitialeCreance).Sum() ?? 0f;

                return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
            }
        }

        public static decimal CalculerTotalDettesFournisseurs()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                    select fmp.SoldeDette).Sum();

                var totalAchats = (from f in db.AgeFournisseursMatieresPremieres
                                   join rmp in db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                                   select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiements = (from fmp in db.AgeFournisseursMatieresPremieres
                                      join d in db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                                      select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFE = (from f in db.AgeAutreFournisseurs
                                      select f.SoldeInitialDetteFournisseur).Sum();

                var totalAchatsFE = (from f in db.AgeAutreFournisseurs
                                     join rmp in db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                                     join ei in db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                                     select (decimal?)ei.Montant).Sum() ?? 0m;

                var totalPaiementsFE = (from f in db.AgeAutreFournisseurs
                                        join d in db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFS = (from f in db.AgeFournisseursServicesFournitures
                                      select f.SoldeDette).Sum();

                var totalAchatsFS = (from f in db.AgeFournisseursServicesFournitures
                                     join rmp in db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiementsFS = (from f in db.EveAcquisitionServicesFournitures
                                        join d in db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                return soldeInitial + soldeInitialFE + soldeInitialFS
                    + totalAchats + totalAchatsFE + totalPaiementsFS
                    - totalPaiements - totalPaiementsFE - totalPaiementsFS;
            }
        }

        public static decimal CalculerTotalDettesFournisseursALaDateDu(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                    select fmp.SoldeDette).Sum();

                var totalAchats = (from f in db.AgeFournisseursMatieresPremieres
                                   join rmp in db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                                   where rmp.DateReception <= date
                                   select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiements = (from fmp in db.AgeFournisseursMatieresPremieres
                                      join d in db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                                      where d.DateDecaissement <= date
                                      select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFE = (from f in db.AgeAutreFournisseurs
                                      select f.SoldeInitialDetteFournisseur).Sum();

                var totalAchatsFE = (from f in db.AgeAutreFournisseurs
                                     join rmp in db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                                     join ei in db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                                     where ei.DateAcquisition <= date
                                     select (decimal?)ei.Montant).Sum() ?? 0m;

                var totalPaiementsFE = (from f in db.AgeAutreFournisseurs
                                        join d in db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                        where d.DateDecaissement <= date
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFS = (from f in db.AgeFournisseursServicesFournitures
                                      select f.SoldeDette).Sum();

                var totalAchatsFS = (from f in db.AgeFournisseursServicesFournitures
                                     join rmp in db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                                     where rmp.Date <= date
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiementsFS = (from f in db.EveAcquisitionServicesFournitures
                                        join d in db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                        where d.DateDecaissement <= date
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                return soldeInitial + soldeInitialFE + soldeInitialFS
                    + totalAchats + totalAchatsFE + totalPaiementsFS
                    - totalPaiements - totalPaiementsFE - totalPaiementsFS;
            }
        }

        public static decimal SoldeDisponibleDuCompteDeTresorerie(string nomCompte)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitial = (from c in db.ResComptesTresoreries
                                    where c.NomCompte == nomCompte
                                    select c.SoldeCompte).FirstOrDefault();

                var totalEncaissements = (from c in db.EveEncaissements
                                          join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                          where nc.NomCompte == nomCompte
                                          from env in db.EveEncaissementsVentes
                                          where c.CodeEncaissement == env.CodeEncaissement

                                          select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

                var encaissementCreances = (from c in db.EveEncaissements
                                            join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                            where nc.NomCompte == nomCompte
                                            from enc in db.EveEncaissementsCreances
                                            where c.CodeEncaissement == enc.CodeEncaissement

                                            select (decimal?)enc.MontantEncaisse).Sum() ?? 0m;

                var totalAutresEncaissement = (from c in db.EveEncaissements
                                               join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                               where nc.NomCompte == nomCompte
                                               from enA in db.EveEncaissementsAutres
                                               where c.CodeEncaissement == enA.CodeEncaissement

                                               select (decimal?)enA.MontantEncaisse).Sum() ?? 0m;

                var totalDecaissements = (from d in db.EveDecaissements
                                          where d.ResComptesTresorerie.NomCompte == nomCompte
                                          select (decimal?)d.Montant).Sum() ?? 0m;

                var fondsDisponibles = soldeInitial + totalEncaissements + encaissementCreances + totalAutresEncaissement - totalDecaissements;

                return fondsDisponibles;
            }
        }

        public static void AfficherSoldeTresorerie(ComboBox listeComptes, TextBox txtBox)
        {
            var compte = listeComptes.GetItemText(listeComptes.SelectedItem);
            txtBox.Text = SoldeDisponibleDuCompteDeTresorerie(compte).ToString("n0");
        }

        public static bool IlYaAssezDeFondsDansLeCompte(ComboBox cbxCompte, TextBox txtMontantPaye)
        {
            var nomCompte = cbxCompte.GetItemText(cbxCompte.SelectedItem);
            var soldeCompte = SoldeDisponibleDuCompteDeTresorerie(nomCompte);

            if (Validation.VerifierChampsMontant(txtMontantPaye.Text) && int.Parse(txtMontantPaye.Text) < soldeCompte && soldeCompte > 0m)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Il n'y a pas assez de fonds dans le compte séléctionné pour effectuer ce paiement. Veuillez changer de compte ou diminuer le montant.");
                return false;
            }

        }

        public static decimal CalculerSoldeDetteParFournisseur(string nomFournisseur)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {

                var soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                    where fmp.Nom == nomFournisseur
                                    select fmp.SoldeDette).FirstOrDefault();

                var totalAchats = (from f in db.AgeFournisseursMatieresPremieres
                                   where f.Nom == nomFournisseur
                                   join rmp in db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                                   select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiements = (from fmp in db.AgeFournisseursMatieresPremieres
                                      where fmp.Nom == nomFournisseur
                                      join d in db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                                      select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFE = (from f in db.AgeAutreFournisseurs
                                      where f.NomAutreFournisseur == nomFournisseur
                                      select f.SoldeInitialDetteFournisseur).FirstOrDefault();

                var totalAchatsFE = (from f in db.AgeAutreFournisseurs
                                     where f.NomAutreFournisseur == nomFournisseur
                                     join rmp in db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                                     join ei in db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                                     select (decimal?)ei.Montant).Sum() ?? 0m;

                var totalPaiementsFE = (from f in db.AgeAutreFournisseurs
                                        where f.NomAutreFournisseur == nomFournisseur
                                        join d in db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFS = (from f in db.AgeFournisseursServicesFournitures
                                      where f.NomFournisseurServiceFourniture == nomFournisseur
                                      select f.SoldeDette).FirstOrDefault();

                var totalAchatsFS = (from f in db.AgeFournisseursServicesFournitures
                                     where f.NomFournisseurServiceFourniture == nomFournisseur
                                     join rmp in db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiementsFS = (from f in db.AgeFournisseursServicesFournitures
                                        where f.NomFournisseurServiceFourniture == nomFournisseur
                                        join d in db.EveDecaissements on f.CodeFournisseurServiceFourniture equals d.CodeFournisseurService
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                return soldeInitial + soldeInitialFE + soldeInitialFS
                    + totalAchats + totalAchatsFE + totalPaiementsFS
                    - totalPaiements - totalPaiementsFE - totalPaiementsFS;
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

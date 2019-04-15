using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo
{
    class GestionStocks
    {
        /*
        private Single ValeurStockMatierePremiere(string nomMatiere)
        {
            //var listeMatieresPremieres = 
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var coutMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                           join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                           where mp.NomMatiere == nomMatiere
                                           select (decimal?)amp.Montant).Sum() ?? 0m;

                var coutTransportMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                                    join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                                    where mp.NomMatiere == nomMatiere
                                                    select (decimal?)amp.TransportMatierePremiere).Sum() ?? 0m;

                var quantiteAchetee = (from mp in db.ResStockMatieresPremieres
                                       join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                       where mp.NomMatiere == nomMatiere
                                       select (float?)amp.Quantite).Sum() ?? 0f;

                var coutTotal = coutMatierePremiere + coutTransportMatierePremiere;
                var stockInitial = (from mp in db.ResStockMatieresPremieres select mp.StockMatiere).FirstOrDefault();

                return 0f;
            }
        }
        */

        public static Single CalculerSoldeStockMatierePremiere(string nomMatiere, DateTime debutPeriod)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var stockInitial = (from mp in db.ResStockMatieresPremieres
                                    where mp.NomMatiere == nomMatiere
                                    select mp.StockMatiere).FirstOrDefault();

                var entrees = (from rmp in db.EveReceptionMatieresPremieres
                               where rmp.ResStockMatieresPremiere.NomMatiere == nomMatiere
                               where rmp.DateReception < debutPeriod
                               select (float?)rmp.Quantite).Sum() ?? 0;

                var sorties = (from ur in db.EveUtilisationMatieresPremieres
                               where ur.ResStockMatieresPremiere.NomMatiere == nomMatiere
                               join p in db.EveProductions on ur.CodeUtilisationRessource equals p.CodeUtilisationRessources
                               where p.Date < debutPeriod
                               select (float?)ur.QuantiteMatierePremiere).Sum() ?? 0;

                var autresSorties = (from asort in db.EveSortieDechetsMatieresPremieres
                                     where asort.ResStockMatieresPremiere.NomMatiere == nomMatiere
                                     where asort.DateSortie < debutPeriod
                                     select (float?)asort.QuantiteMatierePremiere).Sum() ?? 0;

                return (stockInitial + entrees) - (sorties + autresSorties);
            }

        }
        public static Single CoutUnitaireParMatierePremiere(string nomMatiere)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var quantiteAchetee = (from amp in db.EveReceptionMatieresPremieres
                                       where amp.ResStockMatieresPremiere.NomMatiere == nomMatiere
                                       select (float?)amp.Quantite).Sum() ?? 0f;
                var valeurDesAchats = (from amp in db.EveReceptionMatieresPremieres
                                       where amp.ResStockMatieresPremiere.NomMatiere == nomMatiere
                                       select (float?)amp.Montant).Sum() ?? 0f;
                var coutTransportMatierePremiere = (from amp in db.EveReceptionMatieresPremieres
                                                    where amp.ResStockMatieresPremiere.NomMatiere == nomMatiere
                                                    select (float?)amp.TransportMatierePremiere).Sum() ?? 0f;

                return (valeurDesAchats + coutTransportMatierePremiere) / quantiteAchetee;
            }
        }

        public static float ValeurAchatsMatierePremiere(string nomMatiere, DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var achats = (from amp in db.EveReceptionMatieresPremieres
                              where amp.ResStockMatieresPremiere.NomMatiere == nomMatiere
                              where amp.DateReception >= debut.Date
                              where amp.DateReception <= fin.Date
                              select (float?)amp.Montant).Sum() ?? 0f;
               
                var QuantitedonsRecu = (from amp in db.EveReceptionDonsMatieresPremieres
                              where amp.ResStockMatieresPremiere.NomMatiere == nomMatiere
                              where amp.DateReception >= debut.Date
                              where amp.DateReception <= fin.Date
                              select (float?)amp.Quantite).Sum() ?? 0f;

                var valeurDons = QuantitedonsRecu * CoutUnitaireParMatierePremiere(nomMatiere);

                return achats + valeurDons;
            }
        }

        public static decimal QuantiteMatierePremierePrincipaleParProduitFini(string nomProduit, string matierePremiere)
        {
            // calculer la quantite moyenne de matiere premiere utilisee par unite de produit fini

            using (CasaDBEntities db = new CasaDBEntities())
            {
                var quantiteDeMatierePremiereUtilisee = (from pf in db.ResStockProduitsFinis
                                                         join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                                                         join ur in db.EveUtilisationMatieresPremieres on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                                         where ur.ResStockMatieresPremiere.NomMatiere == matierePremiere
                                                         where ur.ResStockMatieresPremiere.TypeMatiere != "emballage"
                                                         where pf.NomProduit == nomProduit
                                                         select new
                                                         {
                                                             MatierePremiere = ur.ResStockMatieresPremiere.NomMatiere,
                                                             ur.QuantiteMatierePremiere,
                                                             ppf.QuantiteProduitFini
                                                         });
               
                var quantiteMatP = quantiteDeMatierePremiereUtilisee.Select(m => (float?)m.QuantiteMatierePremiere).Sum() ?? 0f;

                var quantitePF = quantiteDeMatierePremiereUtilisee.Select(m => (float?)m.QuantiteProduitFini).Sum() ?? 0f;

                decimal quantiteMoyenneParProduitFini = 0m;

                if (quantiteMatP > 0f && quantitePF > 0f)
                {
                    quantiteMoyenneParProduitFini = (decimal)quantiteMatP / (decimal)quantitePF;
                }

                return quantiteMoyenneParProduitFini; 
            }
        }

        public static float CalculerCoutUnitaireMatierePremiere(string matiere)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var valeurAchats = (from mp in db.ResStockMatieresPremieres
                                    join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                                    where rmp.DateReception.Year == DateTime.Now.Year
                                    where mp.NomMatiere == matiere
                                    select (float?)(rmp.Montant + rmp.TransportMatierePremiere)).Sum() ?? 0f;

                var quantitesAchetees = (from mp in db.ResStockMatieresPremieres
                                         join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                                         where rmp.DateReception.Year == DateTime.Now.Year
                                         where mp.NomMatiere == matiere
                                         select (float?)(rmp.Quantite)).Sum() ?? 0f;

                float coutUnitaire = valeurAchats / quantitesAchetees;

                return coutUnitaire; 
            }
        }
        /*
        public static Single MatieresPremieresUtilisees(string nomProduit, DateTime beginning, DateTime ending)
        {
            // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory

            using (CasaDBEntities2 db = new CasaDBEntities2())
            {
                var stockInitial = Conversion.
                var quantiteDisponibleDebutPeriod = 0;
            }
        }
        */
        }
    }

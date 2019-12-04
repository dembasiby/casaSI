using CasaEcologieSysInfo.Classes.CalculDesCouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo
{
    class GestionStocks
    {
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

        public static int CalculerSoldeStockProduitFini(string produitFini, DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var stockInitial = (from pf in db.ResStockProduitsFinis
                                    where pf.NomProduit == produitFini
                                    select pf.StockProduit).FirstOrDefault();

                var entrees = (from pro in db.EveProductionStockProduitsFinis
                               where pro.ResStockProduitsFini.NomProduit == produitFini
                               where pro.EveProduction.Date < date.Date
                               select (int?)pro.QuantiteProduitFini).Sum() ?? 0;

                var sorties = (from pf in db.EveVenteStockProduitsFinis
                               where pf.ResStockProduitsFini.NomProduit == produitFini
                               where pf.EveVente.DateVente < date.Date
                               select (int?)pf.QuantiteProduitFini).Sum() ?? 0;


                return stockInitial + entrees - sorties;
            }
        }

        public static int CalculerSoldeStockProduitSemiFini(string produitSemiFini, DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var stockInitial = (from psf in db.ResStockProduitsSemiFinis
                                    where psf.Description == produitSemiFini
                                    select psf.Quantite).FirstOrDefault();

                var entrees = (from pro in db.EveProductionProduitsSemiFinis
                               where pro.ResStockProduitsSemiFini.Description == produitSemiFini
                               where pro.EveProduction.Date < date.Date
                               select (int?)pro.QuantiteProduitSemiFini).Sum() ?? 0;

                var sorties = (from upsf in db.EveUtilisationProduitsSemiFinis
                               join ur in db.EveUtilisationRessources on upsf.CodeUtilisationRessource equals ur.CodeUtilisationRessources
                               join p in db.EveProductions on ur.CodeUtilisationRessources equals p.CodeUtilisationRessources
                               where upsf.ResStockProduitsSemiFini.Description == produitSemiFini
                               where p.Date < date.Date
                               select (int?)upsf.QuantiteProduitSemiFini).Sum() ?? 0;


                return stockInitial + entrees - sorties;
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

        public static decimal QuantiteMatierePremiereParProduitFini(string nomProduit, string matierePremiere)
        {
            // calculer la quantite moyenne de matiere premiere utilisee par unite de produit fini

            using (CasaDBEntities db = new CasaDBEntities())
            {
                var quantiteDeMatierePremiereUtilisee = (from pf in db.ResStockProduitsFinis
                                                         join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                                                         join ur in db.EveUtilisationMatieresPremieres on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                                         where ur.ResStockMatieresPremiere.NomMatiere == matierePremiere
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

        public static decimal QuantiteMatierePremiereParProduitSemiFini(string produitSemiFini, string matierePremiere)
        {
            // calculer la quantite moyenne de matiere premiere utilisee par unite de produit fini

            using (CasaDBEntities db = new CasaDBEntities())
            {
                var quantiteDeMatierePremiereUtilisee = (from psf in db.ResStockProduitsSemiFinis
                                                         join ppf in db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppf.CodeProduitSemiFini
                                                         join ur in db.EveUtilisationMatieresPremieres on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                                         where ur.ResStockMatieresPremiere.NomMatiere == matierePremiere
                                                         where psf.Description == produitSemiFini
                                                         select new
                                                         {
                                                             MatierePremiere = ur.ResStockMatieresPremiere.NomMatiere,
                                                             ur.QuantiteMatierePremiere,
                                                             ppf.QuantiteProduitSemiFini
                                                         });

                var quantiteMatP = quantiteDeMatierePremiereUtilisee.Select(m => (float?)m.QuantiteMatierePremiere).Sum() ?? 0f;

                var quantitePF = quantiteDeMatierePremiereUtilisee.Select(m => (float?)m.QuantiteProduitSemiFini).Sum() ?? 0f;

                decimal quantiteMoyenneParProduitFini = 0m;

                if (quantiteMatP > 0f && quantitePF > 0f)
                {
                    quantiteMoyenneParProduitFini = (decimal)quantiteMatP / (decimal)quantitePF;
                }

                return quantiteMoyenneParProduitFini;
            }
        }

        public static decimal QuantiteMProduitSemiFiniParProduitFini(string nomProduit, string produitSemiFini)
        {
            // calculer la quantite moyenne de matiere premiere utilisee par unite de produit fini

            using (CasaDBEntities db = new CasaDBEntities())
            {
                var quantiteProduitSemiFiniUtilisee = (from pf in db.ResStockProduitsFinis
                                                         join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                                                         join ur in db.EveUtilisationProduitsSemiFinis on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                                         where ur.ResStockProduitsSemiFini.Description == produitSemiFini
                                                         where pf.NomProduit == nomProduit
                                                         select new
                                                         {
                                                             ProduitSemiFini = ur.ResStockProduitsSemiFini.Description,
                                                             ur.QuantiteProduitSemiFini,
                                                             ppf.QuantiteProduitFini
                                                         });

                var quantiteProduitSemiFini = quantiteProduitSemiFiniUtilisee.Select(m => (float?)m.QuantiteProduitSemiFini).Sum() ?? 0f;

                var quantitePF = quantiteProduitSemiFiniUtilisee.Select(m => (float?)m.QuantiteProduitFini).Sum() ?? 0f;

                decimal quantiteMoyenneParProduitFini = 0m;

                if (quantiteProduitSemiFini > 0f && quantitePF > 0f)
                {
                    quantiteMoyenneParProduitFini = (decimal)quantiteProduitSemiFini / (decimal)quantitePF;
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

        public static Single ValeurTotalDesStocks(DateTime date)
        {
            return InventaireStocksProduitsFinis.ValeurStockProduitsFinis(date)
                + InventaireStockProduitsSemiFinis.ValeurStockProduitsSemiFinis(date)
                + InventaireStocksMatieresPremiere.ValeurStockMatieresPremieres(date);
        }
     
    }
}

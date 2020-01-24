using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo.Classes.CalculDesCouts
{
    class InventaireStocksProduitsFinis
    {
        public static int QuantiteDeProduitsVendus(string produitFini, DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                int stockInitial = GestionStocks.CalculerSoldeStockProduitFini(produitFini, debut);
                int stockFinal = GestionStocks.CalculerSoldeStockProduitFini(produitFini, fin);
                int entrees = (from ppf in db.EveProductionStockProduitsFinis
                               join pf in db.ResStockProduitsFinis on ppf.CodeProduitFini equals pf.CodeProduit
                               join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                               where pf.NomProduit == produitFini
                               where p.Date >= debut
                               where p.Date <= fin
                               select (int?)ppf.QuantiteProduitFini).Sum() ?? 0;

                var autresSorties = (from asort in db.EveSortieDonsOuDechetsProduitsFinis
                                     where asort.ResStockProduitsFini.NomProduit == produitFini
                                     where asort.DateSortie >= debut
                                     where asort.DateSortie <= fin
                                     select (int?)asort.QuantiteProduitFini).Sum() ?? 0;

                return stockInitial + entrees - autresSorties - stockFinal;
            }
        }

        public static int QuantiteDeProduitsSortisPourDonsOuDechets(string produitFini, DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return (from asort in db.EveSortieDonsOuDechetsProduitsFinis
                                     where asort.ResStockProduitsFini.NomProduit == produitFini
                                     where asort.DateSortie >= debut
                                     where asort.DateSortie <= fin
                                     select (int?)asort.QuantiteProduitFini).Sum() ?? 0;
            }
        }

        public static Single CoutDesProduitsVendusParProduitFini(string produitFini, DateTime debut, DateTime fin)
        {
            Single coutDesProduitsVendusParProduit;

            int quantiteDeProduitsVendus = QuantiteDeProduitsVendus(produitFini, debut, fin);
            Single valeurUnitaire = CoutDeProduction.CoutUnitaireProduction(produitFini);

            coutDesProduitsVendusParProduit = quantiteDeProduitsVendus * valeurUnitaire;

            return coutDesProduitsVendusParProduit;
        }

        public static Single CoutDesProduitsVendus(DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single cogs = 0;
                var listeProduitsVendus = (from pf in db.ResStockProduitsFinis
                                           join vpf in db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                                           join v in db.EveVentes on vpf.CodeVente equals v.CodeVente
                                           where v.DateVente >= debut
                                           where v.DateVente <= fin
                                           select pf.NomProduit).ToList();

                foreach (var produit in listeProduitsVendus)
                {
                    cogs += CoutDesProduitsVendusParProduitFini(produit, debut, fin);
                }

                return cogs;
            }
        }

        public static Single ValeurStockProduitsFinis(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single valeurStockProduitsFinis = 0;
                var listeProduitsFinis = (from pf in db.ResStockProduitsFinis
                                          select pf.NomProduit).ToList();

                foreach (var produitFini in listeProduitsFinis)
                {
                    valeurStockProduitsFinis += GestionStocks.CalculerSoldeStockProduitFini(produitFini, date) * CoutDeProduction.CoutUnitaireProduction(produitFini);
                }

                return valeurStockProduitsFinis;

            }
        }
    }
}

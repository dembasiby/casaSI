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
                fin = fin.AddDays(1);
                int stockFinal = GestionStocks.CalculerSoldeStockProduitFini(produitFini, fin);
                int entrees = (from ppf in db.EveProductionStockProduitsFinis
                               join pf in db.ResStockProduitsFinis on ppf.CodeProduitFini equals pf.CodeProduit
                               join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                               where pf.NomProduit == produitFini
                               where p.Date >= debut
                               where p.Date < fin
                               select (int?)ppf.QuantiteProduitFini).Sum() ?? 0;

                return stockInitial + entrees - stockFinal;
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
                date = date.AddDays(1);

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

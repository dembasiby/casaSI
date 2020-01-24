using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo.Classes.CalculDesCouts
{
    class InventaireStockProduitsSemiFinis
    {
        public static Single QuantiteDeProduitsSemiFinisUtilisee(string produitSF, DateTime debut, DateTime fin)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single stockInitial = GestionStocks.CalculerSoldeStockProduitSemiFini(produitSF, debut);
                Single stockFinal = GestionStocks.CalculerSoldeStockProduitSemiFini(produitSF, fin);

                Single entrees = (from pro in db.EveProductionProduitsSemiFinis
                               where pro.ResStockProduitsSemiFini.Description == produitSF
                               where pro.EveProduction.Date >= debut
                               where pro.EveProduction.Date < fin
                               select pro.QuantiteProduitSemiFini).Sum();
                
                return stockInitial + entrees - stockFinal;
            }
        }

        // A UTILISER DANS LE BILAN
        public static Single ValeurStockProduitsSemiFinis(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single valeurStockProduitsFinis = 0;
                var listeProduitsSemiFinis = (from psf in db.ResStockProduitsSemiFinis
                                          select psf.Description).ToList();

                foreach (var produitSemiFini in listeProduitsSemiFinis)
                {
                    valeurStockProduitsFinis += GestionStocks.CalculerSoldeStockProduitSemiFini(produitSemiFini, date) * CoutDeProduction.CoutUnitaireProduitSemiFini(produitSemiFini);
                }

                return valeurStockProduitsFinis;

            }
        }
    }
}

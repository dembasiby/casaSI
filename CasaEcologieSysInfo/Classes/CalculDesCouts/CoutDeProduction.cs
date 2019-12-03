using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo.Classes.CalculDesCouts
{
    class CoutDeProduction
    {
        public static Single CoutProduction(DateTime debutPeriode, DateTime finPeriode, string produitFini)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var listeMatieres = (from pf in db.ResStockProduitsFinis
                                              join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                                              join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                                              join ur in db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                              where pf.NomProduit == produitFini

                                              select new
                                              {
                                                  Matiere = ur.ResStockMatieresPremiere.NomMatiere
                                              }).ToList();

                Single coutMatieresPremieres = 0;

                foreach (var mat in listeMatieres)
                {
                    Single coutMatiere = InventaireStocksMatieresPremiere.CoutDesMatieresConsommees(debutPeriode, finPeriode, mat.Matiere);
                    coutMatieresPremieres += coutMatiere;                  
                }

                return coutMatieresPremieres;
            }
        }

        public static Single CoutUnitaireProduction(string produitFini)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var listeMatieres = (from pf in db.ResStockProduitsFinis
                                     join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                                     join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                                     join ur in db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                     where pf.NomProduit == produitFini

                                     select new
                                     {
                                         Matiere = ur.ResStockMatieresPremiere.NomMatiere
                                     }).ToList();

                Single coutMatieresPremieresParProduit = 0;

                foreach (var mat in listeMatieres)
                {
                    Single coutMatiere = (float)GestionStocks.QuantiteMatierePremiereParProduitFini(produitFini, mat.Matiere) * CoutDAchatDesMatierePremieres.CoutDAchat(mat.Matiere);
                    coutMatieresPremieresParProduit += coutMatiere;
                }

                if (coutMatieresPremieresParProduit == 0)
                {
                    coutMatieresPremieresParProduit = (from pf in db.ResStockProduitsFinis
                                                       where pf.NomProduit == produitFini
                                                       select pf.CoutUnitaire).FirstOrDefault();
                }

                return coutMatieresPremieresParProduit;
            }
        }

        public static Single CoutUnitaireProduitSemiFini(string produitSemiFini)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var listeMatieres = (from psf in db.ResStockProduitsSemiFinis
                                     join ppf in db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppf.CodeProduitSemiFini
                                     join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                                     join ur in db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                     where psf.Description == produitSemiFini

                                     select new
                                     {
                                         Matiere = ur.ResStockMatieresPremiere.NomMatiere
                                     }).ToList();

                Single coutMatieresPremieresParProduitSemiFini = 0;

                foreach (var mat in listeMatieres)
                {
                    Single coutMatiere = (float)GestionStocks.QuantiteMatierePremiereParProduitSemiFini(produitSemiFini, mat.Matiere) * CoutDAchatDesMatierePremieres.CoutDAchat(mat.Matiere);
                    coutMatieresPremieresParProduitSemiFini += coutMatiere;
                }

                if (coutMatieresPremieresParProduitSemiFini == 0)
                {
                    coutMatieresPremieresParProduitSemiFini = (from psf in db.ResStockProduitsSemiFinis
                                                               where psf.Description == produitSemiFini
                                                               select psf.CoutUnitaire).FirstOrDefault();
                }

                return coutMatieresPremieresParProduitSemiFini;
            }
        }
    }
}

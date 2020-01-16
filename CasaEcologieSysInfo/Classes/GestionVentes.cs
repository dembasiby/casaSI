using System.Linq;

namespace CasaEcologieSysInfo.Classes
{
    class GestionVentes
    {
        public static void EnregistrerNouvelleVenteDUnProduit(int codeVente, string nomProduit, string quantite, string montant)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                if (int.Parse(quantite) >= 1 && int.Parse(montant) >= 1)
                {
                    ResStockProduitsFini produit = db.ResStockProduitsFinis.FirstOrDefault(p => p.NomProduit == nomProduit);

                    var venteProduit = new EveVenteStockProduitsFini
                    {
                        CodeVente = codeVente,
                        CodeProduitFini = produit.CodeProduit,
                        QuantiteProduitFini = int.Parse(quantite),
                        Montant = int.Parse(montant),
                    };

                    db.EveVenteStockProduitsFinis.Add(venteProduit);
                    db.SaveChanges();
                }
            }
        }

        public static void MettreAJourVenteDUnProduit(int codeVente, string nomProduit, string quantite, string montant)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                if (int.Parse(quantite) >= 1 && int.Parse(montant) >= 1)
                {
                    ResStockProduitsFini produit = db.ResStockProduitsFinis.FirstOrDefault(p => p.NomProduit == nomProduit);


                    var venteProduit = db.EveVenteStockProduitsFinis.Where(vp => vp.CodeVente == codeVente).FirstOrDefault(vp => vp.CodeProduitFini == produit.CodeProduit);
                    venteProduit.QuantiteProduitFini = int.Parse(quantite);
                    venteProduit.Montant = int.Parse(montant);
                    
                    db.SaveChanges();
                }
            }
        }

        public static void MettreEncaissementVenteAJour(int codeVente, decimal montant, int codeCompte)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var encaissementVente = (from ev in db.EveEncaissementsVentes
                                         join e in db.EveEncaissements on ev.CodeEncaissement equals e.CodeEncaissement
                                         where ev.CodeVente == codeVente
                                         select ev).FirstOrDefault();

                encaissementVente.MontantEncaisse = montant;
                encaissementVente.EveEncaissement.CodeCompte = codeCompte;

                db.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo
{
    class GestionStocks
    {
        private Single CoutUnitaireParMatierePremiere(string nomMatiere)
        {
            using (CasaDBEntities2 db = new CasaDBEntities2())
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

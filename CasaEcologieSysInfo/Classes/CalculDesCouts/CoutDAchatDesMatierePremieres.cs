using System;
using System.Linq;

namespace CasaEcologieSysInfo.Classes.CalculDesCouts
{
    class CoutDAchatDesMatierePremieres
    {
        public static Single CoutDAchat(string mPrem)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single coutUnitaire = (Single)(from mp in db.ResStockMatieresPremieres
                                       where mp.NomMatiere == mPrem
                                       select mp.CoutUnitaire).FirstOrDefault();

                Single coutMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                           join amp in db.EveReceptionMatieresPremieres 
                                                on mp.CodeMatierePremiere 
                                                equals amp.CodeMatierePremiere
                                           where mp.NomMatiere == mPrem
                                           select (Single?)amp.Montant).Sum() ?? 0f;

                Single coutTransportMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                                    join amp in db.EveReceptionMatieresPremieres 
                                                        on mp.CodeMatierePremiere 
                                                        equals amp.CodeMatierePremiere
                                                    where mp.NomMatiere == mPrem
                                                    select (Single?)amp.TransportMatierePremiere).Sum() ?? 0f;

                Single quantiteAchetee = (from mp in db.ResStockMatieresPremieres
                                       join amp in db.EveReceptionMatieresPremieres 
                                            on mp.CodeMatierePremiere 
                                            equals amp.CodeMatierePremiere
                                       where mp.NomMatiere == mPrem
                                       select (Single?)amp.Quantite).Sum() ?? 0f;

                Single coutTotal = coutMatierePremiere + coutTransportMatierePremiere;

                if (Convert.ToInt32(quantiteAchetee) > 0) coutUnitaire = coutTotal / quantiteAchetee;

                return coutUnitaire;
            }
        }
    }
}

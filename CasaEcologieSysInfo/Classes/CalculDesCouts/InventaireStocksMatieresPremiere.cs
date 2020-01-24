using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo.Classes.CalculDesCouts
{
    class InventaireStocksMatieresPremiere
    {
        public static Single QuantiteDeMatieresConsommees(DateTime debutPeriode, DateTime finPeriode, string matiere)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single stockInitial = GestionStocks.CalculerSoldeStockMatierePremiere(matiere, debutPeriode);
                Single stockFinal = GestionStocks.CalculerSoldeStockMatierePremiere(matiere, finPeriode);

                Single achatsMatierePremiere = (from rmp in db.EveReceptionMatieresPremieres
                                              where rmp.ResStockMatieresPremiere.NomMatiere == matiere
                                              where rmp.DateReception >= debutPeriode
                                              where rmp.DateReception <= finPeriode
                                              select (float?)rmp.Quantite).Sum() ?? 0;
                Single receptionDonsMatierePremiere = (from rdmp in db.EveReceptionDonsMatieresPremieres
                                                       where rdmp.ResStockMatieresPremiere.NomMatiere == matiere
                                                       where rdmp.DateReception >= debutPeriode
                                                       where rdmp.DateReception <= finPeriode
                                                       select (float?)rdmp.Quantite).Sum() ?? 0;
                Single entrees = achatsMatierePremiere + receptionDonsMatierePremiere;

                return stockInitial + entrees - stockFinal;
            }
            
        }

        public static Single CoutDesMatieresConsommees(DateTime debutPeriode, DateTime finPeriode, string matiere)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single quantiteMatiere = QuantiteDeMatieresConsommees(debutPeriode, finPeriode, matiere);
                string coutUnitaireStandard = (from mp in db.ResStockMatieresPremieres where mp.NomMatiere == matiere select mp.CoutUnitaire)
                    .SingleOrDefault()
                    .ToString();
                Single coutUnitaire;

                if (CoutDAchatDesMatierePremieres.CoutDAchat(matiere) > 0)
                {
                    coutUnitaire = CoutDAchatDesMatierePremieres.CoutDAchat(matiere);
                } else
                {
                    coutUnitaire = Single.Parse(coutUnitaireStandard);
                }
                    

                return quantiteMatiere * coutUnitaire;
            }
            
        }

        public static Single ValeurStockMatieresPremieres(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                Single valeurStockMatieresPremieres = 0;
                var listeMatieresPremieres = (from mp in db.ResStockMatieresPremieres
                                          select mp.NomMatiere).ToList();

                foreach (var matPrem in listeMatieresPremieres)
                {
                    valeurStockMatieresPremieres += GestionStocks.CalculerSoldeStockMatierePremiere(matPrem, date) * CoutDAchatDesMatierePremieres.CoutDAchat(matPrem);
                }

                return valeurStockMatieresPremieres;

            }
        }
    }
}

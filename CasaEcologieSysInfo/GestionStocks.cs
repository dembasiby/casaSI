using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaEcologieSysInfo
{
    class GestionStocks
    {
        public static Single MatieresPremieresUtilisees(DateTime beginning, DateTime ending)
        {
            // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory

            using (CasaDBEntities2 db = new CasaDBEntities2())
            {
                var prixUnitaire = (from amp in db.eve)
            }
        }
    }
}

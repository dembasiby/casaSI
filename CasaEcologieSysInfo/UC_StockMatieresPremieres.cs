using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_StockMatieresPremieres : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_StockMatieresPremieres()
        {
            InitializeComponent();
        }

        public static int CalculerSoldeStocks(int id)
        {
            CasaDBEntities2 db = new CasaDBEntities2();

            int init = db.ResStockMatieresPremieres
                .Where(s => s.CodeMatierePremiere == id)
                .Select(m => m.StockMatiere).SingleOrDefault();

            int entrees = db.EveReceptionMatieresPremieres
                .Where(e => e.CodeMatierePremiere == id)
                .Sum(q => q.Quantite);

            int sorties = db.EveUtilisationMatieresPremieres
                .Where(e => e.CodeMatierePremiere == id)
                .Sum(q => q.QuantiteMatierePremiere);

            return init + entrees - sorties;
        }

        private void UC_StockMatieresPremieres_Load(object sender, EventArgs e)
        {
            var Entrees = (from smp in db.ResStockMatieresPremieres
                      from rmp in db.EveReceptionMatieresPremieres                     
                      where smp.CodeMatierePremiere == rmp.CodeMatierePremiere

                      select new 
                      {
                          DateOperation = rmp.DateReception,
                          Description = smp.NomMatiere,
                          Entree = rmp.Quantite,
                          Sortie = 0,
                          Solde = 0
                                 
                      });

            var Sorties = (from smp in db.ResStockMatieresPremieres
                           from ump in db.EveUtilisationMatieresPremieres
                           from ur in db.EveUtilisationRessources
                           from p in db.EveProductions
                           where ump.CodeMatierePremiere == smp.CodeMatierePremiere
                           where p.CodeUtilisationRessources == ur.CodeUtilisationRessources
                           where ump.CodeUtilisationRessource == p.CodeUtilisationRessources

                           select new
                           {
                               DateOperation = p.Date,
                               Description = smp.NomMatiere,
                               Entree = 0,
                               Sortie = ump.QuantiteMatierePremiere,
                               Solde = 0
                           });

            
            var result = Entrees.Union(Sorties)
                .OrderByDescending(d => d.DateOperation)
                .ToList();  
            
            adgvJournalStockMatieresPremieres.DataSource = result;

            // 

        }


    }
}

    public class StockMatierePremiereViewModel
    {
        public DateTime Date { get; set; }
        public string NomMatiere { get; set; }
        public decimal Entree { get; set; }
        public decimal Sortie { get; set; }
        public int Solde { get; set; }       
    }
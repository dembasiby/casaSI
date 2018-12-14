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

        public static decimal CalculerSoldeStocks(int id)
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

            return Convert.ToDecimal(init + entrees - sorties);
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

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(result);

            adgvJournalStockMatieresPremieres.DataSource = dt;

            /*
            for (int i = adgvJournalStockMatieresPremieres.Rows.Count - 1; i >= 0; i--)
            {
                if (i == adgvJournalStockMatieresPremieres.Rows.Count - 1)
                {
                    adgvJournalStockMatieresPremieres.Rows[i].Cells[4].Value = (int)adgvJournalStockMatieresPremieres.Rows[i].Cells[2].Value - (int)adgvJournalStockMatieresPremieres.Rows[i].Cells[3].Value;
                }
                else
                {
                    adgvJournalStockMatieresPremieres.Rows[i].Cells[4].Value = (int)adgvJournalStockMatieresPremieres.Rows[i+1].Cells[4].Value + (int)adgvJournalStockMatieresPremieres.Rows[i].Cells[2].Value - (int)adgvJournalStockMatieresPremieres.Rows[i].Cells[3].Value;
                }
                
            }
            */

        }

        

        private void AdgvJournalStockMatieresPremieres_FilterStringChanged(object sender, EventArgs e)
        {
            Conversion.FiltrerTableau(sender, e);
        }

        private void AdgvJournalStockMatieresPremieres_SortStringChanged(object sender, EventArgs e)
        {
            Conversion.TrierTableau(sender, e);
        }
    }
}

 
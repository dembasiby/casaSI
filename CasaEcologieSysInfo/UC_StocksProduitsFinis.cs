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
    public partial class UC_StocksProduitsFinis : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_StocksProduitsFinis()
        {
            InitializeComponent();
        }

        private void UC_StocksProduitsFinis_Load(object sender, EventArgs e)
        {
            var entrees = (from pf in db.ResStockProduitsFinis
                           join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                           join prod in db.EveProductions on ppf.CodeProduction equals prod.CodeProduction
                           
                           select new
                           {
                               Date = prod.Date,
                               Description = pf.NomProduit,
                               Entree = ppf.QuantiteProduitFini,
                               Sortie = 0,
                               Solde = 0
                           });

            var sorties = (from pf in db.ResStockProduitsFinis
                           join vpf in db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                           join v in db.EveVentes on vpf.CodeVente equals v.CodeVente

                           select new
                           {
                               Date = v.DateVente,
                               Description = pf.NomProduit,
                               Entree = 0,
                               Sortie = vpf.QuantiteProduitFini,
                               Solde = 0
                           });

            var resultat = entrees.Union(sorties)
                .OrderByDescending(d => d.Date)
                .ToList();

            DataTable dt = Conversion.ConvertToDataTable(resultat);
            adgvJournalStocksProduitsFinis.DataSource = dt;
        }
    }
}

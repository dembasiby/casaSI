using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CasaEcologieSysInfo
{
    public partial class UC_JournalVentes : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_JournalVentes()
        {
            InitializeComponent();
        }

        private void UC_JournalVentes_Load(object sender, EventArgs e)
        {
            var ventes = (from v in db.EveVentes
                          join vpf in db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                          join pf in db.ResStockProduitsFinis on vpf.CodeProduitFini equals pf.CodeProduit
                          join c in db.AgeClients on v.CodeClient equals c.CodeClient

                          select new
                          {
                              Date = v.DateVente,
                              Description = pf.NomProduit,
                              Quantité = vpf.QuantiteProduitFini + " unités",
                              Client = c.NomClient,
                              Montant = vpf.Montant
                          }).ToList();

            DataTable dt = Conversion.ConvertToDataTable(ventes);            
            adgvJournalVentes.DataSource = dt;
            adgvJournalVentes.Columns["Montant"].DefaultCellStyle.Format = "c0";
        }

        private void AdgvJournalVentes_FilterStringChanged(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.RowFilter = myDataGrid.FilterString;
        }

        private void AdgvJournalVentes_SortStringChanged(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.Sort = myDataGrid.SortString;
        }
    }
}

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

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=CasaDB;Integrated Security=True");

        public UC_JournalVentes()
        {
            InitializeComponent();
        }  

        private void LoadJournalData(String query, DataGridView dgv)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns["Montant"].DefaultCellStyle.Format = "C";           
        }

        private void UC_JournalVentes_Load(object sender, EventArgs e)
        {           
            String query = "SELECT EveVentes.DateVente as Date, ResStockProduitsFinis.NomProduit as Description, AgeClients.NomClient as Clients, EveVenteStockProduitsFinis.Montant as Montant FROM AgeClients INNER JOIN EveVentes ON AgeClients.CodeClient = EveVentes.CodeClient INNER JOIN EveVenteStockProduitsFinis ON EveVentes.CodeVente = EveVenteStockProduitsFinis.CodeVente INNER JOIN ResStockProduitsFinis ON EveVenteStockProduitsFinis.CodeProduitFini = ResStockProduitsFinis.CodeProduit ORDER BY EveVentes.DateVente DESC";

            LoadJournalData(query, adgvJournalVentes);
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

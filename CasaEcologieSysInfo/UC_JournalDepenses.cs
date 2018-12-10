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
    public partial class UC_JournalDepenses : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=CasaDB;Integrated Security=True");

        public UC_JournalDepenses()
        {
            InitializeComponent();
            
        }

        private void LoadJournalData(String query, DataGridView dgv)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns["Montant"].DefaultCellStyle.Format = "C0";
        }

        private void LoadJournalDepensesMP()
        {
            String query = "SELECT EveReceptionMatieresPremieres.DateReception as Date, ResStockMatieresPremieres.NomMatiere as Description, EveReceptionMatieresPremieres.Montant as Montant FROM EveReceptionMatieresPremieres JOIN ResStockMatieresPremieres ON ResStockMatieresPremieres.CodeMatierePremiere = EveReceptionMatieresPremieres.CodeMatierePremiere ORDER BY EveReceptionMatieresPremieres.DateReception DESC";

            LoadJournalData(query, adgvDepensesMatPrem);
        }

        private void LoadJournalDepensesSF()
        {
            String query = "SELECT EveAcquisitionServicesFournitures.Date as Date, ResServicesFournitures.NomServiceFourniture as Description, EveAcquisitionServicesFournitures.Montant as Montant FROM EveAcquisitionServicesFournitures JOIN ResServicesFournitures ON EveAcquisitionServicesFournitures.CodeServiceFourniture = ResServicesFournitures.CodeServiceFourniture ORDER BY EveAcquisitionServicesFournitures.Date DESC";

            LoadJournalData(query, dataGridView2);
        }

        private void LoadJournalDepensesIM()
        {
            String query = "SELECT EveReceptionEquipementsInfrastructures.DateReception as Date, ResEquipementsInfrastructures.Nom as Description, ResEquipementsInfrastructures.Cout as Montant FROM ResEquipementsInfrastructures JOIN EveReceptionEquipementsInfrastructures ON ResEquipementsInfrastructures.CodeEquipementInfrastructure = EveReceptionEquipementsInfrastructures.CodeEquipementInfrastructure ORDER BY EveReceptionEquipementsInfrastructures.DateReception DESC";

            LoadJournalData(query, dataGridView3);
        }

        private void UC_JournalDepenses_Load(object sender, EventArgs e)
        {
            LoadJournalDepensesMP();
            LoadJournalDepensesSF();
            LoadJournalDepensesIM();
        }

        private void AdgvDepensesMatPrem_FilterStringChanged(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.RowFilter = myDataGrid.FilterString;
        }

        private void AdgvDepensesMatPrem_SortStringChanged(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.Sort = myDataGrid.SortString;
        }
    }
}

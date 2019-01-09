using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace CasaEcologieSysInfo
{
    public partial class UC_TableauDeBord : UserControl
    {

        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_TableauDeBord()
        {
            InitializeComponent();
        }

        private void UC_TableauDeBord_Load(object sender, EventArgs e)
        {
            ventesMensuellesResultBindingSource.DataSource = db.VentesMensuelles().ToList();
            var tableau = db.VentesMensuelles().ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(tableau);


            var startingYear = 2018;

            dataGridView1.DataSource = dt;

            var Annees = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Annees.Add(startingYear);
                startingYear++;
            }

            listBox1.DataSource = Annees;
            


           

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Format = "c0";
            }
          




        }
    }
}

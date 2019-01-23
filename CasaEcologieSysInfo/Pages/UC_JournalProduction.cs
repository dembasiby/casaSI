using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_JournalProduction : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_JournalProduction()
        {
            InitializeComponent();
        }

        private void UC_JournalProduction_Load(object sender, EventArgs e)
        {
            AfficherDatesProduction();
        }

        private void AfficherDatesProduction()
        {
            var listeProduction = (from prod in db.EveProductions
                                   select new
                                   {
                                       prod.Date,
                                       Code = prod.CodeProduction
                                   })
                                   .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(listeProduction);
            //lbxDatesProduction.DataSource = dt;
            dataGridView1.DataSource = dt;
        }
    }
}

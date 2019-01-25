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
    public partial class UC_CompteDeResultat : UserControl
    {

        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_CompteDeResultat()
        {
            InitializeComponent();
            AfficherAnnees();
        }

        private void AfficherAnnees()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private string CalculerVentesMois(int NumMois, DateTime annee)
        {
            return ((from v in db.EveVentes
                    join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                    where v.DateVente.Year == annee.Year
                    where v.DateVente.Month == NumMois
                    select (decimal?)vp.Montant).Sum() ?? 0m).ToString("n0");
        }

        private void AfficherVentesMensuelles()
        {
            
        }



        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherVentesMensuelles();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

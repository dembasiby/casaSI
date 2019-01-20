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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private string CalculerVentesMois(int NumMois)
        {
            return ((from v in db.EveVentes
                    join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                    where v.DateVente.Year == DateTime.Now.Year
                    where v.DateVente.Month == NumMois
                    select (decimal?)vp.Montant).Sum() ?? 0m).ToString("n0");
        }

        private void AfficherVentesMensuelles()
        {
            txtVentesJan.Text = CalculerVentesMois(1);
            txtVentesFev.Text = CalculerVentesMois(2);
            txtVentesMars.Text = CalculerVentesMois(3);
            txtVentesAvr.Text = CalculerVentesMois(4);
            txtVentesMai.Text = CalculerVentesMois(5);
            txtVentesJun.Text = CalculerVentesMois(6);
            txtVentesJul.Text = CalculerVentesMois(7);
            txtVentesAou.Text = CalculerVentesMois(8);
            txtVentesSep.Text = CalculerVentesMois(9);
            txtVentesOct.Text = CalculerVentesMois(10);
            txtVentesNov.Text = CalculerVentesMois(11);
            txtVentesDec.Text = CalculerVentesMois(12);

        }



        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherVentesMensuelles();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdateProduction : UserControl
    {
        public UC_UpdateProduction()
        {
            InitializeComponent();
        }

        private void DgvListeProductions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListeProductions.Rows[e.RowIndex];
            int codeProduction = int.Parse(row.Cells["Code"].Value.ToString());
            ReloadAll();
            LoadDetailsProduction(codeProduction);
        }




        // FONCTIONS D'AFFICHAGE DES DONNEES
        private void ReloadAll()
        {
            // throw new NotImplementedException();
        }

        private void LoadDetailsProduction(int codeProduction)
        {
            // throw new NotImplementedException();
        }

        private void UC_UpdateProduction_Load(object sender, EventArgs e)
        {
            AfficherDatesProductions();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherDatesProductions();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherDatesProductions();
        }

        private void AfficherDatesProductions()
        {
            Production.AfficherDatesProduction(dtpDebut, dtpFin, dgvListeProductions);
        }
    }
}

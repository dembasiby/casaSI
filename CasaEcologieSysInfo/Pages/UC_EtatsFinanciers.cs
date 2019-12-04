using CasaEcologieSysInfo.Classes;
using CasaEcologieSysInfo.Classes.CalculDesCouts;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_EtatsFinanciers : UserControl
    {

        CasaDBEntities db = new CasaDBEntities();

        public UC_EtatsFinanciers()
        {
            InitializeComponent();
        }

        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void AfficherEtatsFinanciers()
        {
            AfficherCompteDeResultat();
            AfficherTableauDeTresorerie();
            AfficherTableauBilan();
        }

        private void AfficherCompteDeResultat()
        {
            var debut = dtpDebut;
            var fin = dtpFin;

            ReInitialiserTableau(dgvCpteResultats);
            CompteDeResultat.AfficherCompteDeResultats(dgvCpteResultats, debut, fin);           
        }

        private void AfficherTableauDeTresorerie()
        {
            var debut = dtpDebut;
            var fin = dtpFin;

            ReInitialiserTableau(dgvTableauTresorerie);
            Tresorerie.AfficherTresorerie(dgvTableauTresorerie, debut, fin);       
        }

        private void AfficherTableauBilan()
        {
            var debut = dtpDebut;
            var fin = dtpFin;

            ReInitialiserTableau(dgvBilan);
            Bilan.AfficherBilan(dgvBilan, debut, fin);
        }


        private void ReInitialiserTableau(DataGridView tableau)
        {
            tableau.Rows.Clear();
        }

        /// <summary>
        /// EVENT HANDLING
        /// </summary>

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        //  Impression des tableaux
        private void BtnImprimerCpteResultat_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Compte de résultats", dgvCpteResultats);
        }

        private void BtnImprimerTablTresorerie_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Tableau de trésorerie", dgvTableauTresorerie);
        }

        private void BtnImprimerBilan_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Bilan", dgvBilan);
        }
    }
}

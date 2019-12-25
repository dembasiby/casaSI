using CasaEcologieSysInfo.Classes;
using System;
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

        // GESTION DES EVENEMENTS
        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        // GESTION DE L'AFFICHAGE DES TABLEAUX
        private void AfficherEtatsFinanciers()
        {
            AfficherCompteDeResultat();
            AfficherTableauDeTresorerie();
            AfficherTableauBilan();
        }

        private void AfficherCompteDeResultat()
        {
            ReInitialiserTableau(dgvCpteResultats);
            CompteDeResultat.AfficherCompteDeResultats(dgvCpteResultats, dtpDebut, dtpFin);           
        }

        private void AfficherTableauDeTresorerie()
        {
            ReInitialiserTableau(dgvTableauTresorerie);
            Tresorerie.AfficherTresorerie(dgvTableauTresorerie, dtpDebut, dtpFin);       
        }

        private void AfficherTableauBilan()
        {
            ReInitialiserTableau(dgvBilan);
            Bilan.AfficherBilan(dgvBilan, dtpDebut, dtpFin);
        }

        private void ReInitialiserTableau(DataGridView tableau)
        {
            tableau.Rows.Clear();
        }
     
        //  IMPRESSION DES TABLEAUX
        private void BtnImprimerCpteResultat_Click(object sender, EventArgs e)
        {
            string titre = "Compte de résultats du " 
                         + dtpDebut.Value.ToShortDateString() 
                         + " au " + dtpFin.Value.ToShortDateString();
            Impression.ImprimerTableau(titre, dgvCpteResultats);
        }

        private void BtnImprimerTablTresorerie_Click(object sender, EventArgs e)
        {
            string titre = "Tableau de trésorerie du " 
                         + dtpDebut.Value.ToShortDateString() 
                         + " au " + dtpFin.Value.ToShortDateString();
            Impression.ImprimerTableau(titre, dgvTableauTresorerie);
        }

        private void BtnImprimerBilan_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Bilan au " + dtpFin.Value.ToShortDateString(), dgvBilan);
        }
    }
}

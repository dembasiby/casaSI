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

        //Double Tot = 0;

        public UC_JournalVentes()
        {
            InitializeComponent();
        }

        private void UC_JournalVentes_Load(object sender, EventArgs e)
        {
            ageClientBindingSource.DataSource = db.AgeClients.OrderBy(c => c.NomClient).ToList();
            resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.OrderBy(p => p.NomProduit).ToList();

            var ventes = (from v in db.EveVentes
                          join vpf in db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                          join pf in db.ResStockProduitsFinis on vpf.CodeProduitFini equals pf.CodeProduit
                          join c in db.AgeClients on v.CodeClient equals c.CodeClient

                          select new
                          {
                              Date = v.DateVente,
                              Description = pf.NomProduit,
                              Quantité = vpf.QuantiteProduitFini,
                              Client = c.NomClient,
                              vpf.Montant
                          }).ToList();

            DefinirSourceDeDonnees(ventes);
        }

        private void DefinirSourceDeDonnees<T>(List<T> ventes)
        {
            DataTable dt = Conversion.ConvertirEnTableDeDonnees(ventes);

            dgvJournalVentes.DataSource = dt;
            dt.Rows.Add(DateTime.Now, "Total", 0, "", Conversion.CalculerTotal(dgvJournalVentes, "Montant"));

            dgvJournalVentes.Columns["Montant"].DefaultCellStyle.Format = "n0";
            dgvJournalVentes.Columns["Montant"].HeaderText = "Montant(FCFA)";
            dgvJournalVentes.Columns["Quantité"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJournalVentes.Columns["Montant"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvJournalVentes.Columns["Quantité"].HeaderText = "Quantité(unités)";
        }

        private void FiltrerTableau(DateTime end, DateTime start=default(DateTime), string nomClient="", string produit = "")
        {
            var ventes = (from v in db.EveVentes
                          join vpf in db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                          join pf in db.ResStockProduitsFinis on vpf.CodeProduitFini equals pf.CodeProduit
                          join c in db.AgeClients on v.CodeClient equals c.CodeClient
                          where (nomClient.Length > 0) ? c.NomClient == nomClient : c.NomClient != ""
                          where (produit.Length > 0) ? pf.NomProduit == produit : pf.NomProduit != ""
                          where v.DateVente >= start.Date
                          where v.DateVente <= end.Date

                          select new
                          {
                              Date = v.DateVente,
                              Description = pf.NomProduit,
                              Quantité = vpf.QuantiteProduitFini,
                              Client = c.NomClient,
                              vpf.Montant
                          }).ToList();

            DefinirSourceDeDonnees(ventes);
        }

        private void AfficherResultatsFiltre()
        {
            var start = dtpDebut.Value.Date;
            var end = dtpFin.Value.Date;
            var client = cbxClients.GetItemText(cbxClients.SelectedItem);
            var produit = cbxProduits.GetItemText(cbxProduits.SelectedItem);

            FiltrerTableau(end, start, client, produit);
        }

        private void BtnFiltrer_Click(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }

        private void CbxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }

        private void CbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }

        private void CbxProduits_TextChanged(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }

        private void CbxClients_TextChanged(object sender, EventArgs e)
        {
            AfficherResultatsFiltre();
        }
    }
}

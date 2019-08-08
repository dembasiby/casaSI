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

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_JournalApprovisionnements : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_JournalApprovisionnements()
        {
            InitializeComponent();
        }

        private void AppliquerFiltreAuTableau()
        {
            var matiere = cbxMatieresPremieres.GetItemText(cbxMatieresPremieres.SelectedItem);
            var fournisseur = cbxFournisseurs.GetItemText(cbxFournisseurs.SelectedItem);
            var localite = cbxLocaliteFournisseur.GetItemText(cbxLocaliteFournisseur.SelectedItem);

            ChargerJournalApprovisionnements(matiere, fournisseur, localite);
        }

        private void ChargerJournalApprovisionnements(string matiere = "", string fournisseur = "", string localite = "")
        {
            var journal = (from rmp in db.EveReceptionMatieresPremieres
                           join fmp in db.AgeFournisseursMatieresPremieres on rmp.CodeFournisseurMatierePremiere equals fmp.CodeFournisseurMatierePremiere
                           where rmp.DateReception >= dtpDebut.Value.Date
                           where rmp.DateReception <= dtpFin.Value.Date
                           where (matiere.Trim() == "" ? rmp.ResStockMatieresPremiere.NomMatiere != "" : rmp.ResStockMatieresPremiere.NomMatiere == matiere)
                           where (fournisseur.Trim() == "" ? fmp.Nom != "" : fmp.Nom == fournisseur)
                           where (localite.Trim() == "" ? fmp.Localite != "" : fmp.Localite == localite)


                           select new
                           {
                               Date = rmp.DateReception,
                               Description = rmp.ResStockMatieresPremiere.NomMatiere,
                               rmp.Quantite,
                               Fournisseur = fmp.Nom,
                               fmp.Localite
                           }).OrderBy(j => j.Date).ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(journal);
            dgvJournalApprovisionnements.DataSource = dt;

            dt.Rows.Add(DateTime.Today, "Total", Conversion.CalculerTotal(dgvJournalApprovisionnements, "Quantite"), "", "");
            dt.Columns[2].ColumnName = "Quantité (kg)";
            dt.Columns[4].ColumnName = "Localité";
            dgvJournalApprovisionnements.Columns["Quantité (kg)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void UC_JournalApprovisionnements_Load(object sender, EventArgs e)
        {
            ageFournisseursMatieresPremiereBindingSource.DataSource = db.AgeFournisseursMatieresPremieres.OrderBy(f => f.Nom).ToList();
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.OrderBy(mp => mp.NomMatiere).ToList();
            ageFournisseursMatieresPremiereBindingSource1.DataSource = db.AgeFournisseursMatieresPremieres.OrderBy(v => v.Localite).ToList().Distinct();

            var year  = DateTime.Today.Year;
            dtpDebut.Value = DateTime.Parse($"{year},1,1");

            ChargerJournalApprovisionnements();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        // Tri par nom de matière première
        private void CbxMatieresPremieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        private void CbxMatieresPremieres_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        // Tri par nom de fournisseur

        private void CbxFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        private void CbxFournisseurs_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        // Tri par localité

        private void CbxLocaliteFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        private void CbxLocaliteFournisseur_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltreAuTableau();
        }

        private void btnImprimerJournal_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Journal des approvisionnements", dgvJournalApprovisionnements);
        }
    }
}

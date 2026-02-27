using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_JournalApprovisionnements : UserControl
{
    private readonly ServiceContainer _services;

    public UC_JournalApprovisionnements(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_JournalApprovisionnements_Load(object sender, EventArgs e)
    {
        cbxFournisseurs.DisplayMember = "Nom";
        cbxFournisseurs.DataSource = _services.Db.AgeFournisseursMatieresPremieres
            .OrderBy(f => f.Nom).ToList();

        cbxMatieresPremieres.DisplayMember = "NomMatiere";
        cbxMatieresPremieres.DataSource = _services.Db.ResStockMatieresPremieres
            .OrderBy(mp => mp.NomMatiere).ToList();

        cbxLocaliteFournisseur.DisplayMember = "Localite";
        cbxLocaliteFournisseur.DataSource = _services.Db.AgeFournisseursMatieresPremieres
            .OrderBy(v => v.Localite).ToList();

        var year = DateTime.Today.Year;
        dtpDebut.Value = new DateTime(year, 1, 1);

        ChargerJournalApprovisionnements();
    }

    private void ChargerJournalApprovisionnements()
    {
        var matiere = cbxMatieresPremieres.Text;
        var fournisseur = cbxFournisseurs.Text;
        var localite = cbxLocaliteFournisseur.Text;

        var journal = (from rmp in _services.Db.EveReceptionMatieresPremieres
                       where rmp.DateReception >= dtpDebut.Value.Date
                       where rmp.DateReception <= dtpFin.Value.Date
                       where matiere.Trim() == "" || rmp.ResStockMatieresPremiere.NomMatiere == matiere
                       where fournisseur.Trim() == "" || rmp.AgeFournisseursMatieresPremiere.Nom == fournisseur
                       where localite.Trim() == "" || rmp.AgeFournisseursMatieresPremiere.Localite == localite
                       select new
                       {
                           Date = rmp.DateReception,
                           Description = rmp.ResStockMatieresPremiere.NomMatiere,
                           rmp.Quantite,
                           Fournisseur = rmp.AgeFournisseursMatieresPremiere.Nom,
                           Localité = rmp.AgeFournisseursMatieresPremiere.Localite,
                       }).OrderBy(j => j.Date).ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(journal);
        dgvJournalApprovisionnements.DataSource = dt;

        dt.Rows.Add(DateTime.Today, "Total", DataTableHelper.CalculerTotal(dgvJournalApprovisionnements, "Quantite"), "", "");
    }

    private void DtpDebut_ValueChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void DtpFin_ValueChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void CbxMatieresPremieres_SelectedIndexChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void CbxMatieresPremieres_TextChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void CbxFournisseurs_SelectedIndexChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void CbxFournisseurs_TextChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void CbxLocaliteFournisseur_SelectedIndexChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
    private void CbxLocaliteFournisseur_TextChanged(object sender, EventArgs e) => ChargerJournalApprovisionnements();
}

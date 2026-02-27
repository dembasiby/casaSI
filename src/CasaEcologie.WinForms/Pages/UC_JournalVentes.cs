using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_JournalVentes : UserControl
{
    private readonly ServiceContainer _services;

    public UC_JournalVentes(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_JournalVentes_Load(object sender, EventArgs e)
    {
        cbxClients.DisplayMember = "NomClient";
        cbxClients.DataSource = _services.Db.AgeClients.OrderBy(c => c.NomClient).ToList();

        cbxProduits.DisplayMember = "NomProduit";
        cbxProduits.DataSource = _services.Db.ResStockProduitsFinis.OrderBy(p => p.NomProduit).ToList();

        var year = DateTime.Today.Year;
        dtpDebut.Value = new DateTime(year, 1, 1);

        AfficherResultatsFiltre();
    }

    private void AfficherResultatsFiltre()
    {
        var debut = dtpDebut.Value.Date;
        var fin = dtpFin.Value.Date;
        var client = cbxClients.Text;
        var produit = cbxProduits.Text;

        var ventes = (from v in _services.Db.EveVentes
                      from vpf in v.EveVenteStockProduitsFinis
                      where v.DateVente >= debut && v.DateVente <= fin
                      where client == "" || v.AgeClient.NomClient == client
                      where produit == "" || vpf.ResStockProduitsFini.NomProduit == produit
                      select new
                      {
                          Date = v.DateVente,
                          Description = vpf.ResStockProduitsFini.NomProduit,
                          Quantité = vpf.QuantiteProduitFini,
                          Client = v.AgeClient.NomClient,
                          vpf.Montant,
                      }).OrderBy(d => d.Date).ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(ventes);
        dgvJournalVentes.DataSource = dt;

        dt.Rows.Add(DateTime.Now, "Total", 0, "", DataTableHelper.CalculerTotal(dgvJournalVentes, "Montant"));

        dgvJournalVentes.Columns["Montant"].DefaultCellStyle.Format = "N0";
        dgvJournalVentes.Columns["Montant"].HeaderText = "Montant (FCFA)";
        dgvJournalVentes.Columns["Quantité"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvJournalVentes.Columns["Montant"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    private void DtpDebut_ValueChanged(object sender, EventArgs e) => AfficherResultatsFiltre();
    private void DtpFin_ValueChanged(object sender, EventArgs e) => AfficherResultatsFiltre();
    private void CbxProduits_SelectedIndexChanged(object sender, EventArgs e) => AfficherResultatsFiltre();
    private void CbxClients_SelectedIndexChanged(object sender, EventArgs e) => AfficherResultatsFiltre();
    private void CbxProduits_TextChanged(object sender, EventArgs e) => AfficherResultatsFiltre();
    private void CbxClients_TextChanged(object sender, EventArgs e) => AfficherResultatsFiltre();
    private void BtnFiltrer_Click(object sender, EventArgs e) => AfficherResultatsFiltre();
}

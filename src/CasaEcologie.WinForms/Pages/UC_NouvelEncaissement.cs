using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_NouvelEncaissement : UserControl
{
    private readonly ServiceContainer _services;

    public UC_NouvelEncaissement(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_NouvelEncaissement_Load(object sender, EventArgs e)
    {
        LoadData();
        ChargerListeEmployes();
        MettreCreanceAJour();
    }

    private void LoadData()
    {
        var clientsAvecCreances = _services.Db.AgeClients
            .Where(c => c.SoldeInitialeCreance > 0
                || c.EveVentes.SelectMany(v => v.EveVenteStockProduitsFinis).Any())
            .OrderBy(c => c.NomClient)
            .ToList();

        cbxNomClient.DisplayMember = "NomClient";
        cbxNomClient.ValueMember = "CodeClient";
        cbxNomClient.DataSource = clientsAvecCreances;

        cbxCompte.DisplayMember = "NomCompte";
        cbxCompte.ValueMember = "CodeCompte";
        cbxCompte.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte).ToList();
    }

    private void MettreCreanceAJour()
    {
        if (cbxNomClient.SelectedValue is int codeClient)
        {
            var creance = _services.Tresorerie.CalculerSoldeCreanceClient(codeClient);
            txtCreancesClient.Text = creance.ToString("N0");
        }
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateEncaissement.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .Select(em => em.PrenomNom)
            .ToList();

        cbxTres.DataSource = employesPresents;
    }

    private void BtnEnregistrerEncaissement_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsMontant(txtMontantEncaisse.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        if (int.Parse(txtMontantEncaisse.Text) <= 0)
        {
            MessageBox.Show("Le montant doit être supérieur à zéro.");
            return;
        }

        var client = _services.Db.AgeClients.First(c => c.NomClient == cbxNomClient.Text);
        var tres = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxTres.Text);
        var cpte = _services.Db.ResComptesTresoreries.First(ct => ct.NomCompte == cbxCompte.Text);

        var enc = new EveEncaissement
        {
            CodeEmploye = tres.CodeEmploye,
            CodeCompte = cpte.CodeCompte,
        };

        _services.Db.EveEncaissements.Add(enc);
        _services.Db.SaveChanges();

        var encC = new EveEncaissementsCreance
        {
            CodeEncaissement = enc.CodeEncaissement,
            CodeClient = client.CodeClient,
            MontantEncaisse = int.Parse(txtMontantEncaisse.Text),
            DateEncaissement = dtpDateEncaissement.Value.Date,
        };

        _services.Db.EveEncaissementsCreances.Add(encC);
        _services.Db.SaveChanges();

        MessageBox.Show("L'encaissement a été enregistré avec succès.");
        txtMontantEncaisse.Clear();
        LoadData();
        MettreCreanceAJour();
    }

    private void CbxNomClient_SelectedValueChanged(object sender, EventArgs e)
    {
        MettreCreanceAJour();
    }

    private void DtpDateEncaissement_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

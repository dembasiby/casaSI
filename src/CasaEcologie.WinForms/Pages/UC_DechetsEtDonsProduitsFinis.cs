using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_DechetsEtDonsProduitsFinis : UserControl
{
    private readonly ServiceContainer _services;

    public UC_DechetsEtDonsProduitsFinis(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_DechetsEtDonsProduitsFinis_Load(object sender, EventArgs e)
    {
        cbxProduitsFinis.DisplayMember = "NomProduit";
        cbxProduitsFinis.ValueMember = "CodeProduit";
        cbxProduitsFinis.DataSource = _services.Db.ResStockProduitsFinis
            .OrderBy(pf => pf.NomProduit).ToList();

        ChargerListeEmployes();
        AfficherStockDisponible();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateSortieDechetsOuDons.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .ToList();

        cbxResponsableStock.DisplayMember = "PrenomNom";
        cbxResponsableStock.ValueMember = "CodeEmploye";
        cbxResponsableStock.DataSource = employesPresents;
    }

    private void AfficherStockDisponible()
    {
        try
        {
            var date = dtpDateSortieDechetsOuDons.Value.Date;
            var produitFini = cbxProduitsFinis.Text;
            txtStockDisponible.Text = _services.Stock
                .CalculerSoldeStockProduitFini(produitFini, date).ToString();
        }
        catch
        {
            txtStockDisponible.Text = "0";
        }
    }

    private void BtnEnregistrerSortie_Click(object sender, EventArgs e)
    {
        var validationQte = _services.Validation.VerifierChampsMontant(txtQuantite.Text);
        if (!validationQte.IsValid)
        {
            MessageBox.Show(validationQte.ErrorMessage);
            return;
        }

        var validationDesc = _services.Validation.VerifierChampsNonVide(txtDescription.Text, "Description");
        if (!validationDesc.IsValid)
        {
            MessageBox.Show(validationDesc.ErrorMessage);
            return;
        }

        try
        {
            int codeProduitFini = Convert.ToInt32(cbxProduitsFinis.SelectedValue);
            int codeResponsableStock = Convert.ToInt32(cbxResponsableStock.SelectedValue);

            var ddpf = new EveSortieDonsOuDechetsProduitsFini
            {
                DateSortie = dtpDateSortieDechetsOuDons.Value.Date,
                Description = txtDescription.Text,
                CodeProduitFini = codeProduitFini,
                QuantiteProduitFini = int.Parse(txtQuantite.Text),
                CodeResponsableSortie = codeResponsableStock,
            };

            _services.Db.EveSortieDonsOuDechetsProduitsFinis.Add(ddpf);
            _services.Db.SaveChanges();
            txtDescription.Clear();
            txtQuantite.Clear();
            AfficherStockDisponible();
            MessageBox.Show("L'enregistrement a été effectué avec succès.");
        }
        catch (Exception)
        {
            MessageBox.Show("Merci de vérifier vos données. L'enregistrement n'a pas été effectué.");
        }
    }

    private void CbxProduitsFinis_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherStockDisponible();
    }

    private void DtpDateSortieDechetsOuDons_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

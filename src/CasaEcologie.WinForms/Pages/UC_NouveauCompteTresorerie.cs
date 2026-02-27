using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_NouveauCompteTresorerie : UserControl
{
    private readonly ServiceContainer _services;

    public UC_NouveauCompteTresorerie(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
        txtSoldeCompte.Text = "00";
    }

    private void BtnAjouterNouveauCompte_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsMontant(txtSoldeCompte.Text);
        var nomValide = txtNomCompte.Text.Trim().Length > 0;

        if (validation.IsValid && nomValide)
        {
            var c = new ResComptesTresorerie
            {
                NomCompte = txtNomCompte.Text,
                SoldeCompte = decimal.Parse(txtSoldeCompte.Text)
            };

            _services.Db.ResComptesTresoreries.Add(c);
            _services.Db.SaveChanges();
            MessageBox.Show("Le nouveau compte a été ajouté avec succès.");
            txtNomCompte.Clear();
            txtSoldeCompte.Clear();
        }
        else
        {
            MessageBox.Show("Le nouveau compte n'a pas été créé. Vérifiez que tous les champs sont correctement remplis.");
        }
    }
}

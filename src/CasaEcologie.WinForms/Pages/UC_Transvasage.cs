using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_Transvasage : UserControl
{
    private readonly ServiceContainer _services;

    public UC_Transvasage(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_Transvasage_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        var emballages = _services.Db.ResStockMatieresPremieres
            .Where(mp => mp.TypesMatiere.NomType == "Emballage")
            .OrderBy(n => n.NomMatiere)
            .ToList();

        cbxEmballageInitial.DisplayMember = "NomMatiere";
        cbxEmballageInitial.ValueMember = "CodeMatierePremiere";
        cbxEmballageInitial.DataSource = emballages;

        cbxEmballageFinal.DisplayMember = "NomMatiere";
        cbxEmballageFinal.ValueMember = "CodeMatierePremiere";
        cbxEmballageFinal.DataSource = new List<ResStockMatieresPremiere>(emballages);

        var produits = _services.Db.ResStockProduitsFinis
            .OrderBy(p => p.NomProduit).ToList();

        cbxProduitInitial.DisplayMember = "NomProduit";
        cbxProduitInitial.ValueMember = "CodeProduit";
        cbxProduitInitial.DataSource = produits;

        cbxProduitFinal.DisplayMember = "NomProduit";
        cbxProduitFinal.ValueMember = "CodeProduit";
        cbxProduitFinal.DataSource = new List<ResStockProduitsFini>(produits);
    }

    private void BtnTransvaser_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsMontant(txtQuantiteATransvaser.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        if (cbxEmballageInitial.Text == cbxEmballageFinal.Text
            || cbxProduitInitial.Text == cbxProduitFinal.Text)
        {
            MessageBox.Show("Enregistrement annulé. Veuillez vérifier les données des champs.");
            return;
        }

        var transv = new EveTransvasement
        {
            DateOperation = dtpDateTransvasage.Value.Date,
            CodeEmballageInitial = Convert.ToInt32(cbxEmballageInitial.SelectedValue),
            CodeEmballageFinal = Convert.ToInt32(cbxEmballageFinal.SelectedValue),
            CodeProduitInitial = Convert.ToInt32(cbxProduitInitial.SelectedValue),
            CodeProduitFinal = Convert.ToInt32(cbxProduitFinal.SelectedValue),
            QuantiteATransvaser = Convert.ToInt32(txtQuantiteATransvaser.Text),
        };

        _services.Db.EveTransvasements.Add(transv);
        _services.Db.SaveChanges();
        MessageBox.Show("L'opération de transvasement a été enregistrée avec succès.");
        txtQuantiteATransvaser.Clear();
    }
}

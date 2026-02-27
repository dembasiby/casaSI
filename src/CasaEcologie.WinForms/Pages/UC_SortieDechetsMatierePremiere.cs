using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_SortieDechetsMatierePremiere : UserControl
{
    private readonly ServiceContainer _services;

    public UC_SortieDechetsMatierePremiere(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_SortieDechetsMatierePremiere_Load(object sender, EventArgs e)
    {
        cbxMatierePremiere.DisplayMember = "NomMatiere";
        cbxMatierePremiere.ValueMember = "CodeMatierePremiere";
        cbxMatierePremiere.DataSource = _services.Db.ResStockMatieresPremieres
            .OrderBy(n => n.NomMatiere).ToList();

        ChargerListeEmployes();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateSortieDechets.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .ToList();

        cbxResponsableStock.DisplayMember = "PrenomNom";
        cbxResponsableStock.ValueMember = "CodeEmploye";
        cbxResponsableStock.DataSource = employesPresents;

        cbxEmployeAyantRecuLesDechets.DisplayMember = "PrenomNom";
        cbxEmployeAyantRecuLesDechets.ValueMember = "CodeEmploye";
        cbxEmployeAyantRecuLesDechets.DataSource = new List<AgeEmploye>(employesPresents);
    }

    private void BtnEnregistrerSortie_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsQuantite(txtQuantite.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        try
        {
            int codeMatierePremiere = Convert.ToInt32(cbxMatierePremiere.SelectedValue);
            int codeResponsableStock = Convert.ToInt32(cbxResponsableStock.SelectedValue);
            int codeEmployeRecevant = Convert.ToInt32(cbxEmployeAyantRecuLesDechets.SelectedValue);

            var sdmp = new EveSortieDechetsMatieresPremiere
            {
                DateSortie = dtpDateSortieDechets.Value.Date,
                Description = txtDescription.Text,
                CodeMatierePremiere = codeMatierePremiere,
                QuantiteMatierePremiere = Convert.ToInt32(txtQuantite.Text),
                CodeEmployeResponsableStock = codeResponsableStock,
                CodeEmployeAutreResponsable = codeEmployeRecevant,
            };

            _services.Db.EveSortieDechetsMatieresPremieres.Add(sdmp);
            _services.Db.SaveChanges();
            MessageBox.Show("L'opération a été enregistrée avec succès.");
            txtQuantite.Clear();
            txtDescription.Clear();
        }
        catch (Exception)
        {
            MessageBox.Show("Echec de l'enregistrement. L'opération n'a pas pu être effectuée.");
        }
    }

    private void DtpDateSortieDechets_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_AutreEncaissementDeFonds : UserControl
{
    private readonly ServiceContainer _services;

    public UC_AutreEncaissementDeFonds(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_AutreEncaissementDeFonds_Load(object sender, EventArgs e)
    {
        cbxCompteCrediteur.DisplayMember = "NomCompte";
        cbxCompteCrediteur.ValueMember = "CodeCompte";
        cbxCompteCrediteur.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte).ToList();

        ChargerListeEmployes();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateEncaissement.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .Select(em => em.PrenomNom)
            .ToList();

        cbxResponsableTransaction.DataSource = employesPresents;
    }

    private void BtnEnregistrer_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsMontant(txtMontantEncaisse.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtDescription.Text) || txtDescription.Text.Trim().Length < 5)
        {
            MessageBox.Show("Le champ 'Description' doit être renseigné.");
            return;
        }

        var employe = _services.Db.AgeEmployes
            .First(emp => emp.PrenomNom == cbxResponsableTransaction.Text);
        var compte = _services.Db.ResComptesTresoreries
            .First(cpte => cpte.NomCompte == cbxCompteCrediteur.Text);

        var enc = new EveEncaissement
        {
            CodeEmploye = employe.CodeEmploye,
            CodeCompte = compte.CodeCompte,
        };

        _services.Db.EveEncaissements.Add(enc);
        _services.Db.SaveChanges();

        var autreEnc = new EveEncaissementsAutre
        {
            CodeEncaissement = enc.CodeEncaissement,
            DateEncaissement = dtpDateEncaissement.Value.Date,
            Description = txtDescription.Text,
            MontantEncaisse = int.Parse(txtMontantEncaisse.Text),
            FondsExternes = true,
        };

        _services.Db.EveEncaissementsAutres.Add(autreEnc);
        _services.Db.SaveChanges();

        MessageBox.Show("L'encaissement de fonds a été enregistré avec succès.");
        txtDescription.Clear();
        txtMontantEncaisse.Clear();
    }

    private void DtpDateEncaissement_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

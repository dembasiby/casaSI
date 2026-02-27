using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_MouvementCompteACompte : UserControl
{
    private readonly ServiceContainer _services;

    public UC_MouvementCompteACompte(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_MouvementCompteACompte_Load(object sender, EventArgs e)
    {
        var comptes = _services.Db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();

        cbxCompteDebit.DisplayMember = "NomCompte";
        cbxCompteDebit.ValueMember = "CodeCompte";
        cbxCompteDebit.DataSource = comptes;

        cbxCompteCredit.DisplayMember = "NomCompte";
        cbxCompteCredit.ValueMember = "CodeCompte";
        cbxCompteCredit.DataSource = new List<ResComptesTresorerie>(comptes);

        ChargerListeEmployes();
        AfficherSoldeTresorerie();
    }

    private void AfficherSoldeTresorerie()
    {
        if (cbxCompteDebit.SelectedItem is ResComptesTresorerie compte)
        {
            var solde = _services.Tresorerie.SoldeDisponibleDuCompteDeTresorerie(compte.NomCompte);
            txtSoldeCompte.Text = solde.ToString("N0");
        }
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateOperation.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .Select(em => em.PrenomNom)
            .ToList();

        cbxEmploye.DataSource = employesPresents;
    }

    private void BtnEnregistrerTransfert_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsMontant(txtMontant.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        int montant = int.Parse(txtMontant.Text);
        if (montant <= 0)
        {
            MessageBox.Show("Le montant doit être supérieur à zéro.");
            return;
        }

        var codeCpteDebiteur = Convert.ToInt32(cbxCompteDebit.SelectedValue);
        var codeCpteCrediteur = Convert.ToInt32(cbxCompteCredit.SelectedValue);

        if (codeCpteDebiteur == codeCpteCrediteur)
        {
            MessageBox.Show("Le transfert ne peut s'effectuer qu'avec deux comptes différents.");
            return;
        }

        if (cbxCompteDebit.SelectedItem is not ResComptesTresorerie compteDebit)
            return;

        if (!_services.Tresorerie.IlYaAssezDeFondsDansLeCompte(compteDebit.NomCompte, montant))
        {
            MessageBox.Show("Le solde du compte est insuffisant.");
            return;
        }

        if (string.IsNullOrWhiteSpace(txtDescription.Text))
        {
            MessageBox.Show("Veuillez ajouter une description à ce mouvement de compte à compte.");
            return;
        }

        var employe = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxEmploye.Text);

        var decaissement = new EveDecaissement
        {
            DateDecaissement = dtpDateOperation.Value.Date,
            Description = txtDescription.Text,
            Montant = montant,
            DecaissementInterne = true,
            CodeEmploye = employe.CodeEmploye,
            CodeCompte = codeCpteDebiteur,
        };

        _services.Db.EveDecaissements.Add(decaissement);
        _services.Db.SaveChanges();

        var encaissement = new EveEncaissement
        {
            CodeCompte = codeCpteCrediteur,
            CodeEmploye = employe.CodeEmploye,
        };

        _services.Db.EveEncaissements.Add(encaissement);
        _services.Db.SaveChanges();

        var autreEnc = new EveEncaissementsAutre
        {
            CodeEncaissement = encaissement.CodeEncaissement,
            DateEncaissement = dtpDateOperation.Value.Date,
            Description = txtDescription.Text,
            MontantEncaisse = montant,
        };

        _services.Db.EveEncaissementsAutres.Add(autreEnc);
        _services.Db.SaveChanges();

        MessageBox.Show("Le transfert de fonds a été enregistré avec succès.");
        txtDescription.Clear();
        txtMontant.Clear();
        AfficherSoldeTresorerie();
    }

    private void CbxCompteDebit_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeTresorerie();
    }

    private void DtpDateOperation_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

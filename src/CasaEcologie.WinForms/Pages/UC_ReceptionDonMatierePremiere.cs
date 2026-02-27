using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_ReceptionDonMatierePremiere : UserControl
{
    private readonly ServiceContainer _services;

    public UC_ReceptionDonMatierePremiere(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_ReceptionDonMatierePremiere_Load(object sender, EventArgs e)
    {
        ChargerListeEmployes();

        cbxFournisseur.DisplayMember = "Nom";
        cbxFournisseur.ValueMember = "CodeFournisseurMatierePremiere";
        cbxFournisseur.DataSource = _services.Db.AgeFournisseursMatieresPremieres
            .OrderBy(f => f.Nom).ToList();

        cbxMatierePremiere.DisplayMember = "NomMatiere";
        cbxMatierePremiere.ValueMember = "CodeMatierePremiere";
        cbxMatierePremiere.DataSource = _services.Db.ResStockMatieresPremieres
            .OrderBy(m => m.NomMatiere).ToList();

        cbxCompte.DisplayMember = "NomCompte";
        cbxCompte.ValueMember = "CodeCompte";
        cbxCompte.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte).ToList();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateReception.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .ToList();

        cbxEmploye.DisplayMember = "PrenomNom";
        cbxEmploye.ValueMember = "CodeEmploye";
        cbxEmploye.DataSource = employesPresents;
    }

    private void BtnEnregistrer_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsQuantite(txtQuantite.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        int quantite = int.Parse(txtQuantite.Text);
        if (quantite <= 0)
        {
            MessageBox.Show("La quantité doit être supérieure à zéro.");
            return;
        }

        var codeEmploye = Convert.ToInt32(cbxEmploye.SelectedValue);
        var codeFournisseur = Convert.ToInt32(cbxFournisseur.SelectedValue);
        var codeMatierePremiere = Convert.ToInt32(cbxMatierePremiere.SelectedValue);

        var don = new EveReceptionDonsMatieresPremiere
        {
            DateReception = dtpDateReception.Value.Date,
            CodeMatierePremiere = codeMatierePremiere,
            CodeEmploye = codeEmploye,
            CodeFournisseur = codeFournisseur,
            Quantite = quantite,
        };

        _services.Db.EveReceptionDonsMatieresPremieres.Add(don);
        _services.Db.SaveChanges();

        PayerTransport(don);

        MessageBox.Show("Le nouveau don de matière première a été enregistré avec succès.");
        txtQuantite.Text = "0";
        txtTransport.Text = "0";
    }

    private void PayerTransport(EveReceptionDonsMatieresPremiere don)
    {
        if (int.TryParse(txtTransport.Text, out int transport) && transport > 0)
        {
            var codeCompte = Convert.ToInt32(cbxCompte.SelectedValue);

            var decaiss = new EveDecaissement
            {
                DateDecaissement = don.DateReception,
                Montant = transport,
                Description = "Transport don matière première",
                CodeCompte = codeCompte,
            };

            _services.Db.EveDecaissements.Add(decaiss);
            _services.Db.SaveChanges();
        }
    }

    private void DtpDateReception_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

using System.ComponentModel;
using System.Data;
using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_Personnel : UserControl
{
    private readonly ServiceContainer _services;

    public UC_Personnel(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_Personnel_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        var listePersonnel = _services.Db.AgeEmployes
            .Where(p => p.Actif)
            .Select(p => new { Nom = p.PrenomNom, p.Poste })
            .OrderBy(e => e.Nom)
            .ToList();

        dgvListePersonnel.DataSource = listePersonnel;

        var employesActifsNonStagiaires = _services.Db.AgeEmployes
            .Where(em => em.Actif)
            .Where(em => !em.Poste.StartsWith("Stagiaire"))
            .OrderBy(c => c.PrenomNom)
            .ToList();

        cbxTempsEtRemun.DisplayMember = "PrenomNom";
        cbxTempsEtRemun.ValueMember = "CodeEmploye";
        cbxTempsEtRemun.DataSource = new BindingList<AgeEmploye>(employesActifsNonStagiaires);

        cbxTimeSheetNomEmploye.DisplayMember = "PrenomNom";
        cbxTimeSheetNomEmploye.ValueMember = "CodeEmploye";
        cbxTimeSheetNomEmploye.DataSource = new BindingList<AgeEmploye>(
            _services.Db.AgeEmployes
                .Where(em => em.Actif)
                .Where(em => !em.Poste.StartsWith("Stagiaire"))
                .OrderBy(c => c.PrenomNom)
                .ToList());

        var comptesDataSource = _services.Db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();

        cbxComptePaiement.DisplayMember = "NomCompte";
        cbxComptePaiement.ValueMember = "CodeCompte";
        cbxComptePaiement.DataSource = new BindingList<ResComptesTresorerie>(comptesDataSource);

        var employesPresents = ListeEmployesPresents(dtpDatePaiement.Value.Date);

        cbxTresoriere.DisplayMember = "PrenomNom";
        cbxTresoriere.ValueMember = "CodeEmploye";
        cbxTresoriere.DataSource = new BindingList<AgeEmploye>(
            employesPresents
                .Where(em => !em.Poste.StartsWith("Stagiaire"))
                .OrderBy(c => c.PrenomNom)
                .ToList());

        cbxStagiaires.DisplayMember = "PrenomNom";
        cbxStagiaires.ValueMember = "CodeEmploye";
        cbxStagiaires.DataSource = new BindingList<AgeEmploye>(
            _services.Db.AgeEmployes
                .Where(em => em.Actif)
                .Where(em => em.Poste.StartsWith("Stagiaire"))
                .OrderBy(c => c.PrenomNom)
                .ToList());

        cbxComptePaiementStagiaire.DisplayMember = "NomCompte";
        cbxComptePaiementStagiaire.ValueMember = "CodeCompte";
        cbxComptePaiementStagiaire.DataSource = new BindingList<ResComptesTresorerie>(
            _services.Db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList());

        cbxPaiementFaitPar.DisplayMember = "PrenomNom";
        cbxPaiementFaitPar.ValueMember = "CodeEmploye";
        cbxPaiementFaitPar.DataSource = new BindingList<AgeEmploye>(
            employesPresents
                .Where(em => !em.Poste.StartsWith("Stagiaire"))
                .OrderBy(c => c.PrenomNom)
                .ToList());

        AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
        AfficherSoldeTresorerie();
    }

    private List<AgeEmploye> ListeEmployesPresents(DateTime date)
    {
        return _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == date)
            .Select(pe => pe.AgeEmploye)
            .ToList();
    }

    private void AfficherSoldeTresorerie()
    {
        if (cbxComptePaiement.SelectedItem is ResComptesTresorerie compte)
        {
            var solde = _services.Tresorerie.SoldeDisponibleDuCompteDeTresorerie(compte.NomCompte);
            txtSoldeCompte.Text = solde.ToString("N0");
        }
    }

    private void AfficherPresenceEtRemunerationEmploye(DateTime debut, DateTime fin)
    {
        if (cbxTempsEtRemun.SelectedItem is not AgeEmploye selectedEmploye)
            return;

        var employe = selectedEmploye.PrenomNom;
        var codeEmploye = selectedEmploye.CodeEmploye;

        var liste = _services.Db.EvePresenceEmployes
            .Where(pe => pe.AgeEmploye.PrenomNom == employe)
            .Where(pe => pe.CodeEmploye == codeEmploye)
            .Where(pe => pe.Date >= debut.Date)
            .Where(pe => pe.Date <= fin.Date)
            .Select(pe => new
            {
                pe.Date,
                Description = "Present",
                Remuneration = pe.RemunerationJournaliere
            })
            .OrderBy(d => d.Date)
            .ToList();

        DataTable dt = ConvertirEnTableDeDonnees(liste);
        dgvTempsEtRemun.DataSource = dt;

        double total = 0;
        for (int i = 0; i < dgvTempsEtRemun.Rows.Count; i++)
        {
            total += Convert.ToDouble(dgvTempsEtRemun.Rows[i].Cells["Remuneration"].Value ?? 0);
        }

        dt.Rows.Add(DateTime.Now, "Total", total);
        txtRemunerationPeriod.Text = total.ToString();
    }

    private static DataTable ConvertirEnTableDeDonnees<T>(IList<T> data)
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        DataTable table = new DataTable();

        foreach (PropertyDescriptor prop in properties)
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            table.Rows.Add(row);
        }

        return table;
    }

    private void BtnNouvelEmploye_Click(object sender, EventArgs e)
    {
        bool employeEnregistre = _services.Db.AgeEmployes
            .Any(em => em.PrenomNom.ToLower() == txtPrenomNom.Text.ToLower());

        if (txtPosteEmploye.Text.Trim().Length > 0 && txtPrenomNom.Text.Trim().Length > 0)
        {
            if (!employeEnregistre)
            {
                var emp = new AgeEmploye
                {
                    PrenomNom = txtPrenomNom.Text,
                    Poste = txtPosteEmploye.Text,
                    Actif = true
                };

                _services.Db.AgeEmployes.Add(emp);
                _services.Db.SaveChanges();
                MessageBox.Show("Le nouvel employé a été ajouté avec succès à la base de données.");
                LoadData();
                txtPrenomNom.Clear();
                txtPosteEmploye.Clear();
            }
            else
            {
                MessageBox.Show("Cet employé a déjà été enregistré.");
            }
        }
        else
        {
            MessageBox.Show("Les champs 'Prenom et Nom' et 'Poste' ne peuvent pas être vides.");
        }
    }

    private void BtnPresenceEmploye_Click(object sender, EventArgs e)
    {
        if (cbxTimeSheetNomEmploye.SelectedItem is not AgeEmploye selectedEmploye)
            return;

        var employe = selectedEmploye.PrenomNom;
        var codeEmploye = selectedEmploye.CodeEmploye;

        var validation = _services.Validation.VerifierChampsMontant(txtRemunerationJournaliere.Text);
        if (validation.IsValid)
        {
            if (EmployeNonEncoreEnregistrePourCeJour(codeEmploye))
            {
                var pe = new EvePresenceEmploye
                {
                    CodeEmploye = codeEmploye,
                    CodeUtilisationDesRessources = 0,
                    Date = dtpDate.Value.Date,
                    RemunerationJournaliere = Convert.ToInt32(txtRemunerationJournaliere.Text)
                };

                _services.Db.EvePresenceEmployes.Add(pe);
                _services.Db.SaveChanges();
                MessageBox.Show("La présence de l'employé a été enregistrée avec succès.");
                AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
            }
            else
            {
                MessageBox.Show($"{employe} a déjà été enregistré pour le {dtpDate.Value.ToShortDateString()}");
            }
        }
    }

    private bool EmployeNonEncoreEnregistrePourCeJour(int codeEmploye)
    {
        return !_services.Db.EvePresenceEmployes
            .Any(pe => pe.CodeEmploye == codeEmploye && pe.Date == dtpDate.Value.Date);
    }

    private void CbxTempsEtRemun_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
    }

    private void DtpDebut_ValueChanged(object sender, EventArgs e)
    {
        AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
    }

    private void DtpFin_ValueChanged(object sender, EventArgs e)
    {
        AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
    }

    private void BtnPayerEmploye_Click(object sender, EventArgs e)
    {
        if (cbxTempsEtRemun.SelectedItem is not AgeEmploye selectedEmploye)
            return;

        PayerPersonnel(selectedEmploye.PrenomNom, selectedEmploye.CodeEmploye,
            dtpDebut.Value, dtpFin.Value, dtpDatePaiement.Value,
            cbxComptePaiement, cbxTresoriere, txtRemunerationPeriod);
    }

    private bool RemunerationPasEncorePayePourLaPeriode(int codeEmploye, DateTime debut, DateTime fin)
    {
        var remunere = _services.Db.EvePaiementEmployes
            .Where(ep => ep.CodeEmployePaye == codeEmploye)
            .Where(ep => ep.DeCetteDate == debut)
            .Where(ep => ep.ACetteDate == fin)
            .Select(ep => ep.CodePaiementEmploye)
            .FirstOrDefault();

        return remunere == 0;
    }

    private void BtnPayerIndemnite_Click(object sender, EventArgs e)
    {
        if (cbxStagiaires.SelectedItem is not AgeEmploye selectedStagiaire)
            return;

        PayerPersonnel(selectedStagiaire.PrenomNom, selectedStagiaire.CodeEmploye,
            dtpDeStagiaire.Value, dtpAStagiaire.Value, dtpDatePaiementIndemStagiaires.Value,
            cbxComptePaiementStagiaire, cbxPaiementFaitPar, txtMontantIndemnite);
    }

    private void PayerPersonnel(string employe, int codeEmploye, DateTime debut, DateTime fin,
        DateTime datePaiement, ComboBox cptePaiement, ComboBox tresoriere, TextBox montant)
    {
        if (cptePaiement.SelectedItem is not ResComptesTresorerie comptePaiement)
            return;

        string nomCompte = comptePaiement.NomCompte;
        int codeCompte = comptePaiement.CodeCompte;

        var validation = _services.Validation.VerifierChampsMontant(montant.Text);
        if (validation.IsValid)
        {
            if (RemunerationPasEncorePayePourLaPeriode(codeEmploye, debut.Date, fin.Date))
            {
                decimal montantDecimal = decimal.Parse(montant.Text);
                if (_services.Tresorerie.IlYaAssezDeFondsDansLeCompte(nomCompte, montantDecimal))
                {
                    var paiement = new EvePaiementEmploye
                    {
                        CodeEmployePaye = codeEmploye,
                        DeCetteDate = debut.Date,
                        ACetteDate = fin.Date
                    };

                    _services.Db.EvePaiementEmployes.Add(paiement);
                    _services.Db.SaveChanges();

                    int codeTresoriere = tresoriere.SelectedValue is int v ? v : Convert.ToInt32(tresoriere.SelectedValue);

                    var decaiss = new EveDecaissement
                    {
                        DateDecaissement = datePaiement.Date,
                        CodePaiementEmploye = paiement.CodePaiementEmploye,
                        CodeCompte = codeCompte,
                        Description = "Paiment rémunération de " + employe + " pour la période du " +
                                      debut.ToShortDateString() + " au " + fin.ToShortDateString(),
                        CodeEmploye = codeTresoriere,
                        Montant = (int)montantDecimal
                    };

                    _services.Db.EveDecaissements.Add(decaiss);
                    _services.Db.SaveChanges();

                    MessageBox.Show($"Le paiement de {employe} a été enregistré pour la période du {debut.ToShortDateString()} au {fin.ToShortDateString()}.");
                }
                else
                {
                    MessageBox.Show("Le solde du compte est insuffisant pour effectuer ce paiement.");
                }
            }
            else
            {
                MessageBox.Show($"{employe} a déjà été payé pour la période selectionnée.");
            }
        }
        else
        {
            MessageBox.Show("Le montant entré n'est pas valide.");
        }
    }

    private void CbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeTresorerie();
    }

    private void DtpDatePaiement_ValueChanged(object sender, EventArgs e)
    {
        var employesPresents = ListeEmployesPresents(dtpDatePaiement.Value.Date);

        cbxTresoriere.DataSource = new BindingList<AgeEmploye>(
            employesPresents
                .Where(em => !em.Poste.StartsWith("Stagiaire"))
                .OrderBy(c => c.PrenomNom)
                .ToList());
    }
}

using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_JournalTresorerie : UserControl
{
    private readonly ServiceContainer _services;

    public UC_JournalTresorerie(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_JournalTresorerie_Load(object sender, EventArgs e)
    {
        lstComptes.DisplayMember = "NomCompte";
        lstComptes.ValueMember = "CodeCompte";
        lstComptes.DataSource = _services.Db.ResComptesTresoreries.ToList();
    }

    private void LstComptes_SelectedValueChanged(object sender, EventArgs e)
    {
        var nomCompte = lstComptes.Text;
        if (!string.IsNullOrEmpty(nomCompte))
        {
            AfficherJournalCorrespondant(nomCompte);
        }
    }

    private void AfficherJournalCorrespondant(string nomCompte)
    {
        var encVentes = (from c in _services.Db.EveEncaissements
                         from env in c.EveEncaissementsVentes
                         where c.ResComptesTresorerie.NomCompte == nomCompte
                         select new
                         {
                             Date = env.DateEncaissement,
                             Description = "Encaissement vente",
                             Entree = env.MontantEncaisse,
                             Sortie = 0m,
                             Solde = 0m,
                         });

        var encAutres = (from c in _services.Db.EveEncaissements
                         from aut in c.EveEncaissementsAutres
                         where c.ResComptesTresorerie.NomCompte == nomCompte
                         select new
                         {
                             Date = aut.DateEncaissement,
                             aut.Description,
                             Entree = aut.MontantEncaisse,
                             Sortie = 0m,
                             Solde = 0m,
                         });

        var encCreances = (from c in _services.Db.EveEncaissements
                           from cr in c.EveEncaissementsCreances
                           where c.ResComptesTresorerie.NomCompte == nomCompte
                           select new
                           {
                               Date = cr.DateEncaissement,
                               Description = "Encaissement créance",
                               Entree = cr.MontantEncaisse,
                               Sortie = 0m,
                               Solde = 0m,
                           });

        var decaissements = (from d in _services.Db.EveDecaissements
                             where d.ResComptesTresorerie.NomCompte == nomCompte
                             select new
                             {
                                 Date = d.DateDecaissement,
                                 Description = d.Description ?? "",
                                 Entree = 0m,
                                 Sortie = d.Montant,
                                 Solde = 0m,
                             });

        var combinedQuery = encVentes.Concat(encCreances).Concat(encAutres).Concat(decaissements)
            .OrderByDescending(o => o.Date)
            .ToList();

        var soldeInitial = _services.Db.ResComptesTresoreries
            .Where(c => c.NomCompte == nomCompte)
            .Select(c => c.SoldeCompte)
            .FirstOrDefault();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(combinedQuery);

        var dr = dt.NewRow();
        dt.Rows.InsertAt(dr, dt.Rows.Count);
        dr["Entree"] = 0;
        dr["Sortie"] = 0;
        dr["Description"] = "Solde initial";

        dgvJournalTresorerieDetails.DataSource = dt;

        // Calculer le solde progressif
        for (int i = dgvJournalTresorerieDetails.Rows.Count - 1; i >= 0; i--)
        {
            if (i < dgvJournalTresorerieDetails.Rows.Count - 1)
            {
                dgvJournalTresorerieDetails.Rows[i].Cells[4].Value =
                    Convert.ToDecimal(dgvJournalTresorerieDetails.Rows[i + 1].Cells[4].Value)
                    + Convert.ToDecimal(dgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToDecimal(dgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
            }
            else
            {
                dgvJournalTresorerieDetails.Rows[i].Cells[4].Value =
                    soldeInitial
                    + Convert.ToDecimal(dgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToDecimal(dgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
            }
        }

        dgvJournalTresorerieDetails.Columns["Entree"].DefaultCellStyle.Format = "N0";
        dgvJournalTresorerieDetails.Columns["Sortie"].DefaultCellStyle.Format = "N0";
        dgvJournalTresorerieDetails.Columns["Solde"].DefaultCellStyle.Format = "N0";
        dgvJournalTresorerieDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        dgvJournalTresorerieDetails.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        // Afficher les totaux globaux
        AfficherTotauxGlobaux();
    }

    private void AfficherTotauxGlobaux()
    {
        var soldeInitiaux = _services.Db.ResComptesTresoreries
            .Select(c => (decimal?)c.SoldeCompte).Sum() ?? 0m;

        var totalEncVentes = (from c in _services.Db.EveEncaissements
                              from env in c.EveEncaissementsVentes
                              select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

        var totalEncCreances = (from c in _services.Db.EveEncaissements
                                from cr in c.EveEncaissementsCreances
                                select (decimal?)cr.MontantEncaisse).Sum() ?? 0m;

        var totalAutresEnc = (from enc in _services.Db.EveEncaissements
                              from aut in enc.EveEncaissementsAutres
                              where aut.FondsExternes == true
                              select (decimal?)aut.MontantEncaisse).Sum() ?? 0m;

        var totalDecaissements = (from d in _services.Db.EveDecaissements
                                  where d.DecaissementInterne == false
                                  select (decimal?)d.Montant).Sum() ?? 0m;

        txtSoldesInitiaux.Text = soldeInitiaux.ToString("N0");
        txtTotalEncaissements.Text = (totalEncVentes + totalEncCreances + totalAutresEnc).ToString("N0");
        txtTotalDecaissements.Text = totalDecaissements.ToString("N0");
        txtSolde.Text = _services.Tresorerie.CalculerSoldeTresorerie(DateTime.Today);
    }
}

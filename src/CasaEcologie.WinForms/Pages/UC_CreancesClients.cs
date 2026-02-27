using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_CreancesClients : UserControl
{
    private readonly ServiceContainer _services;

    public UC_CreancesClients(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_CreancesClients_Load(object sender, EventArgs e)
    {
        var clientsAvecCreances = _services.Db.AgeClients
            .Where(c => c.SoldeInitialeCreance > 0
                || c.EveVentes.Any()
                || c.EveEncaissementsVentes.Any()
                || c.EveEncaissementsCreances.Any())
            .OrderBy(c => c.NomClient)
            .ToList()
            .Where(c => _services.Tresorerie.CalculerSoldeCreanceClient(c.CodeClient) > 0)
            .ToList();

        lbxListeClients.DisplayMember = "NomClient";
        lbxListeClients.ValueMember = "CodeClient";
        lbxListeClients.DataSource = clientsAvecCreances;

        txtTotalCreances.Text = _services.Tresorerie.CalculerTotalCreancesClients().ToString("N0");
    }

    private void LbxListeClients_SelectedValueChanged(object sender, EventArgs e)
    {
        if (lbxListeClients.Items.Count > 0 && lbxListeClients.SelectedValue is int codeClient)
        {
            MontrerDetailsCreances(codeClient);
            lblNomClient.Text = _services.Db.AgeClients
                .Where(c => c.CodeClient == codeClient)
                .Select(c => c.NomClient)
                .FirstOrDefault() ?? "";
        }
    }

    private void MontrerDetailsCreances(int codeClient)
    {
        var ventesClients = (from c in _services.Db.AgeClients
                             from v in c.EveVentes
                             from vpf in v.EveVenteStockProduitsFinis
                             where c.CodeClient == codeClient
                             select new
                             {
                                 Date = v.DateVente,
                                 Description = vpf.ResStockProduitsFini.NomProduit,
                                 vpf.Montant,
                                 Encaissement = 0m,
                                 Solde = 0m
                             });

        var totalPaiementClient = (from c in _services.Db.AgeClients
                                   from ev in c.EveEncaissementsVentes
                                   where c.CodeClient == codeClient
                                   select new
                                   {
                                       Date = ev.DateEncaissement,
                                       Description = "Encaissement vente",
                                       Montant = 0m,
                                       Encaissement = ev.MontantEncaisse,
                                       Solde = 0m
                                   });

        var encaissementCreances = (from c in _services.Db.AgeClients
                                    from ecc in c.EveEncaissementsCreances
                                    where c.CodeClient == codeClient
                                    select new
                                    {
                                        Date = ecc.DateEncaissement,
                                        Description = "Encaissement créance",
                                        Montant = 0m,
                                        Encaissement = ecc.MontantEncaisse,
                                        Solde = 0m
                                    });

        var combinedQuery = ventesClients
            .Concat(totalPaiementClient)
            .Concat(encaissementCreances)
            .OrderByDescending(c => c.Date)
            .ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(combinedQuery);

        var dr = dt.NewRow();
        dt.Rows.InsertAt(dr, 0);
        dr["Montant"] = 0;
        dr["Encaissement"] = 0;
        dr["Description"] = "Montant créance initiale";

        dgvDetailsClient.DataSource = dt;

        FormatColumn("Montant", "N0");
        FormatColumn("Encaissement", "N0");
        FormatColumn("Solde", "N0");
        dgvDetailsClient.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        if (dgvDetailsClient.Columns.Contains("Date"))
            dgvDetailsClient.Columns["Date"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        if (dgvDetailsClient.Columns.Contains("Description"))
        {
            dgvDetailsClient.Columns["Description"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetailsClient.Columns["Description"]!.FillWeight = 250;
        }

        var creanceInitialClient = _services.Db.AgeClients
            .Where(c => c.CodeClient == codeClient)
            .Select(c => c.SoldeInitialeCreance)
            .FirstOrDefault();

        for (int i = 0; i < dgvDetailsClient.Rows.Count; i++)
        {
            if (i > 0)
            {
                dgvDetailsClient.Rows[i].Cells[4].Value =
                    Convert.ToDecimal(dgvDetailsClient.Rows[i - 1].Cells[4].Value)
                    + Convert.ToDecimal(dgvDetailsClient.Rows[i].Cells[2].Value)
                    - Convert.ToDecimal(dgvDetailsClient.Rows[i].Cells[3].Value);
            }
            else
            {
                dgvDetailsClient.Rows[i].Cells[4].Value =
                    creanceInitialClient
                    + Convert.ToDecimal(dgvDetailsClient.Rows[i].Cells[2].Value)
                    - Convert.ToDecimal(dgvDetailsClient.Rows[i].Cells[3].Value);
            }
        }
    }

    private void FormatColumn(string column, string format)
    {
        if (dgvDetailsClient.Columns.Contains(column))
            dgvDetailsClient.Columns[column]!.DefaultCellStyle.Format = format;
    }
}

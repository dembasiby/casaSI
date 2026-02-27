using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_DettesFournisseurs : UserControl
{
    private readonly ServiceContainer _services;

    public UC_DettesFournisseurs(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_DettesFournisseurs_Load(object sender, EventArgs e)
    {
        rbtFMatieresPremieres.Checked = true;
        ListerFournisseurAvecDettes();
        txtTotalDettesFournisseurs.Text = _services.Tresorerie.CalculerTotalDettesFournisseurs().ToString("N0");
    }

    private void RbtFMatieresPremieres_CheckedChanged(object sender, EventArgs e)
    {
        ClearTable();
        ListerFournisseurAvecDettes();
    }

    private void RbtFEquipementsInfra_CheckedChanged(object sender, EventArgs e)
    {
        ClearTable();
        ListerFournisseurAvecDettes();
    }

    private void RbtAutresFournisseurs_CheckedChanged(object sender, EventArgs e)
    {
        ClearTable();
        ListerFournisseurAvecDettes();
    }

    private void ListerFournisseurAvecDettes()
    {
        if (rbtFMatieresPremieres.Checked)
        {
            var liste = _services.Db.AgeFournisseursMatieresPremieres.ToList()
                .Where(f => _services.Tresorerie.CalculerTotalDettesFournisseurMatierePremiere(f.CodeFournisseurMatierePremiere) > 0)
                .ToList();
            lbxListeFournisseursDettes.DataSource = liste;
            lbxListeFournisseursDettes.DisplayMember = "Nom";
            lbxListeFournisseursDettes.ValueMember = "CodeFournisseurMatierePremiere";
        }
        else if (rbtFEquipementsInfra.Checked)
        {
            var liste = _services.Db.AgeAutreFournisseurs.ToList()
                .Where(f => _services.Tresorerie.CalculerTotalDettesFournisseurEquipementsInfrastructures(f.CodeAutreFournisseur) > 0)
                .ToList();
            lbxListeFournisseursDettes.DataSource = liste;
            lbxListeFournisseursDettes.DisplayMember = "NomAutreFournisseur";
            lbxListeFournisseursDettes.ValueMember = "CodeAutreFournisseur";
        }
        else if (rbtAutresFournisseurs.Checked)
        {
            var liste = _services.Db.AgeFournisseursServicesFournitures.ToList()
                .Where(f => _services.Tresorerie.CalculerTotalDettesFournisseurServicesFournitures(f.CodeFournisseurServiceFourniture) > 0)
                .ToList();
            lbxListeFournisseursDettes.DataSource = liste;
            lbxListeFournisseursDettes.DisplayMember = "NomFournisseurServiceFourniture";
            lbxListeFournisseursDettes.ValueMember = "CodeFournisseurServiceFourniture";
        }
    }

    private void LbxListeFournisseursDettes_SelectedValueChanged(object sender, EventArgs e)
    {
        if (lbxListeFournisseursDettes.Items.Count > 0)
        {
            var codeFournisseur = ExtraireCodeFournisseur();
            if (codeFournisseur > 0)
                MontrerDetailsDettesFournisseur(codeFournisseur);
        }
    }

    private int ExtraireCodeFournisseur()
    {
        var fournisseur = lbxListeFournisseursDettes.GetItemText(lbxListeFournisseursDettes.SelectedItem);

        if (rbtFMatieresPremieres.Checked)
        {
            return _services.Db.AgeFournisseursMatieresPremieres
                .Where(f => f.Nom == fournisseur)
                .Select(f => f.CodeFournisseurMatierePremiere)
                .FirstOrDefault();
        }
        else if (rbtFEquipementsInfra.Checked)
        {
            return _services.Db.AgeAutreFournisseurs
                .Where(f => f.NomAutreFournisseur == fournisseur)
                .Select(f => f.CodeAutreFournisseur)
                .FirstOrDefault();
        }
        else
        {
            return _services.Db.AgeFournisseursServicesFournitures
                .Where(f => f.NomFournisseurServiceFourniture == fournisseur)
                .Select(f => f.CodeFournisseurServiceFourniture)
                .FirstOrDefault();
        }
    }

    private void MontrerDetailsDettesFournisseur(int codeFournisseur)
    {
        var achatMatierePrem = (from fmp in _services.Db.AgeFournisseursMatieresPremieres
                                from rmp in fmp.EveReceptionMatieresPremieres
                                where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                                select new
                                {
                                    Date = rmp.DateReception,
                                    Description = "Achat de " + rmp.ResStockMatieresPremiere.NomMatiere,
                                    MontantAchat = rmp.Montant,
                                    MontantPaye = 0m,
                                    Solde = 0m
                                });

        var achatEquipementInfr = (from af in _services.Db.AgeAutreFournisseurs
                                   from rei in af.EveReceptionEquipementsInfrastructures
                                   where af.CodeAutreFournisseur == codeFournisseur
                                   select new
                                   {
                                       Date = rei.ResEquipementsInfrastructure.DateAcquisition,
                                       Description = "Achat de " + rei.ResEquipementsInfrastructure.Nom,
                                       MontantAchat = rei.ResEquipementsInfrastructure.Montant,
                                       MontantPaye = 0m,
                                       Solde = 0m
                                   });

        var achatServFournitures = (from fs in _services.Db.AgeFournisseursServicesFournitures
                                    from asf in fs.EveAcquisitionServicesFournitures
                                    where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                    select new
                                    {
                                        Date = asf.Date,
                                        Description = asf.ResServicesFourniture.NomServiceFourniture,
                                        MontantAchat = asf.Montant,
                                        MontantPaye = 0m,
                                        Solde = 0m
                                    });

        var decaissementMP = (from fmp in _services.Db.AgeFournisseursMatieresPremieres
                              from d in fmp.EveDecaissements
                              where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                              select new
                              {
                                  Date = d.DateDecaissement,
                                  d.Description,
                                  MontantAchat = 0m,
                                  MontantPaye = d.Montant,
                                  Solde = 0m
                              });

        var decaisementEquip = (from af in _services.Db.AgeAutreFournisseurs
                                from d in af.EveDecaissements
                                where af.CodeAutreFournisseur == codeFournisseur
                                select new
                                {
                                    Date = d.DateDecaissement,
                                    d.Description,
                                    MontantAchat = 0m,
                                    MontantPaye = d.Montant,
                                    Solde = 0m
                                });

        var decaissementServFourn = (from fs in _services.Db.AgeFournisseursServicesFournitures
                                    from d in fs.EveDecaissements
                                    where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                    select new
                                    {
                                        Date = d.DateDecaissement,
                                        d.Description,
                                        MontantAchat = 0m,
                                        MontantPaye = d.Montant,
                                        Solde = 0m
                                    });

        DataTable dt;
        var soldeInitial = 0m;

        if (rbtFMatieresPremieres.Checked)
        {
            var ops = achatMatierePrem.Concat(decaissementMP).OrderBy(op => op.Date).ToList();
            dt = DataTableHelper.ConvertirEnTableDeDonnees(ops);
            soldeInitial = _services.Db.AgeFournisseursMatieresPremieres
                .Where(f => f.CodeFournisseurMatierePremiere == codeFournisseur)
                .Select(f => (decimal?)f.SoldeDette).Sum() ?? 0m;
        }
        else if (rbtFEquipementsInfra.Checked)
        {
            var ops = achatEquipementInfr.Concat(decaisementEquip).OrderBy(op => op.Date).ToList();
            dt = DataTableHelper.ConvertirEnTableDeDonnees(ops);
            soldeInitial = _services.Db.AgeAutreFournisseurs
                .Where(f => f.CodeAutreFournisseur == codeFournisseur)
                .Select(f => (decimal?)f.SoldeInitialDetteFournisseur).Sum() ?? 0m;
        }
        else
        {
            var ops = achatServFournitures.Concat(decaissementServFourn).OrderBy(op => op.Date).ToList();
            dt = DataTableHelper.ConvertirEnTableDeDonnees(ops);
            soldeInitial = _services.Db.AgeFournisseursServicesFournitures
                .Where(f => f.CodeFournisseurServiceFourniture == codeFournisseur)
                .Select(f => (decimal?)f.SoldeDette).Sum() ?? 0m;
        }

        var dr = dt.NewRow();
        dt.Rows.InsertAt(dr, 0);
        dr["MontantAchat"] = 0;
        dr["MontantPaye"] = 0;
        dr["Solde"] = 0;

        dgvDetails.DataSource = dt;

        FormatColumn("MontantAchat", "N0");
        FormatColumn("MontantPaye", "N0");
        FormatColumn("Solde", "N0");
        dgvDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        if (dgvDetails.Columns.Contains("Date"))
            dgvDetails.Columns["Date"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        if (dgvDetails.Columns.Contains("Description"))
            dgvDetails.Columns["Description"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        for (int i = 0; i < dgvDetails.Rows.Count; i++)
        {
            if (i > 0)
            {
                dgvDetails.Rows[i].Cells[4].Value =
                    Convert.ToDecimal(dgvDetails.Rows[i - 1].Cells[4].Value)
                    + Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value)
                    - Convert.ToDecimal(dgvDetails.Rows[i].Cells[3].Value);
            }
            else
            {
                dgvDetails.Rows[i].Cells[4].Value =
                    soldeInitial
                    + Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value)
                    - Convert.ToDecimal(dgvDetails.Rows[i].Cells[3].Value);
            }
        }
    }

    private void FormatColumn(string column, string format)
    {
        if (dgvDetails.Columns.Contains(column))
            dgvDetails.Columns[column]!.DefaultCellStyle.Format = format;
    }

    private void ClearTable()
    {
        dgvDetails.DataSource = null;
        dgvDetails.Refresh();
    }
}

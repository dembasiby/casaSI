using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_RegistreImmobilisations : UserControl
{
    private readonly ServiceContainer _services;

    public UC_RegistreImmobilisations(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_RegistreImmobilisations_Load(object sender, EventArgs e)
    {
        var immobilisations = (from inE in _services.Db.ResEquipementsInfrastructures
                               where inE.DateAcquisition.Year + inE.DureeDeVie >= DateTime.Today.Year
                               select new
                               {
                                   Immobilisation = inE.Nom,
                                   inE.Quantite,
                                   ValeurDOrigine = inE.Montant,
                                   inE.DateAcquisition,
                                   inE.DureeDeVie,
                                   AmortissementMensuel = inE.Montant / (inE.DureeDeVie * 12),
                                   AmortissementTrimestriel = inE.Montant / (inE.DureeDeVie * 4),
                                   AmortissementAnnuel = inE.Montant / inE.DureeDeVie
                               }).ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(immobilisations);
        dgvImmobilisations.DataSource = dt;

        FormatColumn("ValeurDOrigine", "N0");
        FormatColumn("AmortissementMensuel", "N0");
        FormatColumn("AmortissementTrimestriel", "N0");
        FormatColumn("AmortissementAnnuel", "N0");
    }

    private void FormatColumn(string column, string format)
    {
        if (dgvImmobilisations.Columns.Contains(column))
        {
            dgvImmobilisations.Columns[column]!.DefaultCellStyle.Format = format;
            dgvImmobilisations.Columns[column]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}

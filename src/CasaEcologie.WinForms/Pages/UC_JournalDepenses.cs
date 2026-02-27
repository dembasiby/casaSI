using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_JournalDepenses : UserControl
{
    private readonly ServiceContainer _services;

    public UC_JournalDepenses(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_JournalDepenses_Load(object sender, EventArgs e)
    {
        var matP = (from rmp in _services.Db.EveReceptionMatieresPremieres
                    select new
                    {
                        Date = rmp.DateReception,
                        Description = "Achat et transport " + rmp.ResStockMatieresPremiere.NomMatiere,
                        Matiere_Premiere = rmp.Montant + rmp.TransportMatierePremiere,
                        Services_et_fournitures = 0m,
                        Infrastructures_et_equipements = 0m,
                        Personnel = 0m,
                    });

        var sF = (from asf in _services.Db.EveAcquisitionServicesFournitures
                  where asf.ResServicesFourniture.NomServiceFourniture.ToLower() != "autres salaires"
                  select new
                  {
                      Date = asf.Date,
                      Description = asf.ResServicesFourniture.NomServiceFourniture,
                      Matiere_Premiere = 0m,
                      Services_et_fournitures = asf.Montant + (asf.TransportServiceFourniture ?? 0m),
                      Infrastructures_et_equipements = 0m,
                      Personnel = 0m,
                  });

        var autresSalaires = (from asf in _services.Db.EveAcquisitionServicesFournitures
                              where asf.ResServicesFourniture.NomServiceFourniture.ToLower() == "autres salaires"
                              select new
                              {
                                  Date = asf.Date,
                                  Description = asf.ResServicesFourniture.NomServiceFourniture,
                                  Matiere_Premiere = 0m,
                                  Services_et_fournitures = 0m,
                                  Infrastructures_et_equipements = 0m,
                                  Personnel = asf.Montant,
                              });

        var eInf = (from rei in _services.Db.EveReceptionEquipementsInfrastructures
                    select new
                    {
                        Date = rei.ResEquipementsInfrastructure.DateAcquisition,
                        Description = rei.ResEquipementsInfrastructure.Nom,
                        Matiere_Premiere = 0m,
                        Services_et_fournitures = 0m,
                        Infrastructures_et_equipements = rei.ResEquipementsInfrastructure.Montant,
                        Personnel = 0m,
                    });

        var perso = (from d in _services.Db.EveDecaissements
                     where d.CodePaiementEmploye != null
                     select new
                     {
                         Date = d.DateDecaissement,
                         d.Description,
                         Matiere_Premiere = 0m,
                         Services_et_fournitures = 0m,
                         Infrastructures_et_equipements = 0m,
                         Personnel = d.Montant,
                     });

        var resultat = matP.Concat(sF).Concat(eInf).Concat(perso).Concat(autresSalaires)
            .OrderByDescending(d => d.Date)
            .ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(resultat);
        dgvJournalDepenses.DataSource = dt;

        FormatColumn("Matiere_Premiere", "N0");
        FormatColumn("Services_et_fournitures", "N0");
        FormatColumn("Infrastructures_et_equipements", "N0");
        FormatColumn("Personnel", "N0");
    }

    private void FormatColumn(string column, string format)
    {
        if (dgvJournalDepenses.Columns.Contains(column))
        {
            dgvJournalDepenses.Columns[column].DefaultCellStyle.Format = format;
        }
    }
}

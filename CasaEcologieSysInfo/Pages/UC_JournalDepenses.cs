using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo
{
    public partial class UC_JournalDepenses : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_JournalDepenses()
        {
            InitializeComponent();
            
        }

        private void FormatColumn(string column, string frmt)
        {
            adgvJournalDepenses.Columns[column].DefaultCellStyle.Format = frmt;
        }

        private void UC_JournalDepenses_Load(object sender, EventArgs e)
        {
            var matP = (from rmp in db.EveReceptionMatieresPremieres
                        join mp in db.ResStockMatieresPremieres on rmp.CodeMatierePremiere equals mp.CodeMatierePremiere

                        select new
                        {
                            Date = rmp.DateReception,
                            Description = mp.NomMatiere,
                            Matiere_Premiere = rmp.Montant + (decimal?)rmp.TransportMatierePremiere ?? 0m,
                            Services_et_fournitures = 0m,
                            Infrastructures_et_equipements = 0m,
                            Personnel = 0m
                        });

            var sF = (from asf in db.EveAcquisitionServicesFournitures
                      join sf in db.ResServicesFournitures on asf.CodeServiceFourniture equals sf.CodeServiceFourniture

                      select new
                      {
                          asf.Date,
                          Description = sf.NomServiceFourniture,
                          Matiere_Premiere = 0m,
                          Services_et_fournitures = asf.Montant + asf.TransportServiceFourniture ?? 0m,
                          Infrastructures_et_equipements = 0m,
                          Personnel = 0m
                      });

            var eInf = (from rei in db.EveReceptionEquipementsInfrastructures
                        join ie in db.ResEquipementsInfrastructures on rei.CodeEquipementInfrastructure equals ie.CodeEquipementInfrastructure

                        select new
                        {
                            Date = ie.DateAcquisition,
                            Description = ie.Nom,
                            Matiere_Premiere = 0m,
                            Services_et_fournitures = 0m,
                            Infrastructures_et_equipements = ie.Montant,
                            Personnel = 0m
                        });

            var perso = (from d in db.EveDecaissements
                         where d.CodePaiementEmploye != null

                         select new
                         {
                             Date = d.DateDecaissement,
                             d.Description,
                             Matiere_Premiere = 0m,
                             Services_et_fournitures = 0m,
                             Infrastructures_et_equipements = 0m,
                             Personnel = d.Montant
                         });

            var resultat = matP.Concat(sF).Concat(eInf).Concat(perso)
                .OrderByDescending(d => d.Date)
                .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultat);
            adgvJournalDepenses.DataSource = dt;
            FormatColumn("Matiere_Premiere", "n0");
            FormatColumn("Services_et_fournitures", "n0");
            FormatColumn("Infrastructures_et_equipements", "n0");
            FormatColumn("Personnel", "n0");
        }

        private void AdgvDepensesMatPrem_FilterStringChanged(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.RowFilter = myDataGrid.FilterString;
        }

        private void AdgvDepensesMatPrem_SortStringChanged(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.Sort = myDataGrid.SortString;
        }

        private void BtnImprimerFicheStock_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Journal des dépenses", adgvJournalDepenses);
        }
    }
}

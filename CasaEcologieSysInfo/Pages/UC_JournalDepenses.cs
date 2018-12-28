using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_JournalDepenses : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

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
                            Matiere_Premiere = rmp.Montant,
                            Services_et_fournitures = 0m,
                            Infrastructures_et_equipements = 0m,
                            Personnel = 0m
                        });

            var sF = (from asf in db.EveAcquisitionServicesFournitures
                      join sf in db.ResServicesFournitures on asf.CodeServiceFourniture equals sf.CodeServiceFourniture

                      select new
                      {
                          Date = asf.Date,
                          Description = sf.NomServiceFourniture,
                          Matiere_Premiere = 0m,
                          Services_et_fournitures = asf.Montant,
                          Infrastructures_et_equipements = 0m,
                          Personnel = 0m
                      });

            var eInf = (from rei in db.EveReceptionEquipementsInfrastructures
                        join ie in db.ResEquipementsInfrastructures on rei.CodeEquipementInfrastructure equals ie.CodeEquipementInfrastructure

                        select new
                        {
                            Date = rei.DateReception,
                            Description = ie.Nom,
                            Matiere_Premiere = 0m,
                            Services_et_fournitures = 0m,
                            Infrastructures_et_equipements = rei.Montant,
                            Personnel = 0m
                        });

            var resultat = matP.Union(sF).Union(eInf)
                .OrderByDescending(d => d.Date)
                .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultat);
            adgvJournalDepenses.DataSource = dt;
            FormatColumn("Matiere_Premiere", "c0");
            FormatColumn("Services_et_fournitures", "c0");
            FormatColumn("Infrastructures_et_equipements", "c0");
            FormatColumn("Personnel", "c0");
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
    }
}

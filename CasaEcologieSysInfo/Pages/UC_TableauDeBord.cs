using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MoreLinq;

namespace CasaEcologieSysInfo
{
    public partial class UC_TableauDeBord : UserControl
    {

        CasaDBEntities db = new CasaDBEntities();

        public UC_TableauDeBord()
        {
            InitializeComponent();
        }

        private void UC_TableauDeBord_Load(object sender, EventArgs e)
        {
            AfficherTableauVentesMensuelles();
            AfficherDonneesGraphiqueQuantiteAcheteeParMatierePremiere();
        }

        private void AfficherDonneesGraphiqueQuantiteAcheteeParMatierePremiere()
        {

            var liste = (from mp in db.ResStockMatieresPremieres
                         join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                         where rmp.DateReception >= dtpDebut.Value.Date
                         where rmp.DateReception <= dtpFin.Value.Date

                         select new
                         {
                             Matiere = mp.NomMatiere,
                             Quantite = (from rm in db.EveReceptionMatieresPremieres
                                        join m in db.ResStockMatieresPremieres on rm.CodeMatierePremiere equals m.CodeMatierePremiere
                                        where rm.DateReception >= dtpDebut.Value.Date
                                        where rm.DateReception <= dtpFin.Value.Date
                                        where m.NomMatiere == mp.NomMatiere
                                        select rm.Quantite).Sum()
                         })
                         .DistinctBy(r => r.Matiere)
                         .ToList();


            DataTable dt = Conversion.ConvertirEnTableDeDonnees(liste);
            
            dataGridView2.DataSource = dt;

            FormatterDonneesTableau(dataGridView2);

        }

        private void AfficherTableauVentesMensuelles()
        {
            ventesMensuellesResultBindingSource.DataSource = db.VentesMensuelles().ToList();
            var tableau = db.VentesMensuelles().ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(tableau);

            dataGridView1.DataSource = dt;

            var startingYear = 2020;
            var Annees = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Annees.Add(startingYear);
                startingYear++;
            }

            listBox1.DataSource = Annees;
            FormatterDonneesTableau(dataGridView1);
        }

        private void FormatterDonneesTableau(DataGridView grid)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].DefaultCellStyle.Format = "n0";
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherDonneesGraphiqueQuantiteAcheteeParMatierePremiere();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherDonneesGraphiqueQuantiteAcheteeParMatierePremiere();
        }
    }
}

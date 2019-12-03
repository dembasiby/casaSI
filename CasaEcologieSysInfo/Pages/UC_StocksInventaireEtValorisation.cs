using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes.CalculDesCouts;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_StocksInventaireEtValorisation : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();


        public UC_StocksInventaireEtValorisation()
        {
            InitializeComponent();
        }


        private void UC_StocksInventaireEtValorisation_Load(object sender, EventArgs e)
        {
            AfficherTableaux();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AfficherTableaux();
        }


        // Tableau des du stock des matières premières et emballages
        private void AfficherTableauStockMatieresPremieres(DateTime date)
        {
            var matieresPremieres = (from mp in db.ResStockMatieresPremieres
                                     orderby mp.NomMatiere
                                     select mp.NomMatiere).ToList();

            DataTable dt = CreerTableau();

            foreach (var matiere in matieresPremieres)
            {
                var stock = GestionStocks.CalculerSoldeStockMatierePremiere(matiere, date);
                var coutU = CoutDAchatDesMatierePremieres.CoutDAchat(matiere);

                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, dt.Rows.Count);
                dr["Description"] = matiere;
                dr["Stock"] = stock;
                dr["PU"] = coutU;
                dr["Valeur"] = stock * coutU;
            }

            dgvTableauAffichageStocks.DataSource = dt;

            dt.Rows.Add("Total", 0, 0, Conversion.CalculerTotal(dgvTableauAffichageStocks, "Valeur"));

            FormatterTableau(dgvTableauAffichageStocks);
        }

        private void AfficherTableauProduitsSemiFinis(DateTime date)
        {
            var produitsSemiFini = (from psf in db.ResStockProduitsSemiFinis
                                    orderby psf.Description
                                    select psf.Description).ToList();

            DataTable dt = CreerTableau();

            foreach (var psf in produitsSemiFini)
            {
                // string pattern = @"\d";
                var stock = GestionStocks.CalculerSoldeStockProduitSemiFini(psf, date);
                var pu = CoutDeProduction.CoutUnitaireProduitSemiFini(psf);

                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, dt.Rows.Count);
                dr["Description"] = psf;
                dr["Stock"] = stock;
                dr["PU"] = pu;
                dr["Valeur"] = stock * pu;
            }

            dgvTableauAffichageStocks.DataSource = dt;
            dt.Rows.Add("Total", 0, 0, Conversion.CalculerTotal(dgvTableauAffichageStocks, "Valeur"));
            FormatterTableau(dgvTableauAffichageStocks);
        }

        private void AfficherTableauProduitsFinis(DateTime date)
        {
            var produitsFinis = (from pf in db.ResStockProduitsFinis
                                 orderby pf.NomProduit
                                 select pf.NomProduit).ToList();

            DataTable dt = CreerTableau();

            foreach (var pf in produitsFinis)
            {
                var stock = GestionStocks.CalculerSoldeStockProduitFini(pf, date);
                var pu = CoutDeProduction.CoutUnitaireProduction(pf);

                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, dt.Rows.Count);
                dr["Description"] = pf;
                dr["Stock"] = stock;
                dr["PU"] = pu;
                dr["Valeur"] = stock * pu;
            }

            dgvTableauAffichageStocks.DataSource = dt;
            dt.Rows.Add("Total", 0, 0, Conversion.CalculerTotal(dgvTableauAffichageStocks, "Valeur"));
            FormatterTableau(dgvTableauAffichageStocks);
        }


        /**********************************************************************************************************
               CREATION DES TABLES
        **********************************************************************************************************/


        private DataTable CreerTableau()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Description", typeof(String));
            dt.Columns.Add("Stock", typeof(float));
            dt.Columns.Add("PU", typeof(float));
            dt.Columns.Add("Valeur", typeof(float));

            return dt;
        }

        private static void FormatterTableau(DataGridView grid)
        {
            grid.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["PU"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Valeur"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns["Stock"].DefaultCellStyle.Format = "n1";
            grid.Columns["PU"].DefaultCellStyle.Format = "n0";
            grid.Columns["Valeur"].DefaultCellStyle.Format = "n0";
        }


        private void AfficherTableaux()
        {
            if (rbtnMatieresPremieres.Checked)
            {
                AfficherTableauStockMatieresPremieres(dateTimePicker1.Value.Date);
            }
            else if (rbtnProduitsSemiFinis.Checked)
            {
                AfficherTableauProduitsSemiFinis(dateTimePicker1.Value.Date);
            }
            else
            {
                AfficherTableauProduitsFinis(dateTimePicker1.Value.Date);
            }
        }


        /**********************************************************************************************************
               AFFICHAGE DU TABLEAU DES STOCKS
        **********************************************************************************************************/


        private decimal CoutDeLaMainDOeuvreParProduit(string produit)
        {
            return 0m;
        }

        private void RbtnMatieresPremieres_CheckedChanged(object sender, EventArgs e)
        {           
            AfficherTableauStockMatieresPremieres(dateTimePicker1.Value.Date);
        }

        private void RbtnProduitsSemiFinis_CheckedChanged(object sender, EventArgs e)
        {
            AfficherTableauProduitsSemiFinis(dateTimePicker1.Value.Date);
        }

        private void RbtnProduitsFinis_CheckedChanged(object sender, EventArgs e)
        {
            AfficherTableauProduitsFinis(dateTimePicker1.Value.Date);
        }
    }
}
    
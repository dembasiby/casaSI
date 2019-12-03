using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Text.RegularExpressions;
using CasaEcologieSysInfo.Classes;
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

            dgvMatieresPremieres.DataSource = dt;

            dt.Rows.Add("Total", 0, 0, Conversion.CalculerTotal(dgvMatieresPremieres, "Valeur"));

            FormatterTableau(dgvMatieresPremieres);
        }

        private void AfficherTableauStockProduitsSemiFinis(DateTime date)
        {
            var produitsSemiFini = (from psf in db.ResStockProduitsSemiFinis
                                    orderby psf.Description
                                    select psf.Description).ToList();

            DataTable dt = CreerTableau();

            foreach (var psf in produitsSemiFini)
            {
                // string pattern = @"\d";

                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, dt.Rows.Count);
                dr["Description"] = psf;
                dr["Stock"] = 0;
                dr["PU"] = 0;
                dr["Valeur"] = 0;
            }

            dgvProduitsSemiFinis.DataSource = dt;
            dt.Rows.Add("Total", 0, 0, Conversion.CalculerTotal(dgvProduitsSemiFinis, "Valeur"));
            FormatterTableau(dgvProduitsSemiFinis);
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

            dgvProduitsFinis.DataSource = dt;
            dt.Rows.Add("Total", 0, 0, Conversion.CalculerTotal(dgvProduitsFinis, "Valeur"));
            FormatterTableau(dgvProduitsFinis);
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
            AfficherTableauStockMatieresPremieres(dateTimePicker1.Value.Date);
            AfficherTableauStockProduitsSemiFinis(dateTimePicker1.Value.Date);
            AfficherTableauProduitsFinis(dateTimePicker1.Value.Date);
        }


        /**********************************************************************************************************
               CALCUL DES COUTS
        **********************************************************************************************************/

        // Coût de l'emballage par produit fini
        private decimal CoutEmballageParProduitFini(string produit)
        {
            string emballage = (from ppf in db.EveProductionStockProduitsFinis
                                from pf in db.ResStockProduitsFinis
                                from p in db.EveProductions
                                from ur in db.EveUtilisationRessources
                                from ump in db.EveUtilisationMatieresPremieres
                                from mp in db.ResStockMatieresPremieres

                                where pf.CodeProduit == ppf.CodeProduitFini
                                where ppf.CodeProduction == p.CodeProduction
                                where ur.CodeUtilisationRessources == p.CodeUtilisationRessources
                                where ump.CodeUtilisationRessource == ur.CodeUtilisationRessources
                                where ump.CodeMatierePremiere == mp.CodeMatierePremiere
                                where mp.TypeMatiere == "emballage"
                                where pf.NomProduit == produit
                                where ppf.QuantiteProduitFini == ump.QuantiteMatierePremiere
                                select mp.NomMatiere).FirstOrDefault();

            decimal montant = (from rmp in db.EveReceptionMatieresPremieres
                               where rmp.ResStockMatieresPremiere.NomMatiere == emballage
                               select (decimal?)rmp.Montant).Sum() ?? 0m;
            float quantite = (from rmp in db.EveReceptionMatieresPremieres
                              where rmp.ResStockMatieresPremiere.NomMatiere == emballage
                              select (float?)rmp.Quantite).Sum() ?? 0f;


            if (montant > 0 && quantite > 0)
            {
                return montant / (decimal)quantite;
            }
            else
            {
                return 0m;
            }

        }

        private decimal CoutDeLaMainDOeuvreParProduit(string produit)
        {
            return 0m;
        }
    }
}
    
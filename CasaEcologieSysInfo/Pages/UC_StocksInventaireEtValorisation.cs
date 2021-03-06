﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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
                dr["Coût unitaire"] = coutU;
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
                dr["Coût unitaire"] = pu;
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
                dr["Coût unitaire"] = pu;
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
            dt.Columns.Add("Coût unitaire", typeof(float));
            dt.Columns.Add("Valeur", typeof(float));

            return dt;
        }

        private static void FormatterTableau(DataGridView grid)
        {
            grid.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Coût unitaire"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Valeur"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns["Stock"].DefaultCellStyle.Format = "n1";
            grid.Columns["Coût unitaire"].DefaultCellStyle.Format = "n0";
            grid.Columns["Valeur"].DefaultCellStyle.Format = "n0";
        }


        private void AfficherTableaux()
        {
            if (rbtnMatieresPremieres.Checked)
            {
                AfficherTableauStockMatieresPremieres(dtpDate.Value.Date);
            }
            else if (rbtnProduitsSemiFinis.Checked)
            {
                AfficherTableauProduitsSemiFinis(dtpDate.Value.Date);
            }
            else
            {
                AfficherTableauProduitsFinis(dtpDate.Value.Date);
            }

            AfficherLaValeurTotalDesStocks();
        }

        private void AfficherLaValeurTotalDesStocks()
        {
            DateTime date = dtpDate.Value.Date;

            txtStockMatieresPremieres.Text = InventaireStocksMatieresPremiere.ValeurStockMatieresPremieres(date).ToString("n0") + " FCFA";
            txtStockProduitsSemiFinis.Text = InventaireStockProduitsSemiFinis.ValeurStockProduitsSemiFinis(date).ToString("n0") + " FCFA";
            txtStocksProduitsFinis.Text = InventaireStocksProduitsFinis.ValeurStockProduitsFinis(date).ToString("n0") + " FCFA";
            txtValeurTotaleStocks.Text = GestionStocks.ValeurTotalDesStocks(date).ToString("n0") + " FCFA";
        }


        /**********************************************************************************************************
               AFFICHAGE DU TABLEAU DES STOCKS
        **********************************************************************************************************/


        private void RbtnMatieresPremieres_CheckedChanged(object sender, EventArgs e)
        {           
            AfficherTableauStockMatieresPremieres(dtpDate.Value.Date);
        }

        private void RbtnProduitsSemiFinis_CheckedChanged(object sender, EventArgs e)
        {
            AfficherTableauProduitsSemiFinis(dtpDate.Value.Date);
        }

        private void RbtnProduitsFinis_CheckedChanged(object sender, EventArgs e)
        {
            AfficherTableauProduitsFinis(dtpDate.Value.Date);
        }

        private void BtnImprimerTablStocks_Click(object sender, EventArgs e)
        {
            if (rbtnMatieresPremieres.Checked)
            {
                Impression.ImprimerTableau("Stock de matières premières et emballages", dgvTableauAffichageStocks);
            }
            else if (rbtnProduitsSemiFinis.Checked)
            {
                Impression.ImprimerTableau("Stock de produits semi finis", dgvTableauAffichageStocks);
            }
            else
            {
                Impression.ImprimerTableau("Stock de produits finis", dgvTableauAffichageStocks);
            }
        }
    }
}
    
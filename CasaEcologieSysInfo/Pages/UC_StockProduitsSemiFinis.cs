﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_StockProduitsSemiFinis : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_StockProduitsSemiFinis()
        {
            InitializeComponent();
        }


        private void AfficherJournalCorrespondant(string description)
        {

            var coutUnitaire = 0f;

            var entrees = (from psf in db.ResStockProduitsSemiFinis
                           where psf.Description == description
                           join ppsf in db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppsf.CodeProduitSemiFini
                           join prod in db.EveProductions on ppsf.CodeProduction equals prod.CodeProduction

                           select new
                           {
                               prod.Date,
                               Description = "Production de " + psf.Description,
                               Entree = ppsf.QuantiteProduitSemiFini,
                               Sortie = 0f,
                               Solde = 0f
                           });

            var sorties = (from mp in db.ResStockMatieresPremieres
                           join psf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals psf.CodeMatierePremiere
                           join upsf in db.EveUtilisationProduitsSemiFinis on psf.CodeProduitSemiFini equals upsf.CodeProduitSemiFini
                           join prod in db.EveProductions on upsf.CodeUtilisationRessource equals prod.CodeUtilisationRessources
                           where psf.Description == description

                           select new
                           {
                               prod.Date,
                               Description = "Utilisation de " + psf.Description,
                               Entree = 0f,
                               Sortie = upsf.QuantiteProduitSemiFini,
                               Solde = 0f
                           });

            var resultat = entrees.Concat(sorties)
                .OrderByDescending(d => d.Date)
                .ToList();

            var stockInitial = (from mp in db.ResStockMatieresPremieres
                                join psf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals psf.CodeMatierePremiere
                                where psf.Description == description
                                select psf.Quantite).FirstOrDefault();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultat);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, dt.Rows.Count);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Stock initial";

            dt.Columns.Add("PU", typeof(float));
            dt.Columns.Add("Valeur", typeof(float));

            dgvJournalStocksProduitsSemiFinis.DataSource = dt;

            Formattage.TableauDesStock(dgvJournalStocksProduitsSemiFinis);
            Conversion.CalculerSoldeStocksDeFaconProgressive(dgvJournalStocksProduitsSemiFinis, stockInitial);

            //float number;
            bool isNumeric = float.TryParse(coutUnitaire.ToString(), out float number);
            float pu = (isNumeric ? coutUnitaire : 0f);

            foreach (DataRow row in dt.Rows)
            {
                row["PU"] = pu;
                row["Valeur"] = Convert.ToSingle(row["Solde"].ToString()) * pu;
            }
        }

        private void UC_StockProduitsSemiFinis_Load(object sender, EventArgs e)
        {
            var listeProduitsSemiFinis = (from psf in db.ResStockProduitsSemiFinis
                                          select psf.Description).ToList();

            lbxListeProduitsSemiFinis.DataSource = listeProduitsSemiFinis;

            var description = lbxListeProduitsSemiFinis.GetItemText(lbxListeProduitsSemiFinis.SelectedItem);
            AfficherJournalCorrespondant(description);
        }

        private void lbxListeProduitsSemiFinis_SelectedIndexChanged(object sender, EventArgs e)
        {

            var nomProduit = lbxListeProduitsSemiFinis.GetItemText(lbxListeProduitsSemiFinis.SelectedItem);
            AfficherJournalCorrespondant(nomProduit);
        }

        private void BtnImprimerFicheStock_Click(object sender, EventArgs e)
        {
            Impression.ImprimerFicheDeStock(lbxListeProduitsSemiFinis, dgvJournalStocksProduitsSemiFinis);
        }
    }
}

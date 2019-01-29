﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_EtatsFinCompteDeResultat : UserControl
    {

        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_EtatsFinCompteDeResultat()
        {
            InitializeComponent();
        }

        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherAnnees();
            AfficherCompteDeResultat();

            //AfficherCoutMatierePremierePrincipalParUnite();

            var date = dtpAnnee.Value.Date;
            DateTime debut = DateTime.Parse($"{date.Year},1,1");
            DateTime fin = DateTime.Parse($"{date.Year},1,{DateTime.DaysInMonth(date.Year, date.Month)}");

            var listeDesProduitsVendusDurantLaPeriode = (from pf in db.ResStockProduitsFinis
                                                         join vpf in db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                                                         where vpf.EveVente.DateVente >= debut
                                                         where vpf.EveVente.DateVente <= fin
                                                         select new { Produit = pf.NomProduit })
                                                         .Distinct().OrderBy(p => p.Produit)
                                                         .Select(p => p.Produit).ToList();

            listBox1.DataSource = listeDesProduitsVendusDurantLaPeriode;

            
        }

        private void DtpAnnee_ValueChanged(object sender, EventArgs e)
        {
            AfficherCompteDeResultat();
        }

        private void AfficherAnnees()
        {
            dtpAnnee.Format = DateTimePickerFormat.Custom;
            dtpAnnee.CustomFormat = "yyyy";
            dtpAnnee.ShowUpDown = true;
        }

        private string CalculerVentesMois(int NumMois, DateTime date)
        {
            return ((from v in db.EveVentes
                     join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                     where v.DateVente.Year == date.Year
                     where v.DateVente.Month == NumMois
                     select (decimal?)vp.Montant).Sum() ?? 0m).ToString("n0");
        }

        private decimal CalculerCoutDesProduitsFabriques(int numMois, DateTime date)
        {
            return 0m;
        }

        private void CoutDesMatieresPremieresUtiliseesParProduit(string nomProduit)
        {

        }

        private float? CalculerCoutDesProduitsVendusParProduit(string nomProduit)
        {
            // FORMULE DE CALCUL DU COUT DES PRODUITS VENDUS

            // COGS = Beginning Finished Goods Inventory + COGM - Ending Finished Goods Inventory
            // COGM = Beginning WIP + Total Manufacturing Cost(TMC) - Ending WIP
            // TMC = Raw materials used + Direct labor + Manufacturing overhead
            // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory
            var matieres = nomProduit.Split(' ');
            var matierePremiere = matieres[1];
            
            var coutMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                       join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                       where mp.NomMatiere == matierePremiere
                                       select (decimal?)amp.Montant).Sum() ?? 0m;

            var coutTransportMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                                join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                                where mp.NomMatiere == matierePremiere
                                                select (decimal?)amp.TransportMatierePremiere).Sum() ?? 0m;

            var quantiteAchetee = (from mp in db.ResStockMatieresPremieres
                                   join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                   where mp.NomMatiere == matierePremiere
                                   select (float?)amp.Quantite).Sum() ?? 0f;

            
            // Cout du sucre utilise
            // Cout des emballages utilisees

            // calculer le cout unitaire pour chaque kilo de matiere premiere
            var coutTotal = coutMatierePremiere + coutTransportMatierePremiere;
            var coutUnitaireMatierePremiere = 0;
            if (Convert.ToInt32(quantiteAchetee) > 0)
            {
                coutUnitaireMatierePremiere = Convert.ToInt32(coutTotal) / Convert.ToInt32(quantiteAchetee);
            }
            
            // calculer la quantite moyenne de matiere premiere utilisee par unite de produit fini

            var quantiteDeMatierePremiereUtilisee = (from pf in db.ResStockProduitsFinis
                                                     join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                                                     join ur in db.EveUtilisationMatieresPremieres on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                                     where ur.ResStockMatieresPremiere.NomMatiere == matierePremiere
                                                     where pf.NomProduit == nomProduit
                                                     select new
                                                     {
                                                         MatierePrem = ur.QuantiteMatierePremiere,
                                                         ProduitFini = ppf.QuantiteProduitFini
                                                     });

            var quantiteMatP = quantiteDeMatierePremiereUtilisee.Select(m => (float?)m.MatierePrem).Sum() ?? 0f;
            var quantitePF = quantiteDeMatierePremiereUtilisee.Select(m => (float?)m.ProduitFini).Sum() ?? 0f;

            float quantiteMoyenneParProduitFini = 0f;

            if (quantiteMatP > 0f && quantitePF > 0f)
            {
                quantiteMoyenneParProduitFini = quantiteMatP / quantitePF;
            }
            else
            {
                quantiteMoyenneParProduitFini = 0f;
            }            

            if (coutUnitaireMatierePremiere > 0f && quantiteMoyenneParProduitFini > 0f)
            {
                return (coutUnitaireMatierePremiere * quantiteMoyenneParProduitFini);
            }
            else
            {
                return 0f;
            }
            //return /*Convert.ToSingle(coutUnitaireMatierePremiere);// */ quantiteMoyenneParProduitFini;
        }

        private float CalculerCoutDesProduitsVendus(int numMois, DateTime date)
        {
            // var matieresPremieresUtilisees
            float coutDesProduitsVendus = 0f;
            DateTime debut = new DateTime(date.Year, numMois, 1);
            DateTime fin = new DateTime(date.Year, numMois, DateTime.DaysInMonth(date.Year, numMois));

            var listeDesProduitsVendusDurantLaPeriode = (from pf in db.ResStockProduitsFinis
                                                         join vpf in db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                                                         where vpf.EveVente.DateVente >= debut
                                                         where vpf.EveVente.DateVente <= fin

                                                         select new { Produit = pf.NomProduit})
                                                         .Distinct().OrderBy(p => p.Produit)
                                                         .Select(p => p.Produit).ToList();

            foreach (var produit in listeDesProduitsVendusDurantLaPeriode)
            {
                // calculer la variation des stocks
                var stockDispoEnDebutDePeriod = Conversion.CalculerSoldeStockProduitFiniDebutPeriod(produit, debut);
                var stockDispoEnFinDePeriod = Conversion.CalculerSoldeStockProduitFiniFinPeriod(produit, fin);

                var variationStock = stockDispoEnDebutDePeriod - stockDispoEnFinDePeriod;

                coutDesProduitsVendus += (Convert.ToSingle(CalculerCoutDesProduitsVendusParProduit(produit)) * variationStock);
            }

            return coutDesProduitsVendus;
        }

        private void AfficherVentesMensuelles()
        {
            dgvCompteDeResultats.Rows.Add("Chiffre d'affaires",
                CalculerVentesMois(1, dtpAnnee.Value.Date),
                CalculerVentesMois(2, dtpAnnee.Value.Date),
                CalculerVentesMois(3, dtpAnnee.Value.Date),
                CalculerVentesMois(4, dtpAnnee.Value.Date),
                CalculerVentesMois(5, dtpAnnee.Value.Date),
                CalculerVentesMois(6, dtpAnnee.Value.Date),
                CalculerVentesMois(7, dtpAnnee.Value.Date),
                CalculerVentesMois(8, dtpAnnee.Value.Date),
                CalculerVentesMois(9, dtpAnnee.Value.Date),
                CalculerVentesMois(10, dtpAnnee.Value.Date),
                CalculerVentesMois(11, dtpAnnee.Value.Date),
                CalculerVentesMois(12, dtpAnnee.Value.Date));
        }

        private void AfficherCoutsDesProduitsVendus()
        {
            dgvCompteDeResultats.Rows.Add("Coût des produits vendus",
                CalculerCoutDesProduitsVendus(1, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(2, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(3, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(4, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(5, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(6, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(7, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(8, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(9, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(10, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(11, dtpAnnee.Value.Date).ToString("n0"),
                CalculerCoutDesProduitsVendus(12, dtpAnnee.Value.Date).ToString("n0")
                );
        }

        private void AfficherMargeBrute()
        {
            dgvCompteDeResultats.Rows.Add("Marge brute",
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[1].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[1].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[2].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[2].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[3].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[3].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[4].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[4].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[5].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[5].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[6].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[6].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[7].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[7].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[8].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[8].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[9].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[9].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[10].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[10].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[11].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[11].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(dgvCompteDeResultats.Rows[0].Cells[12].Value.ToString()) 
                    - Convert.ToSingle(dgvCompteDeResultats.Rows[1].Cells[12].Value.ToString())).ToString("n0")
                );
        }


        private void AfficherCompteDeResultat()
        {
            dgvCompteDeResultats.Rows.Clear();
            dgvCompteDeResultats.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCompteDeResultats.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            AfficherVentesMensuelles();
            AfficherCoutsDesProduitsVendus();
            AfficherMargeBrute();
        }


        private void AfficherCoutMatierePremierePrincipalParUnite()
        {
            var produit = listBox1.GetItemText(listBox1.SelectedItem);
            txtCoutMatierePremiereParUnite.Text =  CalculerCoutDesProduitsVendusParProduit(produit).ToString();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherCoutMatierePremierePrincipalParUnite();
        }
    }
}
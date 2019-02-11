using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_EtatsFinCompteDeResultat : UserControl
    {

        CasaDBEntities db = new CasaDBEntities();

        public UC_EtatsFinCompteDeResultat()
        {
            InitializeComponent();
        }

        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherAnnees();
            //AfficherCompteDeResultat();

            var date = dtpAnnee.Value.Date;
            DateTime debut = new DateTime(date.Year, 1, 1);
            DateTime fin = new DateTime(date.Year, 1, DateTime.DaysInMonth(date.Year, 1));

            var listeDesProduits = (from pf in db.ResStockProduitsFinis
                                    select new { Produit = pf.NomProduit })
                                                         .Distinct().OrderBy(p => p.Produit)
                                                         .Select(p => p.Produit).ToList();

            List<string> listeProdFinis = new List<string>();

            // Calculer le stock de depart et le stock final pour chaque produit fini vendu
            foreach (var produit in listeDesProduits)
            {
                var cogsProduit = Convert.ToSingle(CalculerCoutDesProduitsVendusParProduit(produit));

                if (cogsProduit == 0)
                {
                    cogsProduit = (from p in db.ResStockProduitsFinis where p.NomProduit == produit select p.PrixDeVenteStandard).FirstOrDefault() * 0.6f;
                }
                var stockProduitFiniDeLaPeriode = Conversion.CalculerSoldeStockProduitFiniParPeriod(produit, debut);
                var cogs = (cogsProduit * stockProduitFiniDeLaPeriode).ToString("n0");
               listeProdFinis.Add($"{produit} - {cogs}");
                // Convert.ToSingle(CalculerCoutDesProduitsVendusParProduit(produit)) *

            }

            listBox1.DataSource = listeProdFinis;
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

        // VALUE OF RAW MATERIALS USED
        // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory
        private float MatieresPremiereUtilisees(int numMois)
        {
            var valeurMatieresPremieresUtilisees = 0f;

            var date = dtpAnnee.Value.Date;
            DateTime debut = new DateTime(date.Year, numMois, 1);
            DateTime fin = new DateTime(date.Year, numMois, DateTime.DaysInMonth(date.Year, numMois));

            var matieresPremieres = (from mp in db.ResStockMatieresPremieres
                                     select mp.NomMatiere)
                                     .ToList();
                   
            foreach (var matierePremiere in matieresPremieres)
            {
                var coutUnitaire = GestionStocks.CoutUnitaireParMatierePremiere(matierePremiere);
                var valeurMatiereDebut = Single.IsNaN(GestionStocks.CalculerSoldeStockMatierePremiere(matierePremiere, debut) * coutUnitaire) ? 0 : GestionStocks.CalculerSoldeStockMatierePremiere(matierePremiere, debut) * coutUnitaire;
                var valeurMatiereFin = Single.IsNaN(GestionStocks.CalculerSoldeStockMatierePremiere(matierePremiere, fin) * coutUnitaire) ? 0 : GestionStocks.CalculerSoldeStockMatierePremiere(matierePremiere, fin) * coutUnitaire;
                var valeurAchats = Single.IsNaN(GestionStocks.ValeurAchatsMatierePremiere(matierePremiere, debut, fin)) ? 0 : GestionStocks.ValeurAchatsMatierePremiere(matierePremiere, debut, fin);
                valeurMatieresPremieresUtilisees += (valeurMatiereDebut + valeurAchats - valeurMatiereFin);
                
            }

            return valeurMatieresPremieresUtilisees;

        }

        // TOTAL MANUFACTURING COSTS
        private float TotalManufacturingCosts(int numMois)
        {
            // TMC = Raw materials used + Direct labor + Manufacturing overhead

            var date = dtpAnnee.Value.Date;

            // Valeur des matières premières utilisées
            var rawMaterialsUsed = MatieresPremiereUtilisees(numMois);

            // Coût direct de main-d'oeuvre
            var directLabor = CompteDeResultat.CoutDirectMainDOeuvre(numMois, date);

            // Frais généraux liés à la production
            var manufacturingOverhead = (float)CompteDeResultat.AmortissementsMensuels(date, numMois);

            // Total des coûts de production du mois
            var totalManufacturingCosts =  rawMaterialsUsed + directLabor + manufacturingOverhead;

            return totalManufacturingCosts;
        }

        // COSTS OF GOODS MANUFACTURED (COGM)
        // COGM = Beginning WIP + Total Manufacturing Cost(TMC) - Ending WIP

        private float CostsOfGoodsManufactured(int numMois)
        {
            // COGM = Beginning WIP + Total Manufacturing Cost(TMC) - Ending WIP

            // Beginning Work in Progress (produit semi-fini
            var beginningWIP = 0f;

            // Ending Work in Progress
            var endingWIP = 0f;

            // Total Manufacturing Costs(TMC) du mois
            var TMC = TotalManufacturingCosts(numMois);

            return beginningWIP + TMC - endingWIP;
        }

        private float ValeurStocksDeProduitsFinis(int numMois, DateTime date)
        {
            float coutDesProduitsVendus = 0f;


            // Dresser la liste des produits
            var listeDesProduits = (from pf in db.ResStockProduitsFinis
                                    select new { Produit = pf.NomProduit })
                                                         .Distinct().OrderBy(p => p.Produit)
                                                         .Select(p => p.Produit).ToList();


            // Calculer le stock de depart et le stock final pour chaque produit fini vendu
            foreach (var produit in listeDesProduits)
            {
                var cogsProduit = Convert.ToSingle(CalculerCoutDesProduitsVendusParProduit(produit));

                if (cogsProduit == 0)
                {
                    cogsProduit = (from p in db.ResStockProduitsFinis select p.PrixDeVenteStandard).FirstOrDefault() * 0.8f;
                }
                var stockProduitFiniDeLaPeriode = Conversion.CalculerSoldeStockProduitFiniParPeriod(produit, date);
                coutDesProduitsVendus += (Convert.ToSingle(CalculerCoutDesProduitsVendusParProduit(produit)) * stockProduitFiniDeLaPeriode);
            }

            return coutDesProduitsVendus;
        }

        private float CostOfGoodsSold(int numMois)
        {
            var date = dtpAnnee.Value.Date;
            DateTime debut = new DateTime(date.Year, numMois, 1);
            DateTime fin = new DateTime(date.Year, numMois, DateTime.DaysInMonth(date.Year, numMois));

            // Starting Finished Goods Inventory
            var startingFinishedGoodsInventory = ValeurStocksDeProduitsFinis(numMois, debut);

            // Cost of Goods Manufactured
            var cogm = 0f; // CostsOfGoodsManufactured(numMois);

            // Ending Finished Goods Inventory
            var endingFinishedGoodsInventory = 0f; // ValeurStocksDeProduitsFinis(numMois, fin);

            // Cost of Goods Sold
            var cogs = startingFinishedGoodsInventory + cogm - endingFinishedGoodsInventory;

            return cogs;
        }






        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 





        private float CalculerCoutMatieresPremieres(string nomProduit)
        {
            var matieresPremieres = (from pf in db.ResStockProduitsFinis
                                     join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduction
                                     join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                                     join ur in db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                     where pf.NomProduit == nomProduit
                                     
                                     select new
                                     {
                                         Matiere = ur.ResStockMatieresPremiere.NomMatiere
                                     }).ToList();

            var coutMatieresPremieres = 0f;

            foreach (var matierePremiere in matieresPremieres)
            {
                var coutMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                           join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                           where mp.NomMatiere == matierePremiere.Matiere
                                           select (decimal?)amp.Montant).Sum() ?? 0m;

                var coutTransportMatierePremiere = (from mp in db.ResStockMatieresPremieres
                                                    join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                                    where mp.NomMatiere == matierePremiere.Matiere
                                                    select (decimal?)amp.TransportMatierePremiere).Sum() ?? 0m;

                var quantiteAchetee = (from mp in db.ResStockMatieresPremieres
                                       join amp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals amp.CodeMatierePremiere
                                       where mp.NomMatiere == matierePremiere.Matiere
                                       select (float?)amp.Quantite).Sum() ?? 0f;

                var coutTotal = coutMatierePremiere + coutTransportMatierePremiere;
                if (Convert.ToInt32(quantiteAchetee) > 0)
                {
                    var coutUnitaire = (float)coutTotal / (float)quantiteAchetee;
                    var coutMatiere = coutUnitaire * GestionStocks.QuantiteMatierePremiereParProduitFini(nomProduit, matierePremiere.Matiere);
                    coutMatieresPremieres += coutMatiere;
                }

               // coutMatieresPremieres = GestionStocks.QuantiteMatierePremiereParProduitFini(nomProduit, matierePremiere.Matiere));

            }

            return coutMatieresPremieres;

            //return GestionStocks.QuantiteMatierePremiereParProduitFini(nomProduit, matierePremiere.Matiere);
        }

        /// <summary>
        /// //
        /// </summary>
        /// <param name="RawMaterialsUsed"></param>
        /// <returns></returns>

        private float? CalculerCoutDesProduitsVendusParProduit(string nomProduit)
        {
            // FORMULE DE CALCUL DU COUT DES PRODUITS VENDUS

            // COGS = Beginning Finished Goods Inventory + COGM - Ending Finished Goods Inventory
            // COGM = Beginning WIP + Total Manufacturing Cost(TMC) - Ending WIP
            // TMC = Raw materials used + Direct labor + Manufacturing overhead
            // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory

            /*            

             if (coutUnitaireMatierePremiere > 0f && quantiteMoyenneParProduitFini > 0f)
             {
                 return (coutUnitaireMatierePremiere * quantiteMoyenneParProduitFini);
             }
             else
             {
                 return 0f;
             }


     */
            return CalculerCoutMatieresPremieres(nomProduit);
        }


        

       
        private void AfficherCoutsDesProduitsVendus()
        {
            /*
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
            */
            dgvCompteDeResultats.Rows.Add("Coût des produits vendus",
                CostOfGoodsSold(1).ToString("n0"),
                CostOfGoodsSold(2).ToString("n0"),
                CostOfGoodsSold(3).ToString("n0"),
                CostOfGoodsSold(4).ToString("n0"),
                CostOfGoodsSold(5).ToString("n0"),
                CostOfGoodsSold(6).ToString("n0"),
                CostOfGoodsSold(7).ToString("n0"),
                CostOfGoodsSold(8).ToString("n0"),
                CostOfGoodsSold(9).ToString("n0"),
                CostOfGoodsSold(10).ToString("n0"),
                CostOfGoodsSold(11).ToString("n0"),
                CostOfGoodsSold(12).ToString("n0")
                );
            /*
           for (int i = 1; i <= 12; i++)
           {
               dgvCompteDeResultats.Rows.Add("Coût des produits vendus",
              CalculerCoutDesProduitsVendus(i, dtpAnnee.Value.Date).ToString("n0"));
           }
           */
        }


        private void AfficherCompteDeResultat()
        {
            dgvCompteDeResultats.Rows.Clear();

            // Affichage des différentes lignes des états financiers
            CompteDeResultat.AfficherVentesMensuelles(dgvCompteDeResultats, dtpAnnee); // ligne du chiffre d'affaire
            AfficherCoutsDesProduitsVendus(); // ligne du coût des produits vendus (COGS)
            CompteDeResultat.AfficherMargeBrute(dgvCompteDeResultats); // ligne de calcul de la marge brute
        }


        // FONCTIONS UTILISEES POUR LE DEBUGGING
        /*
        private void AfficherCoutMatierePremierePrincipalParUnite()
        {
            var produit = listBox1.GetItemText(listBox1.SelectedItem).Split(' ')[1];
            txtCoutMatierePremiereParUnite.Text = GestionStocks.CoutUnitaireParMatierePremiere(produit).ToString("n0");
            //txtCoutMatierePremiereParUnite.Text = CalculerCoutDesProduitsVendusParProduit(produit).ToString();
        }
        
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherCoutMatierePremierePrincipalParUnite();
        }
        */
    }
}

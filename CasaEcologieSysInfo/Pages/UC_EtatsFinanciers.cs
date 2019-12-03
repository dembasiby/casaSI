using CasaEcologieSysInfo.Classes;
using CasaEcologieSysInfo.Classes.CalculDesCouts;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_EtatsFinanciers : UserControl
    {

        CasaDBEntities db = new CasaDBEntities();

        public UC_EtatsFinanciers()
        {
            InitializeComponent();
        }

        private void UC_EtatsFinMensuels_Load(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();

            txtCoutAchat.Text = CoutDAchatDesMatierePremieres.CoutDAchat("Pain de singe").ToString();

            txtQuantiteMatieresConsommees.Text = InventaireStocksMatieresPremiere
                .QuantiteDeMatieresConsommees(dtpDebut.Value.Date, dtpFin.Value.Date, "Pain de singe")
                .ToString();

            txtCoutMatieresConsommees.Text = InventaireStocksMatieresPremiere
                .CoutDesMatieresConsommees(dtpDebut.Value.Date, dtpFin.Value.Date, "Pain de singe")
                .ToString();

            txtCoutProductionSachetPainDeSinge.Text = CoutDeProduction
                .CoutProduction(dtpDebut.Value.Date, dtpFin.Value.Date, "Sachet pain de singe")
                .ToString();

            //txtMilleSachets.Text = (CoutDeProduction.CoutProduction("Sachet pain de singe") * 1000).ToString();

            /*
            var date = dtpDebut.Value.Date;
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
            }
    */
        }

        private float CostOfGoodsSold(DateTime debut, DateTime fin)
        {
            

            // Starting Finished Goods Inventory
            var startingFinishedGoodsInventory = ValeurStocksDeProduitsFinis(debut);

            // Cost of Goods Manufactured
            var cogm = CostsOfGoodsManufactured();

            // Ending Finished Goods Inventory
            var endingFinishedGoodsInventory = ValeurStocksDeProduitsFinis(fin);

            // Cost of Goods Sold
            var cogs = startingFinishedGoodsInventory + cogm - endingFinishedGoodsInventory;

            return cogs;
        }

        private float ValeurStocksDeProduitsFinis(DateTime date)
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
                var stockProduitFiniDeLaPeriode = GestionStocks.CalculerSoldeStockProduitFini(produit, date);
                var cogs = cogsProduit * stockProduitFiniDeLaPeriode;

                coutDesProduitsVendus += cogs;
            }

            return coutDesProduitsVendus;
        }

        // VALUE OF RAW MATERIALS USED
        // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory
        private float MatieresPremiereUtilisees()
        {
            var valeurMatieresPremieresUtilisees = 0f;

            DateTime debut = dtpDebut.Value.Date;
            DateTime fin = dtpFin.Value.Date;

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
        private float TotalManufacturingCosts()
        {
            // TMC = Raw materials used + Direct labor + Manufacturing overhead

            DateTime debut = dtpDebut.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            // Valeur des matières premières utilisées
            var rawMaterialsUsed = MatieresPremiereUtilisees();

            // Coût direct de main-d'oeuvre
            var directLabor = CompteDeResultat.CoutDirectMainDOeuvre(debut, fin);

            // Frais généraux liés à la production
            //var manufacturingOverhead = (float)CompteDeResultat.AmortissementsMensuels(date, numMois);
            var manufacturingOverhead = 0;

            // Total des coûts de production du mois
            var totalManufacturingCosts =  rawMaterialsUsed + directLabor + manufacturingOverhead;

            return totalManufacturingCosts;
        }

        // COSTS OF GOODS MANUFACTURED (COGM)
        // COGM = Beginning WIP + Total Manufacturing Cost(TMC) - Ending WIP

        private float CostsOfGoodsManufactured()
        {
            // COGM = Beginning WIP + Total Manufacturing Cost(TMC) - Ending WIP

            // Beginning Work in Progress (produit semi-fini
            var beginningWIP = 0f;

            // Ending Work in Progress
            var endingWIP = 0f;
 
            // Total Manufacturing Costs(TMC) 
            var TMC = TotalManufacturingCosts();

            return beginningWIP + TMC - endingWIP;
        }

        

       

        /// <summary>
        /// //
        /// </summary>
        /// <param name="RawMaterialsUsed"></param>
        /// <returns></returns>

        private decimal? CalculerCoutDesProduitsVendusParProduit(string nomProduit)
        {
            return 0m;
        }



        /// <summary>
        /// // Helpers: Affichage des états financiers
        /// </summary>
        /// 

        private void AfficherEtatsFinanciers()
        {
            AfficherCompteDeResultat();
            AfficherTableauDeTresorerie();
        }

        private void AfficherCompteDeResultat()
        {
            var debut = dtpDebut;
            var fin = dtpFin;
            string cogs;

            if (Validation.MontantEstValide(txtCOGS.Text))
            {
                cogs = Double.Parse(txtCOGS.Text).ToString("n0");
                ReInitialiserTableau(dgvCpteResultats);
                CompteDeResultat.AfficherCompteDeResultats(dgvCpteResultats, cogs, debut, fin);
            }
        }

        private void AfficherTableauDeTresorerie()
        {
            var debut = dtpDebut;
            var fin = dtpFin;

            ReInitialiserTableau(dgvTableauTresorerie);
            Tresorerie.AfficherTresorerie(dgvTableauTresorerie, debut, fin);       
        }

        private void ReInitialiserTableau(DataGridView tableau)
        {
            tableau.Rows.Clear();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void TxtCOGS_TextChanged(object sender, EventArgs e)
        {
            AfficherEtatsFinanciers();
        }

        private void BtnImprimerCpteResultat_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Compte de résultats", dgvCpteResultats);
        }

        private void BtnImprimerTablTresorerie_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Tableau de trésorerie", dgvTableauTresorerie);
        }

        private void BtnImprimerBilan_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableau("Bilan", dgvBilan);
        }
    }
}

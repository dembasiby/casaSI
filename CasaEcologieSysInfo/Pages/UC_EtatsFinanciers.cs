using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Documents;
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
            AfficherCompteDeResultat();

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
        }



      

        // VALUE OF RAW MATERIALS USED
        // Raw materials used = Beginning raw materials inventory + Purchase - Ending raw materials inventory
        private float MatieresPremiereUtilisees(int numMois)
        {
            var valeurMatieresPremieresUtilisees = 0f;

            var date = dtpDebut.Value.Date;
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

            var date = dtpDebut.Value.Date;

            // Valeur des matières premières utilisées
            var rawMaterialsUsed = MatieresPremiereUtilisees(numMois);

            // Coût direct de main-d'oeuvre
            var directLabor = CompteDeResultat.CoutDirectMainDOeuvre(numMois, date);

            // Frais généraux liés à la production
            //var manufacturingOverhead = (float)CompteDeResultat.AmortissementsMensuels(date, numMois);
            var manufacturingOverhead = 0;

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
                var stockProduitFiniDeLaPeriode = Conversion.CalculerSoldeStockProduitFiniParPeriod(produit, date);
                var cogs = cogsProduit * stockProduitFiniDeLaPeriode;

                coutDesProduitsVendus += cogs;
            }

            return coutDesProduitsVendus;
        }

        private float CostOfGoodsSold(int numMois)
        {
            var date = dtpDebut.Value.Date;
            DateTime debut = new DateTime(date.Year, numMois, 1);
            DateTime fin = new DateTime(date.Year, numMois, DateTime.DaysInMonth(date.Year, numMois));

            // Starting Finished Goods Inventory
            var startingFinishedGoodsInventory = ValeurStocksDeProduitsFinis(numMois, debut);

            // Cost of Goods Manufactured
            var cogm = CostsOfGoodsManufactured(numMois);

            // Ending Finished Goods Inventory
            var endingFinishedGoodsInventory = ValeurStocksDeProduitsFinis(numMois, fin);

            // Cost of Goods Sold
            var cogs = startingFinishedGoodsInventory + cogm - endingFinishedGoodsInventory;

            return cogs;
        }






        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 





        private decimal CalculerCoutMatieresPremieres(string nomProduit)
        {
            var matieresPremieres = (from pf in db.ResStockProduitsFinis
                                     join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduction
                                     join p in db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                                     join ur in db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                                     where ur.ResStockMatieresPremiere.TypeMatiere == "fruit"
                                     where pf.NomProduit == nomProduit
                                     
                                     select new
                                     {
                                         Matiere = ur.ResStockMatieresPremiere.NomMatiere
                                     }).ToList();

            decimal coutMatieresPremieres = 0m;

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
                    var coutUnitaire = (decimal)coutTotal / (decimal)quantiteAchetee;
                    var coutMatiere = coutUnitaire * GestionStocks.QuantiteMatierePremierePrincipaleParProduitFini(nomProduit, matierePremiere.Matiere);
                    coutMatieresPremieres += coutMatiere;
                }
            }

            return coutMatieresPremieres;

        }

        /// <summary>
        /// //
        /// </summary>
        /// <param name="RawMaterialsUsed"></param>
        /// <returns></returns>

        private decimal? CalculerCoutDesProduitsVendusParProduit(string nomProduit)
        {
            return CalculerCoutMatieresPremieres(nomProduit);
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



        private void ReInitialiserTableau(DataGridView tableau)
        {
            tableau.Rows.Clear();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherCompteDeResultat();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherCompteDeResultat();
        }

        private void TxtCOGS_TextChanged(object sender, EventArgs e)
        {
            AfficherCompteDeResultat();
        }
    }
}

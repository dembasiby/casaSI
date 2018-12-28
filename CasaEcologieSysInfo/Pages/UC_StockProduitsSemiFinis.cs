using System;
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
    public partial class UC_StockProduitsSemiFinis : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_StockProduitsSemiFinis()
        {
            InitializeComponent();
        }


        private void AfficherJournalCorrespondant(string nomProduit)
        {
            var entrees = (from mp in db.ResStockMatieresPremieres
                           join psf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals psf.CodeMatierePremiere
                           where mp.NomMatiere == nomProduit
                           join ppsf in db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppsf.CodeProduitSemiFini
                           join prod in db.EveProductions on ppsf.CodeProduction equals prod.CodeProduction

                           select new
                           {
                               prod.Date,
                               Description = mp.NomMatiere,
                               Entree = ppsf.QuantiteProduitSemiFini,
                               Sortie = 0,
                               Solde = 0
                           });

            var sorties = (from mp in db.ResStockMatieresPremieres
                           join psf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals psf.CodeMatierePremiere
                           join upsf in db.EveUtilisationProduitsSemiFinis on psf.CodeProduitSemiFini equals upsf.CodeProduitSemiFini
                           join prod in db.EveProductions on upsf.CodeUtilisationRessource equals prod.CodeUtilisationRessources
                           where mp.NomMatiere == nomProduit

                           select new
                           {
                               prod.Date,
                               Description = mp.NomMatiere,
                               Entree = 0,
                               Sortie = upsf.QuantiteProduitSemiFini,
                               Solde = 0
                           });

            var resultat = entrees.Union(sorties)
                .OrderByDescending(d => d.Date)
                .ToList();

            var stockInitial = (from mp in db.ResStockMatieresPremieres
                                join psf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals psf.CodeMatierePremiere
                                where mp.NomMatiere == nomProduit
                                select psf.Quantite).FirstOrDefault();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultat);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, dt.Rows.Count);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Stock initial";

            adgvJournalStocksProduitsSemiFinis.DataSource = dt;

            Conversion.CalculerSoldeStocksDeFaconProgressive(adgvJournalStocksProduitsSemiFinis, stockInitial);
        }

        private void UC_StockProduitsSemiFinis_Load(object sender, EventArgs e)
        {
            var listeProduitsSemiFinis = (from mp in db.ResStockMatieresPremieres
                                          join spsf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals spsf.CodeMatierePremiere
                                          select mp.NomMatiere).ToList();

            lbxListeProduitsSemiFinis.DataSource = listeProduitsSemiFinis;

            var nomProduit = lbxListeProduitsSemiFinis.GetItemText(lbxListeProduitsSemiFinis.SelectedItem);
            AfficherJournalCorrespondant(nomProduit);
        }

        private void AdgvJournalStocksProduitsSemiFinis_FilterStringChanged(object sender, EventArgs e)
        {
            Conversion.FiltrerTableau(sender, e);
        }

        private void AdgvJournalStocksProduitsSemiFinis_SortStringChanged(object sender, EventArgs e)
        {
            Conversion.TrierTableau(sender, e);
        }

        private void lbxListeProduitsSemiFinis_SelectedIndexChanged(object sender, EventArgs e)
        {

            var nomProduit = lbxListeProduitsSemiFinis.GetItemText(lbxListeProduitsSemiFinis.SelectedItem);
            AfficherJournalCorrespondant(nomProduit);
        }
    }
}

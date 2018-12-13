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

        private void UC_StockProduitsSemiFinis_Load(object sender, EventArgs e)
        {
            var entrees = (from mp in db.ResStockMatieresPremieres
                           join psf in db.ResStockProduitsSemiFinis on mp.CodeMatierePremiere equals psf.CodeMatierePremiere
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

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultat);
            adgvJournalStocksProduitsSemiFinis.DataSource = dt;
        }

        private void AdgvJournalStocksProduitsSemiFinis_FilterStringChanged(object sender, EventArgs e)
        {
            Conversion.FiltrerTableau(sender, e);
        }

        private void AdgvJournalStocksProduitsSemiFinis_SortStringChanged(object sender, EventArgs e)
        {
            Conversion.TrierTableau(sender, e);
        }
    }
}

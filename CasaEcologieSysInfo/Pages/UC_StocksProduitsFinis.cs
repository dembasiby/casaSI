using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_StocksProduitsFinis : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_StocksProduitsFinis()
        {
            InitializeComponent();
        }

        private void ListerLesProduitsFinis()
        {
            var liste = (from pf in db.ResStockProduitsFinis
                         select pf)
                         .OrderBy(p => p.NomProduit)
                         .Select(p => p.NomProduit)
                         .ToList();
            lbxListeProduitsFinis.DataSource = liste;
        }

        private void AfficherJournal()
        {
            var nomProduit = lbxListeProduitsFinis.GetItemText(lbxListeProduitsFinis.SelectedItem);
            AfficherJournalCorrespondant(nomProduit);
        }

        private void AfficherJournalCorrespondant(string nomProduit)
        {
            var stockInitial = (from pf in db.ResStockProduitsFinis
                                where pf.NomProduit == nomProduit
                                select pf.StockProduit).FirstOrDefault(); 

            var entrees = (from pf in db.ResStockProduitsFinis
                           join ppf in db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                           join prod in db.EveProductions on ppf.CodeProduction equals prod.CodeProduction
                           where pf.NomProduit == nomProduit

                           select new
                           {
                               prod.Date,
                               Description = "Production de " + pf.NomProduit,
                               Entree = ppf.QuantiteProduitFini,
                               Sortie = 0,
                               Solde = 0
                           });

            var sorties = (from pf in db.ResStockProduitsFinis
                           join vpf in db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                           join v in db.EveVentes on vpf.CodeVente equals v.CodeVente
                           where pf.NomProduit == nomProduit

                           select new
                           {
                               Date = v.DateVente,
                               Description = "Vente de " +  pf.NomProduit,
                               Entree = 0,
                               Sortie = vpf.QuantiteProduitFini,
                               Solde = 0
                           });

            var resultat = entrees.Concat(sorties)
                .OrderByDescending(d => d.Date)
                .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultat);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, dt.Rows.Count);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Stock initial";

            dgvJournalStocksProduitsFinis.DataSource = dt;

            Formattage.TableauDesStock(dgvJournalStocksProduitsFinis);
            Conversion.CalculerSoldeStocksDeFaconProgressive(dgvJournalStocksProduitsFinis, stockInitial);
        }

        private void UC_StocksProduitsFinis_Load(object sender, EventArgs e)
        {
            ListerLesProduitsFinis();
            AfficherJournal();
        }

        private void AdgvJournalStocksProduitsFinis_FilterStringChanged(object sender, EventArgs e)
        {
            Conversion.FiltrerTableau(sender, e);
        }

        private void AdgvJournalStocksProduitsFinis_SortStringChanged(object sender, EventArgs e)
        {
            Conversion.TrierTableau(sender, e);
        }

        private void LbxListeProduitsFinis_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherJournal();
        }
    }
}

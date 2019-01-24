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
    public partial class UC_JournalProduction : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_JournalProduction()
        {
            InitializeComponent();
        }

        private void UC_JournalProduction_Load(object sender, EventArgs e)
        {
            AfficherDatesProduction();
            var year = DateTime.Today.Year;
            dateTimePicker1.Value = DateTime.Parse($"{year},1,1");
        }

        private void DgvJoursEtCodeProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lvwIntrantMatierePremiere.Items.Clear();
                lvwIntrantProduitSemiFini.Items.Clear();
                lvwExtrantProduitFini.Items.Clear();
                lvwExtrantProduitSemiFini.Items.Clear();
                lvwRessourcesHumaines.Items.Clear();

                int codeProduction = int.Parse(dgvJoursEtCodeProduction.SelectedCells[0].Value.ToString());

                AfficherListeMatieresPremieresUtilisees(codeProduction);
                AfficherListeProduitsSemiFinisUtilises(codeProduction);
                AfficherListeProduitsFinis(codeProduction);
                AfficherListeProduitsSemiFinisProduits(codeProduction);
                AfficherListeDesEmployesAyantParticipeALaProduction(codeProduction);

            }
            catch (Exception)
            {
                MessageBox.Show("Merci de cliquer sur la colonne des codes de production", "Erreur de choix de colonne:");
            }
        }


        private void AfficherDatesProduction()
        {
            var listeProduction = (from prod in db.EveProductions
                                   where prod.Date >= dateTimePicker1.Value.Date
                                   where prod.Date <= dateTimePicker2.Value.Date
                                   select new
                                   {
                                       prod.Date,
                                       Code = prod.CodeProduction
                                   })
                                   .OrderBy(d => d.Date)
                                   .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(listeProduction);
            dgvJoursEtCodeProduction.DataSource = dt;
        }


        private void AfficherListeMatieresPremieresUtilisees(int codeProduction)
        {
            var matieresPremieres = (from p in db.EveProductions
                                     where p.CodeProduction == codeProduction
                                     join ur in db.EveUtilisationRessources on p.CodeUtilisationRessources equals ur.CodeUtilisationRessources
                                     join ump in db.EveUtilisationMatieresPremieres on ur.CodeUtilisationRessources equals ump.CodeUtilisationRessource
                                     select new
                                     {
                                         MatierePremiere = ump.ResStockMatieresPremiere.NomMatiere,
                                         Quantite = ump.QuantiteMatierePremiere
                                     }).ToList();

            foreach (var matiere in matieresPremieres)
            {
                ListViewItem item = new ListViewItem(matiere.MatierePremiere);
                item.SubItems.Add(matiere.Quantite.ToString());

                lvwIntrantMatierePremiere.Items.Add(item);
            }
                         
        }

        private void AfficherListeProduitsSemiFinisUtilises(int codeProduction)
        {
            var produitsSemiFinis = (from p in db.EveProductions
                                     where p.CodeProduction == codeProduction
                                     join ur in db.EveUtilisationRessources on p.CodeUtilisationRessources equals ur.CodeUtilisationRessources
                                     join upsf in db.EveUtilisationProduitsSemiFinis on ur.CodeUtilisationRessources equals upsf.CodeUtilisationRessource
                                     select new
                                     {
                                         MatierePremiere = upsf.ResStockProduitsSemiFini.Description,
                                         Quantite = upsf.QuantiteProduitSemiFini
                                     }).ToList();

            foreach (var produit in produitsSemiFinis)
            {
                ListViewItem item = new ListViewItem(produit.MatierePremiere);
                item.SubItems.Add(produit.Quantite.ToString());

                lvwIntrantProduitSemiFini.Items.Add(item);
            }
        }

        private void AfficherListeProduitsFinis(int codeProduction)
        {
            var produitsFinis = (from p in db.EveProductions
                                 where p.CodeProduction == codeProduction
                                 join ppf in db.EveProductionStockProduitsFinis on p.CodeProduction equals ppf.CodeProduction
                                 select new
                                 {
                                     ProduitFini = ppf.ResStockProduitsFini.NomProduit,
                                     Quantite = ppf.QuantiteProduitFini
                                 }).ToList();

            foreach (var produit in produitsFinis)
            {
                ListViewItem item = new ListViewItem(produit.ProduitFini);
                item.SubItems.Add(produit.Quantite.ToString());

                lvwExtrantProduitFini.Items.Add(item);
            }
        }

        private void AfficherListeProduitsSemiFinisProduits(int codeProduction)
        {
            var produitsSemiFinis = (from p in db.EveProductions
                                     where p.CodeProduction == codeProduction
                                     join ppsf in db.EveProductionProduitsSemiFinis on p.CodeProduction equals ppsf.CodeProduction
                                     select new
                                     {
                                         Produit = ppsf.ResStockProduitsSemiFini.Description,
                                         Quantite = ppsf.QuantiteProduitSemiFini
                                     }).ToList();

            foreach (var produit in produitsSemiFinis)
            {
                ListViewItem item = new ListViewItem(produit.Produit);
                item.SubItems.Add(produit.Quantite.ToString());

                lvwExtrantProduitSemiFini.Items.Add(item);
            }
        }

        private void AfficherListeDesEmployesAyantParticipeALaProduction(int codeProduction)
        {
            var employes = (from p in db.EveProductions
                                 where p.CodeProduction == codeProduction
                                 join emp in db.EvePresenceEmployes on p.CodeUtilisationRessources equals emp.CodeUtilisationDesRessources
                                 select new
                                 {
                                     Employe = emp.AgeEmploye.PrenomNom,
                                 })
                                 .OrderBy(e => e.Employe)
                                 .ToList();

            foreach (var employe in employes)
            {
                ListViewItem item = new ListViewItem(employe.Employe);

                lvwRessourcesHumaines.Items.Add(item);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AfficherDatesProduction();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AfficherDatesProduction();
        }
    }
}

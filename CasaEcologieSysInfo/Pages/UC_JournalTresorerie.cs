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
    public partial class UC_JournalTresorerie : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_JournalTresorerie()
        {
            InitializeComponent();
        }

        private void UC_JournalTresorerie_Load(object sender, EventArgs e)
        {

            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string nomCompte = listBox1.GetItemText(listBox1.SelectedItem);

            AfficherJournalCorrespondant(nomCompte);
        }

        private void AfficherJournalCorrespondant(string nomCompte)
        {
            var entrees = (from c in db.ResComptesTresoreries
                           where c.NomCompte == nomCompte
                           from en in db.EveEncaissements
                           from env in db.EveEncaissementsVentes
                           where en.CodeEncaissement == env.CodeEncaissement

                           select new
                           {
                               Date = env.DateEncaissement,
                               Entree = env.MontantEncaisse,
                               Sortie = 0m,
                               Solde = 0m
                         });

            var sorties = (from c in db.ResComptesTresoreries 
                           where c.NomCompte == nomCompte
                           from dec in db.EveDecaissements
                           where c.CodeCompte == dec.CodeCompte

                           select new
                           {
                               Date = dec.DateDecaissement,
                               Entree = 0m,
                               Sortie = dec.Montant,
                               Solde = 0m
                           });



            var resultats = entrees.Union(sorties)
                .OrderByDescending(d => d.Date)
                .ToList();

            var soldeInitial = (from c in db.ResComptesTresoreries
                                             where c.NomCompte == nomCompte
                                             select c.SoldeCompte).FirstOrDefault();
            txtSoldeInitial.Text = soldeInitial.ToString("c0");

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultats);
            adgvJournalTresorerieDetails.DataSource = dt;

            dt.Rows.Add(DateTime.Now, Conversion.CalculerTotal(0, adgvJournalTresorerieDetails, "Entree"), 
                Conversion.CalculerTotal(0, adgvJournalTresorerieDetails, "Sortie"), 
                Conversion.CalculerTotal(0, adgvJournalTresorerieDetails, "Solde"));

            adgvJournalTresorerieDetails.Columns["Entree"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Sortie"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Solde"].DefaultCellStyle.Format = "c0";
        }
    }
}


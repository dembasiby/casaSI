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
                               Solde = (from ce in db.ResComptesTresoreries
                                     where ce.CodeCompte == c.CodeCompte
                                     select ce.SoldeCompte).FirstOrDefault() 
                                     + env.MontantEncaisse
                                     - (from ce in db.ResComptesTresoreries
                                        where ce.CodeCompte == c.CodeCompte
                                        from d in db.EveDecaissements
                                        where ce.CodeCompte == d.CodeCompte
                                       
                                        select d).Sum(d => (decimal?) d.Montant) ?? 0m
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
                               Solde = (from ce in db.ResComptesTresoreries
                                    where ce.CodeCompte == c.CodeCompte
                                    select ce.SoldeCompte).FirstOrDefault() - dec.Montant + 
                                    (from ce in db.ResComptesTresoreries
                                        where ce.CodeCompte == c.CodeCompte
                                        from en in db.EveEncaissements
                                        from env in db.EveEncaissementsVentes
                                        where en.CodeEncaissement == env.CodeEncaissement

                                        select env).Sum(n => (decimal?) n.MontantEncaisse) ?? 0m
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
            
            adgvJournalTresorerieDetails.Columns["Entree"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Sortie"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Solde"].DefaultCellStyle.Format = "c0";
        }
    }
}


/*
 * 
 *  //where (new DateTime(d.DateDecaissement.Year, d.DateDecaissement.Month, d.DateDecaissement.Day) <= new DateTime(env.DateEncaissement.Year, env.DateEncaissement.Month, env.DateEncaissement.Day))
 *  
 *  
 *  
 *  
 *  //where (new DateTime(env.DateEncaissement.Year, env.DateEncaissement.Month, env.DateEncaissement.Day) <= new DateTime(dec.DateDecaissement.Year, dec.DateDecaissement.Month, dec.DateDecaissement.Day))  //env.DateEncaissement <= dec.DateDecaissement
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_JournalTresorerie : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();
        string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CasaDB;Integrated Security=True";


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
            string query = "SELECT EveEncaissementsVentes.DateEncaissement AS Date,'Vente de ' + ResStockProduitsFinis.NomProduit as Description, EveEncaissementsVentes.MontantEncaisse as Entree, '' as 'Sortie' FROM ResStockProduitsFinis INNER JOIN  EveVenteStockProduitsFinis ON ResStockProduitsFinis.CodeProduit = EveVenteStockProduitsFinis.CodeProduitFini INNER JOIN EveEncaissementsVentes ON EveEncaissementsVentes.CodeVente = EveVenteStockProduitsFinis.CodeVente INNER JOIN EveEncaissements ON EveEncaissements.CodeEncaissement = EveEncaissementsVentes.CodeEncaissement INNER JOIN ResComptesTresorerie ON ResComptesTresorerie.CodeCompte = EveEncaissements.CodeCompte WHERE ResComptesTresorerie.NomCompte = '" + nomCompte + "' UNION ALL(SELECT EveDecaissements.DateDecaissement as Date, EveDecaissements.Description as Description,'' as Entree, EveDecaissements.Montant as Sortie FROM EveDecaissements INNER JOIN ResComptesTresorerie ON EveDecaissements.CodeCompte = ResComptesTresorerie.CodeCompte WHERE ResComptesTresorerie.NomCompte = '" + nomCompte +"')";


            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand selectCommand = new SqlCommand(query, con);
            SqlDataAdapter soldeDataSdapter = new SqlDataAdapter(selectCommand);


            var soldeInitial = (from c in db.ResComptesTresoreries
                                             where c.NomCompte == nomCompte
                                             select c.SoldeCompte).FirstOrDefault();


            DataTable dt = new DataTable();
            soldeDataSdapter.Fill(dt);

            DataColumn dc = new DataColumn("Solde", typeof(int));
            dt.Columns.Add(dc);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Report";

            adgvJournalTresorerieDetails.DataSource = dt;


            for (int i = 0; i < adgvJournalTresorerieDetails.Rows.Count; i++)
            {

                if (i > 0)
                {
                    adgvJournalTresorerieDetails.Rows[i].Cells[4].Value = Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i - 1].Cells[4].Value)
                    + Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
                }
                else
                {
                    adgvJournalTresorerieDetails.Rows[i].Cells[4].Value = soldeInitial + Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
                }

            }

            adgvJournalTresorerieDetails.Columns["Entree"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Sortie"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Solde"].DefaultCellStyle.Format = "c0";
        }
    }
}


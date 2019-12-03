using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_CreancesClients : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_CreancesClients()
        {
            InitializeComponent();
        }

        private void UC_CreancesClients_Load(object sender, EventArgs e)
        {
            lbxListeClients.DataSource = db.AgeClients.OrderBy(c => c.NomClient).ToList();
            lbxListeClients.DisplayMember = "NomClient";
            lbxListeClients.ValueMember = "CodeClient";

            txtTotalCreances.Text = Conversion.CalculerTotalCreancesClients().ToString("c0");
        }


        private void MontrerDetailsCreances(int codeClient)
        {
            var ventesClients = (from c in db.AgeClients
                                 from vf in db.EveVenteStockProduitsFinis
                                 from v in db.EveVentes
                                 where v.CodeClient == c.CodeClient
                                 where vf.CodeVente == v.CodeVente
                                 where c.CodeClient == codeClient
                                 select new
                                 {
                                     Date = v.DateVente,
                                     Description = vf.ResStockProduitsFini.NomProduit,
                                     vf.Montant,
                                     Encaissement = 0m,
                                     Solde = 0m
                                 });

            var totalPaiementClient = (from c in db.AgeClients
                                       from e in db.EveEncaissementsVentes
                                       where c.CodeClient == e.CodeClient
                                       where c.CodeClient == codeClient
                                       select new
                                       {
                                           Date = e.DateEncaissement,
                                           Description = "Encaissement vente",
                                           Montant = 0m,
                                           Encaissement = e.MontantEncaisse,
                                           Solde = 0m
                                       });

            var encaissementCreances = (from c in db.AgeClients
                                        from ec in db.EveEncaissementsCreances
                                        where c.CodeClient == ec.CodeClient
                                        where c.CodeClient == codeClient
                                        select new
                                        {
                                            Date = ec.DateEncaissement,
                                            Description = "Encaissement créance",
                                            Montant = 0m,
                                            Encaissement = ec.MontantEncaisse,
                                            Solde = 0m
                                        });

            var combinedQuery = ventesClients.Union(totalPaiementClient).Union(encaissementCreances)
                .OrderByDescending(c => c.Solde)
                .ToList();
            DataTable dt = Conversion.ConvertirEnTableDeDonnees(combinedQuery);

            DataRow dr = dt.NewRow();
           dt.Rows.InsertAt(dr, 0);
           dr["Montant"] = 0;
           dr["Encaissement"] = 0;
            dgvDetailsClient.DataSource = dt;

            dgvDetailsClient.Columns["Montant"].DefaultCellStyle.Format = "n0";
            dgvDetailsClient.Columns["Encaissement"].DefaultCellStyle.Format = "n0";
            dgvDetailsClient.Columns["Solde"].DefaultCellStyle.Format = "n0";
            dgvDetailsClient.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetailsClient.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetailsClient.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            var creanceInitialClient = (from c in db.AgeClients
                                        where c.CodeClient == codeClient
                                        select c.SoldeInitialeCreance).FirstOrDefault();

            for (int i = 0; i < dgvDetailsClient.Rows.Count; i++)
            {

                if (i > 0)
                {
                    dgvDetailsClient.Rows[i].Cells[4].Value = Convert.ToInt32(dgvDetailsClient.Rows[i - 1].Cells[4].Value)
                    + Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[3].Value);
                }
                else
                {
                    dgvDetailsClient.Rows[i].Cells[4].Value = creanceInitialClient + Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[3].Value);
                }

            }

        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lbxListeClients.ValueMember = "CodeClient";
            int codeClient = 0;

            if (lbxListeClients.Items.Count > 0)
            {
                codeClient = Convert.ToInt32(lbxListeClients.SelectedValue.ToString());
                MontrerDetailsCreances(codeClient);
            }
            else
            {
                MessageBox.Show("Il n'y a pas encore de clients dans la base de données.");
            }     
        }

        private void BtnImprimerTableau_Click(object sender, EventArgs e)
        {
            Impression.ImprimerDetailsTransactionsClient(lbxListeClients, dgvDetailsClient);
        }
    }
}

using System;
using System.Collections.Generic;
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
            var listeClients = new List<AgeClient>();        
            var newListe = db.AgeClients.ToList();

            foreach (var client in newListe)
            {
                var soldeCreanceClient = Tresorerie.CalculerSoldeCreanceClient(client.CodeClient);

                if (soldeCreanceClient > 0)
                {
                    listeClients.Add(client);
                }
            }

            lbxListeClients.DataSource = listeClients.OrderBy(c => c.NomClient).ToList();
            lbxListeClients.DisplayMember = "NomClient";
            lbxListeClients.ValueMember = "CodeClient";

            txtTotalCreances.Text = Tresorerie.CalculerTotalCreancesClients().ToString("c0");
        }


        private void MontrerDetailsCreances(int codeClient)
        {
            var ventesClients = (from c in db.AgeClients
                                 join v in db.EveVentes on c.CodeClient equals v.CodeClient
                                 join vpf in db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                                 where c.CodeClient == codeClient
                                 select new
                                 {
                                     Date = v.DateVente,
                                     Description = vpf.ResStockProduitsFini.NomProduit,
                                     vpf.Montant,
                                     Encaissement = 0m,
                                     Solde = 0m
                                 });

            var totalPaiementClient = (from c in db.AgeClients
                                      join ev in db.EveEncaissementsVentes on c.CodeClient equals ev.CodeClient
                                      where c.CodeClient == codeClient
                                      select new
                                       {
                                           Date = ev.DateEncaissement,
                                           Description = "Encaissement vente",
                                           Montant = 0m,
                                           Encaissement = ev.MontantEncaisse,
                                           Solde = 0m
                                       });

            var encaissementCreances = (from c in db.AgeClients
                                        join ecc in db.EveEncaissementsCreances on c.CodeClient equals ecc.CodeClient
                                        where c.CodeClient == codeClient
                                        select new
                                        {
                                            Date = ecc.DateEncaissement,
                                            Description = "Encaissement créance",
                                            Montant = 0m,
                                            Encaissement = ecc.MontantEncaisse,
                                            Solde = 0m
                                        });

            var combinedQuery = ventesClients
                                .Concat(totalPaiementClient)
                                .Concat(encaissementCreances)
                                .OrderByDescending(c => c.Date)
                                //.Where(c => c.Solde > 0)
                                .ToList();
            DataTable dt = Conversion.ConvertirEnTableDeDonnees(combinedQuery);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);
            dr["Montant"] = 0;
            dr["Encaissement"] = 0;
            dr["Description"] = "Montant créance initiale";
            dgvDetailsClient.DataSource = dt;

            dgvDetailsClient.Columns["Montant"].DefaultCellStyle.Format = "n0";
            dgvDetailsClient.Columns["Encaissement"].DefaultCellStyle.Format = "n0";
            dgvDetailsClient.Columns["Solde"].DefaultCellStyle.Format = "n0";
            dgvDetailsClient.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetailsClient.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetailsClient.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetailsClient.Columns["Description"].FillWeight = 250;


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
            try
            {
                bool listeValide = lbxListeClients.Items.Count > 0;
                int.TryParse(lbxListeClients.SelectedValue.ToString(), out int codeClient);
                MontrerDetailsCreances(codeClient);

                lblNomClient.Text = db.AgeClients
                                .Where(c => c.CodeClient == codeClient)
                                .Select(c => c.NomClient)
                                .FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Il n'y a pas de clients avec créances en ce moment.");
            }

        }

        private void BtnImprimerTableau_Click(object sender, EventArgs e)
        {
            Impression.ImprimerDetailsTransactionsClient(lbxListeClients, dgvDetailsClient);
        }
    }
}

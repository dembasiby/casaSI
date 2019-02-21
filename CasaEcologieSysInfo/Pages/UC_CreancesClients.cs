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
    public partial class UC_CreancesClients : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_CreancesClients()
        {
            InitializeComponent();
        }

        private void UC_CreancesClients_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = db.AgeClients.OrderBy(c => c.NomClient).ToList();
            listBox1.DisplayMember = "NomClient";
            listBox1.ValueMember = "CodeClient";

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
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["Montant"].DefaultCellStyle.Format = "c0";
            dataGridView1.Columns["Encaissement"].DefaultCellStyle.Format = "c0";
            dataGridView1.Columns["Solde"].DefaultCellStyle.Format = "c0";


            var creanceInitialClient = (from c in db.AgeClients
                                        where c.CodeClient == codeClient
                                        select c.SoldeInitialeCreance).FirstOrDefault();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (i > 0)
                {
                    dataGridView1.Rows[i].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[4].Value)
                    + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Value = creanceInitialClient + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }

            }

        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int codeClient = Convert.ToInt32(listBox1.SelectedValue);
            MontrerDetailsCreances(codeClient);
        }
    }
}

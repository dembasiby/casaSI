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

namespace CasaEcologieSysInfo
{
    public partial class UC_JournalVentes : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        //Double Tot = 0;

        public UC_JournalVentes()
        {
            InitializeComponent();
        }

        private void UC_JournalVentes_Load(object sender, EventArgs e)
        {
            var ventes = (from v in db.EveVentes
                          join vpf in db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                          join pf in db.ResStockProduitsFinis on vpf.CodeProduitFini equals pf.CodeProduit
                          join c in db.AgeClients on v.CodeClient equals c.CodeClient

                          select new
                          {
                              Date = v.DateVente,
                              Description = pf.NomProduit,
                              Quantité = vpf.QuantiteProduitFini,
                              Client = c.NomClient,
                              vpf.Montant
                          }).ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(ventes);

            dgvJournalVentes.DataSource = dt;
            dt.Rows.Add(DateTime.Now, "Total", 0, "", Conversion.CalculerTotal(dgvJournalVentes, "Montant"));

            dgvJournalVentes.Columns["Montant"].DefaultCellStyle.Format = "n0";
            dgvJournalVentes.Columns["Montant"].HeaderText = "Montant(FCFA)";
            dgvJournalVentes.Columns["Quantité"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJournalVentes.Columns["Montant"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvJournalVentes.Columns["Quantité"].HeaderText = "Quantité(unités)";
           

        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {

        }
    }
}

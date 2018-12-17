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
                              Quantité = vpf.QuantiteProduitFini + " unités",
                              Client = c.NomClient,
                              vpf.Montant
                          }).ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(ventes);

            adgvJournalVentes.DataSource = dt;
            dt.Rows.Add(DateTime.Now, "Total", "", "", CalculerTotal(0));

            adgvJournalVentes.Columns["Montant"].DefaultCellStyle.Format = "c0";
            adgvJournalVentes.Rows[adgvJournalVentes.Rows.Count - 1].ReadOnly = true;
        }

        private void AdgvJournalVentes_FilterStringChanged(object sender, EventArgs e)
        {
            Conversion.FiltrerTableau(sender, e);
            adgvJournalVentes.Rows[adgvJournalVentes.Rows.Count - 1].Cells["Montant"].Value = CalculerTotal(1);
        }

        private void AdgvJournalVentes_SortStringChanged(object sender, EventArgs e)
        {
            Conversion.TrierTableau(sender, e);
        }


        private Double CalculerTotal(int n)
        {
            Double Tot = 0;

            for (int i = 0; i < adgvJournalVentes.Rows.Count - n; i++)
            {
                double V;
                if (adgvJournalVentes.Rows[i].Visible)
                {
                    V = string.IsNullOrEmpty(adgvJournalVentes.Rows[i].Cells["Montant"].Value.ToString()) ? 0 : Convert.ToDouble(adgvJournalVentes.Rows[i].Cells["Montant"].Value.ToString().Replace("F CFA", "").Trim());
                }
                else
                {
                    V = 0;
                }
                
                Tot += V;          
            }

            return Tot;
        }
    }
}

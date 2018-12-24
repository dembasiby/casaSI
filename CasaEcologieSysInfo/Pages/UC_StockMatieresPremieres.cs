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
    public partial class UC_StockMatieresPremieres : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();
        string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CasaDB;Integrated Security=True";

        public UC_StockMatieresPremieres()
        {
            InitializeComponent();
        }

        private void UC_StockMatieresPremieres_Load(object sender, EventArgs e)
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.ToList();
            string nomCompte = listBox1.GetItemText(listBox1.SelectedItem);

            AfficherJournalCorrespondant(nomCompte);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomCompte = listBox1.GetItemText(listBox1.SelectedItem);

            AfficherJournalCorrespondant(nomCompte);
        }

        private void AfficherJournalCorrespondant(string nomMatiere)
        {

            string query = "SELECT EveReceptionMatieresPremieres.DateReception as Date, 'Achat de ' + ResStockMatieresPremieres.NomMatiere as Description,  EveReceptionMatieresPremieres.Quantite as Entree, ' ' as Sortie FROM ResStockMatieresPremieres INNER JOIN EveReceptionMatieresPremieres ON ResStockMatieresPremieres.CodeMatierePremiere = EveReceptionMatieresPremieres.CodeMatierePremiere WHERE ResStockMatieresPremieres.NomMatiere = '" + nomMatiere + "' UNION All(SELECT EveProductions.Date as Date, 'Utilisation de ' + ResStockMatieresPremieres.NomMatiere as Description, '' as Entree, EveUtilisationMatieresPremieres.QuantiteMatierePremiere as Sortie FROM ResStockMatieresPremieres INNER JOIN EveUtilisationMatieresPremieres ON ResStockMatieresPremieres.CodeMatierePremiere = EveUtilisationMatieresPremieres.CodeMatierePremiere INNER JOIN EveUtilisationRessources ON EveUtilisationMatieresPremieres.CodeUtilisationRessource = EveUtilisationRessources.CodeUtilisationRessources INNER JOIN EveProductions ON EveUtilisationRessources.CodeUtilisationRessources = EveProductions.CodeUtilisationRessources where ResStockMatieresPremieres.NomMatiere = '" + nomMatiere +"')";

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand selectCommand = new SqlCommand(query, con);
            SqlDataAdapter stockDataSdapter = new SqlDataAdapter(selectCommand);
            
            var stockInitial = (from mp in db.ResStockMatieresPremieres
                                where mp.NomMatiere == nomMatiere
                                select mp.StockMatiere).FirstOrDefault();
         

            DataTable dt = new DataTable();
            stockDataSdapter.Fill(dt);

            DataColumn dc = new DataColumn("Solde", typeof(int));
            dt.Columns.Add(dc);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Report";
            
            dgvJournalStockMatPrem.DataSource = dt;

            for (int i = 0; i < dgvJournalStockMatPrem.Rows.Count; i++)
            {

                if (i > 0)
                {
                    dgvJournalStockMatPrem.Rows[i].Cells[4].Value = Convert.ToInt32(dgvJournalStockMatPrem.Rows[i-1].Cells[4].Value) 
                    + Convert.ToInt32(dgvJournalStockMatPrem.Rows[i].Cells[2].Value) 
                    - Convert.ToInt32(dgvJournalStockMatPrem.Rows[i].Cells[3].Value);
                }
                else
                {
                    dgvJournalStockMatPrem.Rows[i].Cells[4].Value = stockInitial + Convert.ToInt32(dgvJournalStockMatPrem.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvJournalStockMatPrem.Rows[i].Cells[3].Value);
                }
                
            }
        }
    }
}

 
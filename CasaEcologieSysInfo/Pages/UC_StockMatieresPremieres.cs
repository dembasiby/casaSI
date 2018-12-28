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
        //string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=CasaDB;Integrated Security=True";

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

            //string query = "SELECT EveReceptionMatieresPremieres.DateReception as Date, 'Achat de ' + ResStockMatieresPremieres.NomMatiere as Description,  EveReceptionMatieresPremieres.Quantite as Entree, ' ' as Sortie FROM ResStockMatieresPremieres INNER JOIN EveReceptionMatieresPremieres ON ResStockMatieresPremieres.CodeMatierePremiere = EveReceptionMatieresPremieres.CodeMatierePremiere WHERE ResStockMatieresPremieres.NomMatiere = '" + nomMatiere + "' ORDER BY UNION All(SELECT EveProductions.Date as Date, 'Utilisation de ' + ResStockMatieresPremieres.NomMatiere as Description, '' as Entree, EveUtilisationMatieresPremieres.QuantiteMatierePremiere as Sortie FROM ResStockMatieresPremieres INNER JOIN EveUtilisationMatieresPremieres ON ResStockMatieresPremieres.CodeMatierePremiere = EveUtilisationMatieresPremieres.CodeMatierePremiere INNER JOIN EveUtilisationRessources ON EveUtilisationMatieresPremieres.CodeUtilisationRessource = EveUtilisationRessources.CodeUtilisationRessources INNER JOIN EveProductions ON EveUtilisationRessources.CodeUtilisationRessources = EveProductions.CodeUtilisationRessources where ResStockMatieresPremieres.NomMatiere = '" + nomMatiere +"')";

            var entrees = (from mp in db.ResStockMatieresPremieres
                           join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                           where mp.NomMatiere == nomMatiere
                           select new
                           {
                               Date = rmp.DateReception,
                               Description = "Achat de " + mp.NomMatiere,
                               Entree = rmp.Quantite,
                               Sortie = 0,
                               Solde = 0
                           });

            var sorties = (from mp in db.ResStockMatieresPremieres
                           join ump in db.EveUtilisationMatieresPremieres on mp.CodeMatierePremiere equals ump.CodeMatierePremiere
                           join ur in db.EveUtilisationRessources on ump.CodeUtilisationRessource equals ur.CodeUtilisationRessources
                           join p in db.EveProductions on ur.CodeUtilisationRessources equals p.CodeUtilisationRessources
                           where mp.NomMatiere == nomMatiere
                           select new
                           {
                               p.Date,
                               Description = "Utilisation de " + mp.NomMatiere,
                               Entree = 0,
                               Sortie = ump.QuantiteMatierePremiere,
                               Solde = 0
                           });

            var resultats = entrees.Union(sorties)
                .OrderByDescending(d => d.Date)
                .ToList();
            /*
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand selectCommand = new SqlCommand(query, con);
            SqlDataAdapter stockDataSdapter = new SqlDataAdapter(selectCommand);
            */
            var stockInitial = (from mp in db.ResStockMatieresPremieres
                                where mp.NomMatiere == nomMatiere
                                select mp.StockMatiere).FirstOrDefault();

            /*
            DataTable dt = new DataTable();
            stockDataSdapter.Fill(dt);

            DataColumn dc = new DataColumn("Solde", typeof(int));
            dt.Columns.Add(dc);
            */
            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultats);
            
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, dt.Rows.Count);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Stock Initial";
            
            adgvJournalStocksMatieresPremieres.DataSource = dt;

            Conversion.CalculerSoldeStocksDeFaconProgressive(adgvJournalStocksMatieresPremieres, stockInitial);


            /*
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
            */
        }
    }
}

 
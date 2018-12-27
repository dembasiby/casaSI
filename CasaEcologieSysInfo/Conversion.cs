using ADGV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class Conversion
    {

        // Conversion d'une liste en tableau de données
        public static DataTable ConvertirEnTableDeDonnees<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }

        // Filtre des tableaux AdvancedDataGridView
        public static void FiltrerTableau(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.RowFilter = myDataGrid.FilterString;
        }

        public static void TrierTableau(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.Sort = myDataGrid.SortString;
        }

        // Calcul du total dans les tableaux
        public static Double CalculerTotal(int n, AdvancedDataGridView dataGrid, string columnName)
        {
            Double Tot = 0;

            for (int i = 0; i < dataGrid.Rows.Count - n; i++)
            {
                double V;
                if (dataGrid.Rows[i].Visible)
                {
                    V = string.IsNullOrEmpty(dataGrid.Rows[i].Cells[columnName].Value.ToString()) ? 0 
                        : Convert.ToDouble(dataGrid.Rows[i].Cells[columnName].Value.ToString().Replace("F CFA", "").Trim());
                }
                else
                {
                    V = 0;
                }

                Tot += V;
            }

            return Tot;
        }

        public static decimal CalculerTotalCreancesClients()
        {
            using (CasaDBEntities2 db = new CasaDBEntities2())
            {
                var ventesClients = (from c in db.AgeClients
                                     from vf in db.EveVenteStockProduitsFinis
                                     from v in db.EveVentes
                                     where v.CodeClient == c.CodeClient
                                     where vf.CodeVente == v.CodeVente
                                     select (decimal?)vf.Montant).Sum() ?? 0m;

                var totalPaiementClient = (from c in db.AgeClients
                                           from e in db.EveEncaissements
                                           where c.CodeClient == e.CodeClient
                                           from ev in db.EveEncaissementsVentes
                                           where ev.CodeEncaissement == e.CodeEncaissement
                                           select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;



                var creanceInitialClient = (from c in db.AgeClients
                                            select (decimal?)c.SoldeInitialeCreance).Sum() ?? 0m;

                return creanceInitialClient + ventesClients - totalPaiementClient;
            }

           
        }

    }
}

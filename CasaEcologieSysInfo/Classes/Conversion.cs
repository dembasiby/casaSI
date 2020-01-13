using ADGV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class Conversion
    {
        public static void AjouterNumeroVersion(Label lbl)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo infoVersion = FileVersionInfo.GetVersionInfo(assembly.Location);

            lbl.Text += $" v.{infoVersion.FileVersion } - Conception: Demba Siby (+221) 77 562 72 95";
        }

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

        public static Double CalculerTotal(DataGridView dataGrid, string columnName)
        {
            Double Tot = 0;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                Tot += Convert.ToDouble(dataGrid.Rows[i].Cells[columnName].Value);

            }

            return Tot;
        }

        public static String EnleverEspaces(String str)
        {
            str = str.Replace(" ", "");
            return str;
        }
    }
}

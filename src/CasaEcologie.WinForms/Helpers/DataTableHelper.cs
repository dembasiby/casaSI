using System.ComponentModel;
using System.Data;

namespace CasaEcologie.WinForms.Helpers;

public static class DataTableHelper
{
    public static DataTable ConvertirEnTableDeDonnees<T>(IList<T> data)
    {
        var properties = TypeDescriptor.GetProperties(typeof(T));
        var table = new DataTable();

        foreach (PropertyDescriptor prop in properties)
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

        foreach (T item in data)
        {
            var row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            table.Rows.Add(row);
        }

        return table;
    }

    public static double CalculerTotal(DataGridView dataGrid, string columnName)
    {
        double total = 0;
        for (int i = 0; i < dataGrid.Rows.Count; i++)
        {
            total += Convert.ToDouble(dataGrid.Rows[i].Cells[columnName].Value);
        }
        return total;
    }
}

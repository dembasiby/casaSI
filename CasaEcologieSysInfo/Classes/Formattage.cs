using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class Formattage
    {
        public static void TableauDesStock(DataGridView grid)
        {
            grid.Columns["Date"].Width = 100;
            grid.Columns["Description"].Width = 100;
            grid.Columns["Entree"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Sortie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Solde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["PU"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Valeur"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns["PU"].DefaultCellStyle.Format = "n0";
            grid.Columns["Valeur"].DefaultCellStyle.Format = "n0";
        }

        public static void ChangerTitreTableauDesStocks(DataGridView grid, string unite)
        {
            grid.Columns["Entree"].HeaderText = $"Entrée ({unite})";
            grid.Columns["Sortie"].HeaderText = $"Sortie ({unite})";
            grid.Columns["Solde"].HeaderText = $"Solde ({unite})";

        }

        public static void RegistreImmobilisations(DataGridView grid)
        {
            grid.Columns["Quantite"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns["DateAcquisition"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns["DureeDeVie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns["AmortissementMensuel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["AmortissementTrimestriel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["AmortissementAnnuel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["ValeurDOrigine"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["AmortissementMensuel"].DefaultCellStyle.Format = "n0";
            grid.Columns["AmortissementTrimestriel"].DefaultCellStyle.Format = "n0";
            grid.Columns["AmortissementAnnuel"].DefaultCellStyle.Format = "n0";
            grid.Columns["ValeurDOrigine"].DefaultCellStyle.Format = "n0";
        }

        public static void FormatterLigneEnGras(DataGridView grid, int cellIndex)
        {
            grid.Rows[cellIndex].DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Tahoma", 9.75F, FontStyle.Bold),
                ForeColor = Color.Black,
                //BackColor = Color.GreenYellow
            };
        }
    }
}

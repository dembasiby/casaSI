using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Bilan
    {
        public static void AfficherBilan(DataGridView grid, DateTimePicker debut, DateTimePicker fin)
        {
            DateTime deb = debut.Value.Date;
            DateTime fn = fin.Value.Date;
            Single totalActifCirculant = float.Parse(Tresorerie.CalculerSoldeInitialTresorerie(fn.AddDays(1)))
                + Conversion.CalculerTotalCreancesClientsALaDateDu(fn)
                + GestionStocks.ValeurTotalDesStocks(fn);

            grid.Rows.Add("Trésorerie disponible en fin de période", Tresorerie.CalculerSoldeInitialTresorerie(fn.AddDays(1))); // 0
            grid.Rows.Add("Débiteurs divers", Conversion.CalculerTotalCreancesClientsALaDateDu(fn)); // 1
            grid.Rows.Add("Stocks", GestionStocks.ValeurTotalDesStocks(fn).ToString("n0")); // 2
            grid.Rows.Add("Total Actif Circulant", totalActifCirculant.ToString("n0")); // 3
            grid.Rows.Add("Immobilisations brutes", 0); // 4
            grid.Rows.Add("Amortissements cumulés", 0); // 5
            grid.Rows.Add("Immobilisations nettes", 0); // 6
            grid.Rows.Add("TOTAL ACTIF", 0); // 7

            grid.Rows.Add("Créditeurs divers", Conversion.CalculerTotalDettesFournisseursALaDateDu(fn).ToString("n0")); // 8
            grid.Rows.Add("Autres dettes à Court Terme", 0); // 9
            grid.Rows.Add("Total dettes à Court Terme", 0); // 10
            grid.Rows.Add("Emprunts et autres dettes à Long Terme", 0); // 11
            grid.Rows.Add("Total Dettes", 0); // 12
            grid.Rows.Add("Capitaux propres (Capitaux et Subventions)", 0); // 13
            grid.Rows.Add("Bénéfices Non Répartis", 0); // 14
            grid.Rows.Add("Bénéfices Répartis", 0); // 15
            grid.Rows.Add("Total Capitaux Propres", 0); // 16
            grid.Rows.Add("TOTAL PASSIF ET CAPITAL", 0); // 17
            grid.Rows.Add("Valeur nette", 0); // 18

            // 
            Formattage.FormatterLigneEnGras(grid, 3);

            // 
            Formattage.FormatterLigneEnGras(grid, 7);

            // 
            Formattage.FormatterLigneEnGras(grid, 10);

            // 
            Formattage.FormatterLigneEnGras(grid, 12);

            // 
            Formattage.FormatterLigneEnGras(grid, 16);

            // 
            Formattage.FormatterLigneEnGras(grid, 17);

            // 
            Formattage.FormatterLigneEnGras(grid, 18);
        }
    }
}

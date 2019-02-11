using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class CompteDeResultat
    {
        private static string CalculerVentesMois(int NumMois, DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return ((from v in db.EveVentes
                         join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                         where v.DateVente.Year == date.Year
                         where v.DateVente.Month == NumMois
                         select (decimal?)vp.Montant).Sum() ?? 0m).ToString("n0");
            }
        }

        public static void AfficherVentesMensuelles(DataGridView grid, DateTimePicker date)
        {
            grid.Rows.Add("Chiffre d'affaires",
                CalculerVentesMois(1, date.Value.Date),
                CalculerVentesMois(2, date.Value.Date),
                CalculerVentesMois(3, date.Value.Date),
                CalculerVentesMois(4, date.Value.Date),
                CalculerVentesMois(5, date.Value.Date),
                CalculerVentesMois(6, date.Value.Date),
                CalculerVentesMois(7, date.Value.Date),
                CalculerVentesMois(8, date.Value.Date),
                CalculerVentesMois(9, date.Value.Date),
                CalculerVentesMois(10, date.Value.Date),
                CalculerVentesMois(11, date.Value.Date),
                CalculerVentesMois(12, date.Value.Date));
        }

        public static void AfficherMargeBrute(DataGridView grid)
        {
            
            grid.Rows.Add("Marge brute",
                (Convert.ToSingle(grid.Rows[0].Cells[1].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[1].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[2].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[2].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[3].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[3].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[4].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[4].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[5].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[5].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[6].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[6].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[7].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[7].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[8].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[8].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[9].Value.ToString()) - Convert.ToSingle(grid.Rows[1].Cells[9].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[10].Value.ToString())- Convert.ToSingle(grid.Rows[1].Cells[10].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[11].Value.ToString())- Convert.ToSingle(grid.Rows[1].Cells[11].Value.ToString())).ToString("n0"),
                (Convert.ToSingle(grid.Rows[0].Cells[12].Value.ToString())- Convert.ToSingle(grid.Rows[1].Cells[12].Value.ToString())).ToString("n0")
                );
        }

        public static float CoutDirectMainDOeuvre(int numMois, DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                DateTime debut = new DateTime(date.Year, numMois, 1);
                DateTime fin = new DateTime(date.Year, numMois, DateTime.DaysInMonth(date.Year, numMois));

                return (from rem in db.EvePresenceEmployes
                        where rem.Date >= debut.Date
                        where rem.Date <= fin.Date
                        select (float?)rem.RemunerationJournaliere).Sum() ?? 0f; 
            }
        }

        public static decimal AmortissementsMensuels(DateTime date, int numMois)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return (from inE in db.ResEquipementsInfrastructures
                        where inE.DateAcquisition.Year + inE.DureeDeVie >= date.Year
                        //where inE.DateAcquisition.Month <= date.Month
                        where inE.MaterielDeProduction == true
                        select new
                        {
                            Immobilisation = inE.Nom,
                            inE.Quantite,
                            ValeurDOrigine = inE.Montant,
                            inE.DateAcquisition,
                            inE.DureeDeVie,
                            AmortissementMensuel = inE.Montant / (inE.DureeDeVie * 12),
                            AmortissementAnnuel = inE.Montant / inE.DureeDeVie
                        })
                        .Select(a => (decimal?)a.AmortissementMensuel)
                        .Sum() ?? 0m; 
            }
        }

    }
}

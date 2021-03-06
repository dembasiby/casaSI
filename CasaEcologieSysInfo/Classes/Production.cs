﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Production
    {
        public static void AfficherDatesProduction(DateTimePicker debut, DateTimePicker fin, DataGridView grid)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var listeProduction = (from prod in db.EveProductions
                                       where prod.Date >= debut.Value.Date
                                       where prod.Date <= fin.Value.Date
                                       select new
                                       {
                                           prod.Date,
                                           Code = prod.CodeProduction
                                       })
                                   .OrderBy(d => d.Date)
                                   .ToList();

                DataTable dt = Conversion.ConvertirEnTableDeDonnees(listeProduction);
                grid.DataSource = dt;
            }
        }

        public static void ActiverListeEtiquettes(ComboBox listeProduits, ComboBox listeEtiquettes)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                string nomProduit = listeProduits.GetItemText(listeProduits.SelectedItem);

                if (nomProduit.ToLower().StartsWith("sachet") || nomProduit.ToLower().StartsWith("pastille"))
                {
                    listeEtiquettes.Enabled = false;
                }
                else
                {
                    listeEtiquettes.Enabled = true;
                } 
            }
        }
    }
}

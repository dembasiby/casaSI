using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CasaEcologieSysInfo
{
    class Validation
    {
        public static bool VerifierChampsMontant(string nomChamps)
        {
            if (string.IsNullOrEmpty(nomChamps))
            {
                MessageBox.Show("Ce champs doit être renseigné.");
                return false;
            }

            try
            {
                int temp = Convert.ToInt32(nomChamps);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce champs doit contenir uniquement des nombres.");
                return false;
            }

            return true;
        }
    }
}

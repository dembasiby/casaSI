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

        public static bool MontantEstValide(string montant)
        {
            var estUnChiffre = int.TryParse(montant, out int n);

            if (string.IsNullOrEmpty(montant))
            {
                MessageBox.Show("Le champ 'Montant reçu' doit être renseigné.");
                return false;
            }
            else if (!estUnChiffre)
            {
                MessageBox.Show("Le champ 'Montant reçu' doit contenir uniquement des chiffres.");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool QuantiteSuperieurAZero(string quantite)
        {
            if (MontantEstValide(quantite) && int.Parse(quantite) > 0)
            {
                return true;
            }

            return false;
        }
    }
}

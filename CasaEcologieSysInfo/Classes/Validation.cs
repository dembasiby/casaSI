using System;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;


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

        public static bool EstUnChiffre(string nombre)
        {
            return int.TryParse(nombre, out int n);
        }

        public static bool ChampsVide(string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool MontantEstValide(string montant)
        {
            var estUnChiffre = float.TryParse(montant, out float n);

            if (string.IsNullOrEmpty(montant))
            {
                MessageBox.Show("Ce champ doit être renseigné.");
                return false;
            }
            else if (!estUnChiffre)
            {
                MessageBox.Show("Ce champ doit contenir uniquement des chiffres.");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool QuantiteSuperieurAZero(string quantite)
        {
            if (MontantEstValide(quantite) && float.Parse(quantite) > 0)
            {
                return true;
            }

            return false;
        }

        public static bool ListeContient(ListView liste, string element)
        {
            ListViewItem resultats = new ListViewItem(element)
            {
                Name = element
            };

            if (liste.Items.ContainsKey(resultats.Name))
            {
                return true;
            }

            return false;
        }
    }
}

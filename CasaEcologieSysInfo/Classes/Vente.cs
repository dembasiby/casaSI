using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;

namespace CasaEcologieSysInfo.Classes
{
    class Vente
    {
        public static void AjouterProduitAuPanier(string produit, string quantite, string pu, ListView listView)
        {
            if (Validation.VerifierChampsMontant(quantite) && Validation.VerifierChampsMontant(pu))
            {
                var montant = int.Parse(pu) * int.Parse(quantite);
                /*
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(quantite);
                item.SubItems.Add(pu);
                item.SubItems.Add(montant.ToString());

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView.Items[i].SubItems[0].Text == item.SubItems[0].Text)
                    {
                        MessageBox.Show("Ce produit est déjà dans le panier.");
                        return;
                    }
                }

                listView.Items.Add(item);
                */
            }
        }
    }
}

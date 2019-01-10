 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_NouvelleVente : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_NouvelleVente()
        {
            InitializeComponent();
        }

        private void UC_NouvelleVente_Load_1(object sender, EventArgs e)
        {
            LoadData();
            txtMontantEncaisse.Text = "0";

        }

        private void LoadData()
        {
            ageEmployesBindingSource.DataSource = db.AgeEmployes.ToList();
            ageEmployeBindingSource.DataSource = db.AgeEmployes.ToList();
            ageClientBindingSource.DataSource = db.AgeClients
                .OrderBy(c => c.NomClient)
                .ToList();
            resStockProduitsFinisBindingSource1.DataSource = db.ResStockProduitsFinis.ToList().OrderBy(p => p.NomProduit);
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();

            MettreAJourStockProduitFini();
        }

        private void MettreAJourStockProduitFini()
        {
            var produitFini = cbxNomProduit.GetItemText(cbxNomProduit.SelectedItem);
            txtSoldeStockProduit.Text = Conversion.CalculerSoldeStockProduitFini(produitFini).ToString();
        }

        private void BtnNouveauClient_Click(object sender, EventArgs e)
        {            
            AgeClient client = new AgeClient
            {
                NomClient = txtNomClient.Text,
                Localite = txtLocalite.Text,
                SoldeInitialeCreance = int.Parse(txtSoldeInitialeCreance.Text)
            };

            db.AgeClients.Add(client);
            db.SaveChanges();
            txtNomClient.Text = "";
            txtLocalite.Text = "";
            txtSoldeInitialeCreance.Text = "00";
            MessageBox.Show("Le nouveau client a été ajouté avec succès");
            LoadData();
           
        }

        private void BtnVente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantite.Text) || string.IsNullOrEmpty(cbxPUProduit.Text))
            {
                MessageBox.Show("Ces champs doivent être renseignés.");
                return;
            }

            try
            {
                int temp = Convert.ToInt32(txtQuantite.Text);
                int temp1 = Convert.ToInt32(cbxPUProduit.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ces champs doivent contenir des nombres.");
                return;
            }            
                
            var montant = int.Parse(cbxPUProduit.Text) * int.Parse(txtQuantite.Text);
            
            ListViewItem item = new ListViewItem(cbxNomProduit.Text);
            item.SubItems.Add(txtQuantite.Text);
            item.SubItems.Add(cbxPUProduit.Text);
            item.SubItems.Add(montant.ToString());

            listView1.Items.Add(item);

            lblTotalFacture.Text = TotalFacture().ToString();
            txtQuantite.Clear();
        }

        private decimal TotalFacture()
        {
            var total = 0;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                total += int.Parse(listView1.Items[i].SubItems[3].Text);
            }

            return total;
        }

        private void SaveSale(EveVente vente, ListViewItem li)
        {
            ResStockProduitsFini produit = db.ResStockProduitsFinis.FirstOrDefault(p => p.NomProduit == li.Text);

         
            var venteProduit = new EveVenteStockProduitsFini
            {
                CodeVente = vente.CodeVente,
                CodeProduitFini = produit.CodeProduit,
                QuantiteProduitFini = int.Parse(li.SubItems[1].Text),
                Montant = int.Parse(li.SubItems[3].Text),
            };

            db.EveVenteStockProduitsFinis.Add(venteProduit);
            db.SaveChanges();
        }

        private void BtnEnregistrerVente_Click(object sender, EventArgs e)
        {           
            AgeClient client = db.AgeClients.FirstOrDefault(c => c.NomClient == cbxNomClient.Text);
            AgeEmploye resStock = db.AgeEmployes.FirstOrDefault(rs => rs.PrenomNom == cbxResponsableStockPrdtsFinis.Text);
            AgeEmploye tres = db.AgeEmployes.FirstOrDefault(rv => rv.PrenomNom == cbxTres.Text);
            ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(cte => cte.NomCompte == cbxCompte.Text);

            EveVente vente = new EveVente
            {
                CodeClient = client.CodeClient,
                CodeEmploye = resStock.CodeEmploye,
                DateVente = DateTime.Parse(dtpDateVente.Text)
            };

            db.EveVentes.Add(vente);
            db.SaveChanges();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                SaveSale(vente, listView1.Items[i]);
            }


            if (int.Parse(txtMontantEncaisse.Text) > 0)
            {
                EveEncaissement enc = new EveEncaissement
                {
                    CodeClient = client.CodeClient,
                    CodeEmploye = tres.CodeEmploye,
                    CodeCompte = cpte.CodeCompte,
                };

                db.EveEncaissements.Add(enc);
                db.SaveChanges();

                EveEncaissementsVente encV = new EveEncaissementsVente
                {
                    CodeEncaissement = enc.CodeEncaissement,
                    CodeVente = vente.CodeVente,
                    MontantEncaisse = int.Parse(txtMontantEncaisse.Text),
                    DateEncaissement = DateTime.Parse(dtpDateVente.Text)
                };

                db.EveEncaissementsVentes.Add(encV);
                db.SaveChanges();
            }

            listView1.Items.Clear();
            lblTotalFacture.Text = "";
            txtMontantEncaisse.Clear();
            MessageBox.Show("La vente a été enregistrée avec succès.");
        }

        private void CbxNomProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourStockProduitFini();
        }
    }
}

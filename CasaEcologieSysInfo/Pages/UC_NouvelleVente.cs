using CasaEcologieSysInfo.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_NouvelleVente : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

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
            ageEmployesBindingSource.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();
            ageEmployeBindingSource.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();

            ageClientBindingSource.DataSource = db.AgeClients
                .OrderBy(c => c.NomClient)
                .ToList();
            resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.ToList().OrderBy(p => p.NomProduit);
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();

            MettreAJourStockProduitFini();
        }

        private void MettreAJourStockProduitFini()
        {
            var produitFini = cbxNomProduit.GetItemText(cbxNomProduit.SelectedItem);
            DateTime date = DateTime.Today.AddDays(1);
            txtSoldeStockProduit.Text = GestionStocks.CalculerSoldeStockProduitFini(produitFini, date).ToString();
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

        private void BtnAjouterProduitAuPanier_Click(object sender, EventArgs e)
        {
            if (Validation.VerifierChampsMontant(txtQuantite.Text) && Validation.VerifierChampsMontant(cbxPUProduit.Text))
            {
                var montant = int.Parse(cbxPUProduit.Text) * int.Parse(txtQuantite.Text);

                ListViewItem item = new ListViewItem(cbxNomProduit.Text);
                item.SubItems.Add(txtQuantite.Text);
                item.SubItems.Add(cbxPUProduit.Text);
                item.SubItems.Add(montant.ToString());

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == item.SubItems[0].Text)
                    {
                        MessageBox.Show("Ce produit est déjà dans le panier.");
                        return;
                    }
                }

                listView1.Items.Add(item);

                lblTotalFacture.Text = TotalFacture().ToString();
                var produitFini = cbxNomProduit.GetItemText(cbxNomProduit.SelectedItem);
                DateTime date = DateTime.Today.AddDays(1);
                txtSoldeStockProduit.Text = (GestionStocks.CalculerSoldeStockProduitFini(produitFini, date) - int.Parse(txtQuantite.Text)).ToString();
                txtQuantite.Clear();
            }           
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
    
        private void BtnEnregistrerVente_Click(object sender, EventArgs e)
        {           
            AgeClient client = db.AgeClients.FirstOrDefault(c => c.NomClient == cbxNomClient.Text);
            AgeEmploye resStock = db.AgeEmployes.FirstOrDefault(rs => rs.PrenomNom == cbxResponsableStockPrdtsFinis.Text);
            AgeEmploye tres = db.AgeEmployes.FirstOrDefault(rv => rv.PrenomNom == cbxTres.Text);
            ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(cte => cte.NomCompte == cbxCompte.Text);

            try
            {
                var verifier = Convert.ToInt32(lblTotalFacture.Text) > 0;

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
                   
                    //EnregistrerVenteDUnProduit(vente, listView1.Items[i]);
                    GestionVentes.EnregistrerNouvelleVenteDUnProduit(vente.CodeVente, listView1.Items[i].SubItems[0].Text, 
                                                            listView1.Items[i].SubItems[1].Text, 
                                                            listView1.Items[i].SubItems[3].Text);
                }


                if (int.Parse(txtMontantEncaisse.Text) > 0)
                {
                    EveEncaissement enc = new EveEncaissement
                    {
                        CodeEmploye = tres.CodeEmploye,
                        CodeCompte = cpte.CodeCompte,
                    };

                    db.EveEncaissements.Add(enc);
                    db.SaveChanges();

                    EveEncaissementsVente encV = new EveEncaissementsVente
                    {
                        CodeClient = client.CodeClient,
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
            catch (Exception)
            {
                MessageBox.Show("Le montant de la facture n'est pas valide.");
                return;
            }
     
        }

        private void CbxNomProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourStockProduitFini();
        }

        private void BtnIncrementQuantite_Click(object sender, EventArgs e)
        {
            try
            {
                var checkNumber = int.TryParse(listView1.FocusedItem.SubItems[1].Text, out int result);
                var total = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);
                var stock = int.Parse(txtSoldeStockProduit.Text);

                if (int.Parse(txtSoldeStockProduit.Text) > 0)
                {
                    stock -= 1;
                    total += 1;
                    listView1.FocusedItem.SubItems[1].Text = total.ToString();
                    listView1.FocusedItem.SubItems[3].Text = (total * int.Parse(listView1.FocusedItem.SubItems[2].Text)).ToString();
                    txtSoldeStockProduit.Text = stock.ToString();
                    lblTotalFacture.Text = TotalFacture().ToString();
                }
                else
                {
                    MessageBox.Show("Il n'y a pas assez de produits en stocks.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez selectionner un produit dans la liste.");
                return;
            }          
        }

        private void BtnDecrementQuantite_Click(object sender, EventArgs e)
        {            
            try
            {
                var checkNumber = int.TryParse(listView1.FocusedItem.SubItems[1].Text, out int result);
                var total = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);
                var stock = int.Parse(txtSoldeStockProduit.Text);

                if (total == 0)
                {
                    MessageBox.Show("Il doit y avoir au moins un produit dans le panier.");
                    listView1.FocusedItem.Remove();
                    return;
                }
                else
                {
                    stock += 1;
                    total -= 1;
                    listView1.FocusedItem.SubItems[1].Text = total.ToString();
                    listView1.FocusedItem.SubItems[3].Text = (total * int.Parse(listView1.FocusedItem.SubItems[2].Text)).ToString();
                    txtSoldeStockProduit.Text = stock.ToString();
                    lblTotalFacture.Text = TotalFacture().ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez selectionner un produit dans la liste.", "Erreur de choix d'un produit");
                return;
            }
        }

        private void BtnRetirer_Click(object sender, EventArgs e)
        {
            try
            {
                var checkNumber = int.TryParse(listView1.FocusedItem.SubItems[1].Text, out int result);

                var quantite = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);
                var stock = int.Parse(txtSoldeStockProduit.Text);

                listView1.FocusedItem.Remove();

                stock += quantite;
                txtSoldeStockProduit.Text = stock.ToString();
                lblTotalFacture.Text = TotalFacture().ToString("c0");
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez selectionner un produit dans la liste.");
                return;
            }
        }
    }
}

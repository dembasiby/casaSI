﻿using CasaEcologieSysInfo.Classes;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdateVente : UserControl
    {
        public UC_UpdateVente()
        {
            InitializeComponent();
        }

        private void UC_UpdateVente_Load(object sender, EventArgs e)
        {
            LoadListeVentes();
            LoadListeProduits();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            ReloadAll();
            LoadListeVentes();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            ReloadAll();
            LoadListeVentes();
        }

        private void DgvListeVentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvListeVentes.Rows[e.RowIndex];
            int codeVente = int.Parse(row.Cells["Code"].Value.ToString());
            LoadDetailsVentes(codeVente);
        }

        private void BtnAnnulerCorrection_Click(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void BtnMettreVenteAJour_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous effectivement mettre à jour cette transaction?...",
                "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    int index = this.dgvListeVentes.CurrentCell.RowIndex;
                    int codeVente = int.Parse(dgvListeVentes.Rows[index].Cells["Code"].Value.ToString());
                    // A completer
                    for (int i = 0; i < lvwPanier.Items.Count; i++)
                    {
                        if (ProduitDansLePanierInitial(codeVente, lvwPanier.Items[i].SubItems[0].Text))
                        {
                            GestionVentes.MettreAJourVenteDUnProduit(codeVente, lvwPanier.Items[i].SubItems[0].Text,
                                                                lvwPanier.Items[i].SubItems[1].Text,
                                                                lvwPanier.Items[i].SubItems[3].Text);
                        }
                        else
                        {
                            GestionVentes.EnregistrerNouvelleVenteDUnProduit(codeVente, lvwPanier.Items[i].SubItems[0].Text,
                                                                lvwPanier.Items[i].SubItems[1].Text,
                                                                lvwPanier.Items[i].SubItems[3].Text);
                        }
                    }

                    // Mettre a jour l'encaissement le cas échéant
                    if (Validation.VerifierChampsMontant(txtMontantPaye.Text) && float.Parse(txtMontantPaye.Text) > 0)
                    {
                        if (IlYaEuEncaissementDeVente(codeVente) && MontantPaye(codeVente) != decimal.Parse(txtMontantPaye.Text))
                        {
                            int codeCompte = int.Parse(cbxListeComptes.SelectedValue.ToString());
                            GestionVentes.MettreEncaissementVenteAJour(codeVente, decimal.Parse(txtMontantPaye.Text), codeCompte);
                        }
                    }

                    MessageBox.Show("Transaction mise à jour.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur! La transaction n'a pas été mise à jour.");
                }
            }
        }

        private void BtnSupprimerVente_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous réellement supprimer cette transaction?...",
                    "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = this.dgvListeVentes.CurrentCell.RowIndex;
                    int codeVente = int.Parse(dgvListeVentes.Rows[index].Cells["Code"].Value.ToString());

                    SupprimerVente(codeVente);

                    MessageBox.Show("La transaction a été supprimée.");
                    ReloadAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("La suppression de la transaction a été intérompue.");
                return;
            }
        }


        private void BtnEnleverProduitDuPanier_Click(object sender, EventArgs e)
        {
            lvwPanier.FocusedItem.Remove();
            SupprimerVenteProduit();
        }

        private void BtnAugmenterQuantite_Click(object sender, EventArgs e)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var checkNumber = int.TryParse(lvwPanier.FocusedItem.SubItems[1].Text, out int result);
                    int quantite = int.Parse(lvwPanier.FocusedItem.SubItems[1].Text);
                    string produit = lvwPanier.FocusedItem.SubItems[0].Text;
                    DateTime date = DateTime.Today.AddDays(1);
                    int stock = GestionStocks.CalculerSoldeStockProduitFini(produit, date);

                    if (quantite < stock)
                    {
                        quantite += 1;
                        lvwPanier.FocusedItem.SubItems[1].Text = quantite.ToString();
                        lvwPanier.FocusedItem.SubItems[3].Text = (quantite * float.Parse(lvwPanier.FocusedItem.SubItems[2].Text)).ToString();
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
        }

        private void BtnDiminuerQuantite_Click(object sender, EventArgs e)
        {
            try
            {
                var quantite = Convert.ToInt32(lvwPanier.FocusedItem.SubItems[1].Text);

                if (quantite > 1)
                {
                    quantite -= 1;
                    lvwPanier.FocusedItem.SubItems[1].Text = quantite.ToString();
                    lvwPanier.FocusedItem.SubItems[3].Text = (quantite * float.Parse(lvwPanier.FocusedItem.SubItems[2].Text)).ToString();
                }
                else if (quantite == 1)
                {
                    if (MessageBox.Show("Il doit y avoir au moins un produit dans le panier. Voulez-vous le supprimer du panier?...", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SupprimerVenteProduit();
                        lvwPanier.FocusedItem.Remove();
                        return;
                    }

                    //return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez selectionner un produit dans la liste.", "Erreur de choix d'un produit");
                return;
            }
        }


        private void BtnMettrePUAJour_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkNumber = int.TryParse(txtPrixAMettreAJour.Text, out int result);
                bool prixValide = float.Parse(txtPrixAMettreAJour.Text) > 0;

                string nouveauPrix = txtPrixAMettreAJour.Text;
                lvwPanier.FocusedItem.SubItems[2].Text = nouveauPrix;
                lvwPanier.FocusedItem.SubItems[3].Text = (float.Parse(lvwPanier.FocusedItem.SubItems[1].Text)
                    * float.Parse(lvwPanier.FocusedItem.SubItems[2].Text)).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Veuillez entrer un prix valide");
            }
        }


        private void BtnAjouterProduitAuPanier_Click(object sender, EventArgs e)
        {
            if (Validation.VerifierChampsMontant(txtQuantite.Text) && Validation.VerifierChampsMontant(txtPU.Text))
            {
                var montant = float.Parse(txtPU.Text) * int.Parse(txtQuantite.Text);
                string produit = cbxListeProduits.GetItemText(cbxListeProduits.SelectedItem);
                DateTime date = DateTime.Today.AddDays(1);
                int stock = GestionStocks.CalculerSoldeStockProduitFini(produit, date);

                if (int.Parse(txtQuantite.Text) <= stock)
                {
                    ListViewItem item = new ListViewItem(cbxListeProduits.Text);
                    item.SubItems.Add(txtQuantite.Text);
                    item.SubItems.Add(txtPU.Text);
                    item.SubItems.Add(montant.ToString());

                    for (int i = 0; i < lvwPanier.Items.Count; i++)
                    {
                        if (lvwPanier.Items[i].SubItems[0].Text == item.SubItems[0].Text)
                        {
                            MessageBox.Show("Ce produit est déjà dans le panier. Veuillez changer la quantité ou le prix unitaire.");
                            return;
                        }
                    }

                    lvwPanier.Items.Add(item);
                    txtPU.Clear();
                    txtQuantite.Clear();
                }
                else
                {
                    MessageBox.Show("Il n'y a pas assez de produits en stock. Veuillez diminuer la quantité.");
                }
            }
        }

        private void CbxListeProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetailsProduitListeProduits();
        }

        // METHODES DE GESTION DU CHARGEMENT DES DONNEES DANS LA PAGE
        //
        private void LoadListeVentes()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventes = (from v in db.EveVentes
                              where v.DateVente >= dtpDebut.Value.Date && v.DateVente <= dtpFin.Value.Date
                              join c in db.AgeClients on v.CodeClient equals c.CodeClient
                              select new
                              {
                                  Code = v.CodeVente,
                                  Date = v.DateVente,
                                  Client = c.NomClient
                              }).OrderBy(d => d.Date).ToList();

                DataTable dt = Conversion.ConvertirEnTableDeDonnees(ventes);
                dgvListeVentes.DataSource = dt;
            }
        }

        private void LoadDetailsVentes(int codeVente)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                cbxListeClients.DataSource = db.AgeClients.OrderBy(c => c.NomClient).ToList();
                cbxListeComptes.DataSource = db.ResComptesTresoreries.OrderBy(c => c.NomCompte).ToList();

                var vente = (from v in db.EveVentes
                             join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                             join c in db.AgeClients on v.CodeClient equals c.CodeClient
                             where v.CodeVente == codeVente
                             select new
                             {
                                 v.DateVente,
                                 v.CodeClient,
                                 c.Localite
                             }).FirstOrDefault();

                var montantTotal = (from v in db.EveVentes
                                    join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                                    where v.CodeVente == codeVente
                                    select vp.Montant).Sum();

                var montantPaye = (from v in db.EveVentes
                                   join ev in db.EveEncaissementsVentes on v.CodeVente equals ev.CodeVente
                                   where v.CodeVente == codeVente
                                   select ev.MontantEncaisse).FirstOrDefault();

                var codeCompte = (from v in db.EveVentes
                                  join ev in db.EveEncaissementsVentes on v.CodeVente equals ev.CodeVente
                                  join e in db.EveEncaissements on ev.CodeEncaissement equals e.CodeEncaissement
                                  where v.CodeVente == codeVente
                                  select e.CodeCompte).FirstOrDefault();

                var detailProduitsVendus = (from pv in db.EveVenteStockProduitsFinis
                                            where pv.CodeVente == codeVente
                                            select new
                                            {
                                                Code = pv.CodeProduitFini,

                                                Produit = pv.ResStockProduitsFini.NomProduit,
                                                Quantite = pv.QuantiteProduitFini,
                                                PU = pv.Montant / pv.QuantiteProduitFini,
                                                pv.Montant

                                            }).OrderBy(p => p.Produit).ToList();

                foreach (var produit in detailProduitsVendus)
                {
                    ListViewItem element = new ListViewItem(produit.Produit);
                    element.SubItems.Add(produit.Quantite.ToString("n0"));
                    element.SubItems.Add(produit.PU.ToString("n0"));
                    element.SubItems.Add(produit.Montant.ToString("n0"));

                    lvwPanier.Items.Add(element);

                }
                dtpDateVente.Value = vente.DateVente;
                cbxListeClients.SelectedValue = vente.CodeClient;
                txtLocaliteClient.Text = vente.Localite;
                txtMontantTotal.Text = montantTotal.ToString("n0");
                txtMontantPaye.Text = montantPaye.ToString("n0");


                if (codeCompte > 0)
                {
                    cbxListeComptes.SelectedValue = codeCompte;
                }
                else
                {
                    cbxListeComptes.SelectedValue = 0;
                }
            }
        }

        private void LoadListeProduits()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                cbxListeProduits.DataSource = db.ResStockProduitsFinis.OrderBy(prd => prd.NomProduit).ToList();
                cbxListeProduits.DisplayMember = "NomProduit";
                AfficherDetailsProduitListeProduits();
            }
        }

        private void AfficherDetailsProduitListeProduits()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                string produit = cbxListeProduits.GetItemText(cbxListeProduits.SelectedItem);
                var pu = db.ResStockProduitsFinis.Where(pr => pr.NomProduit == produit).Select(pr => pr.PrixDeVenteStandard).FirstOrDefault();
                txtPU.Text = pu.ToString();
            }
        }

        private void ClearData()
        {
            cbxListeComptes.SelectedIndex = -1;
            cbxListeClients.SelectedIndex = -1;
            lvwPanier.Items.Clear();
            dtpDateVente.Value = DateTime.Today;
            txtLocaliteClient.Clear();
            txtMontantTotal.Clear();
            txtMontantPaye.Clear();
        }

        private void ReloadAll()
        {
            LoadListeVentes();
            ClearData();
        }


        // METHODES DE MISE A JOUR DES VENTES
        //

        private void MettreVenteAJour(int codeVente)
        {
            // A Completer
            using (CasaDBEntities db = new CasaDBEntities())
            {
                throw new NotImplementedException();
            }
        }

        private void SupprimerVente(int codeVente)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                // vente
                var vente = db.EveVentes.Where(v => v.CodeVente == codeVente).First();
                // vente produit
                var venteProduits = db.EveVenteStockProduitsFinis.Where(vp => vp.CodeVente == codeVente).ToList();

                // si encaissement:
                // encaissement
                // encaissement vente
                if (IlYaEuEncaissementDeVente(codeVente))
                {
                    var encaissementVente = db.EveEncaissementsVentes.Where(ev => ev.CodeVente == codeVente).First();

                    var encaissement = (from ev in db.EveEncaissementsVentes
                                        join e in db.EveEncaissements on ev.CodeEncaissement equals e.CodeEncaissement
                                        where ev.CodeVente == codeVente
                                        select e).FirstOrDefault();

                    db.EveEncaissementsVentes.Remove(encaissementVente);
                    db.EveEncaissements.Remove(encaissement);
                }

                foreach (var item in venteProduits)
                {
                    db.EveVenteStockProduitsFinis.Remove(item);
                }

                db.EveVentes.Remove(vente);
                db.SaveChanges();
            }
        }

        private void SupprimerVenteProduit()
        {
            try
            {
                using (CasaDBEntities db = new CasaDBEntities())
                {
                    int index = this.dgvListeVentes.CurrentCell.RowIndex;
                    int codeVente = int.Parse(dgvListeVentes.Rows[index].Cells["Code"].Value.ToString());
                    string produit = lvwPanier.FocusedItem.SubItems[0].Text;
                    int codeProduit = db.ResStockProduitsFinis.Where(p => p.NomProduit == produit).Select(p => p.CodeProduit).First();
                    bool produitDansLePanierInitial = ProduitDansLePanierInitial(codeVente, produit);
                    var venteProduit = db.EveVenteStockProduitsFinis.Where(vpf => vpf.CodeVente == codeVente).Single(p => p.CodeProduitFini == codeProduit);

                    db.EveVenteStockProduitsFinis.Remove(venteProduit);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private bool ProduitDansLePanierInitial(int codeVente, string produit)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                int codeProduit = db.ResStockProduitsFinis.Where(p => p.NomProduit == produit).Select(p => p.CodeProduit).First();
                bool reponse = db.EveVenteStockProduitsFinis.Where(vpf => vpf.CodeVente == codeVente).Select(p => p.CodeProduitFini == codeProduit).FirstOrDefault();
                MessageBox.Show(reponse.ToString());
                return reponse;
            }
        }

        private bool IlYaEuEncaissementDeVente(int codeVente)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var codeCompte = (from v in db.EveVentes
                                  join ev in db.EveEncaissementsVentes on v.CodeVente equals ev.CodeVente
                                  join e in db.EveEncaissements on ev.CodeEncaissement equals e.CodeEncaissement
                                  where v.CodeVente == codeVente
                                  select e.CodeCompte).FirstOrDefault();

                if (codeCompte > 0)
                {
                    return true;
                }

                return false;
            }
        }

        private decimal MontantPaye(int codeVente)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return db.EveEncaissementsVentes.Where(ev => ev.CodeVente == codeVente).Select(ev => ev.MontantEncaisse).First();
            }
        }
    }
}

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
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            LoadListeVentes();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
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
                // A completer
                MessageBox.Show("Transaction mise à jour.");
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
                dtpDateVente.Value                      = vente.DateVente;
                cbxListeClients.SelectedValue           = vente.CodeClient;
                txtLocaliteClient.Text                  = vente.Localite;
                txtMontantTotal.Text                    = montantTotal.ToString("n0");
                txtMontantPaye.Text                     = montantPaye.ToString("n0");


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


                var codeCompte = (from v in db.EveVentes
                                  join ev in db.EveEncaissementsVentes on v.CodeVente equals ev.CodeVente
                                  join e in db.EveEncaissements on ev.CodeEncaissement equals e.CodeEncaissement
                                  where v.CodeVente == codeVente
                                  select e.CodeCompte).FirstOrDefault();

                // si encaissement:
                // encaissement
                // encaissement vente
                if (codeCompte > 0)
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

        private void BtnEnleverProduitDuPanier_Click(object sender, EventArgs e)
        {

            using (CasaDBEntities db = new CasaDBEntities())
            {
                int index = this.dgvListeVentes.CurrentCell.RowIndex;
                int codeVente = int.Parse(dgvListeVentes.Rows[index].Cells["Code"].Value.ToString());

                string produit = lvwPanier.FocusedItem.SubItems[0].Text;
                int codeProduit = db.ResStockProduitsFinis.Where(p => p.NomProduit == produit).Select(p => p.CodeProduit).First();
                var venteProduit = db.EveVenteStockProduitsFinis.Where(vpf => vpf.CodeVente == codeVente).Single(p => p.CodeProduitFini == codeProduit);
                db.EveVenteStockProduitsFinis.Remove(venteProduit);
                db.SaveChanges();
                lvwPanier.FocusedItem.Remove();
            }
        }

        private void BtnAugmenterQuantite_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiminuerQuantite_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace CasaEcologieSysInfo
{
    public partial class UC_Production : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();        

        public UC_Production()
        {
            InitializeComponent();
        }

        public void ChargerDonneesInitiales()
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.ToList();
            resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.ToList().OrderBy(p => p.NomProduit);
            resStockProduitsSemiFiniBindingSource2.DataSource = db.ResStockProduitsSemiFinis.ToList();

            ageEmployeBindingSource2.DataSource = db.AgeEmployes.ToList();
            ageEmployeBindingSource1.DataSource = db.AgeEmployes.ToList();
            ageEmployeBindingSource3.DataSource = db.AgeEmployes.ToList();

            var nomMatierePrem = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            txtStockMatierePremiereDispo.Text = ChargerStockMatierePremiere(nomMatierePrem).ToString();
        }

        private float ChargerStockMatierePremiere(string nomMatierePrem)
        {
            var stockInitial = (from mp in db.ResStockMatieresPremieres
                                where mp.NomMatiere == nomMatierePrem
                                select mp.StockMatiere).FirstOrDefault();

            var entrees = (from rmp in db.EveReceptionMatieresPremieres
                           where rmp.ResStockMatieresPremiere.NomMatiere == nomMatierePrem
                           select (float?)rmp.Quantite).Sum() ?? 0f;

            var sorties = (from ump in db.EveUtilisationMatieresPremieres
                           where ump.ResStockMatieresPremiere.NomMatiere == nomMatierePrem
                           select (float?)ump.QuantiteMatierePremiere).Sum() ?? 0f;

            return stockInitial + entrees - sorties;
        }

        // Affiche la liste des travailleurs présent le jour de la production
        private void ChargerListeTravailleurs()
        {

            clbEmployes.Items.Clear();

            var listeEmployes = (from pe in db.EvePresenceEmployes
                             where pe.Date == dateTimePicker1.Value.Date
                             select pe.AgeEmploye.PrenomNom).ToList();

            clbEmployes.Items.AddRange(listeEmployes.ToArray());
        }

        private void UC_Production_Load(object sender, EventArgs e)
        {
            ChargerDonneesInitiales();
            ChargerListeTravailleurs();

            var listProduitsSemiFinis = from em in db.ResStockProduitsSemiFinis
                                        select em.Description;

            cbxNomProduitSemiFini.Items.AddRange(listProduitsSemiFinis.ToArray());
            cbxProduitsSemiFinis.Items.AddRange(listProduitsSemiFinis.ToArray());

            if (cbxNomProduitSemiFini.Items.Count > 0)
            {
                cbxNomProduitSemiFini.SelectedIndex = 0;
            }

            if (cbxProduitsSemiFinis.Items.Count > 0)
            {
                cbxProduitsSemiFinis.SelectedIndex = 0;
            }

            AfficherSoldeStocksProduitsSemiFinis();
        }

        public void VerifierChampsQuantite (string quantite)
        {
            if (string.IsNullOrEmpty(quantite))
            {
                MessageBox.Show("Le champs 'Quantité' ne peut être vide.");
                return;
            }

            try
            {
                var item = (quantite == txtQuantiteMatiereP.Text ? Convert.ToSingle(quantite) : Convert.ToInt32(quantite));
            }
            catch (Exception)
            {
                MessageBox.Show("Le champs 'Quantité' doit contenir des nombres.");
                return;
            }
        }

        private void UtiliserMatierePremiere(int codeURes, ListViewItem li)
        {
            ResStockMatieresPremiere matP = db.ResStockMatieresPremieres.FirstOrDefault(
                    mp => mp.NomMatiere == li.Text);

            EveUtilisationMatieresPremiere uMatP = new EveUtilisationMatieresPremiere
            {
                CodeUtilisationRessource = codeURes,
                CodeMatierePremiere = matP.CodeMatierePremiere,
                QuantiteMatierePremiere = float.Parse(li.SubItems[1].Text),
            };

            db.EveUtilisationMatieresPremieres.Add(uMatP);
            db.SaveChanges();
            ChargerStockMatierePremiere(matP.NomMatiere);
        }

        private void AjouterRessourcesMatieresPremieres(int codeRessource)
        {
            try
            {
                // Ajouter ressources : Matiere premiere à la liste des matières premières
                // utilisées pour la présente production         
                for (int i = 0; i < lvwListeMatieresP.Items.Count; i++)
                {
                    UtiliserMatierePremiere(codeRessource, lvwListeMatieresP.Items[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La matière première n'a pas pu être ajoutée: ", ex.Message);
            }
        }

        private void UtiliserRessourcesProduitsSemiFinis(int codeURes, ListViewItem li)
        {

            ResStockProduitsSemiFini psf = db.ResStockProduitsSemiFinis.FirstOrDefault(p => p.Description == li.Text);
            EveUtilisationProduitsSemiFini upsf = new EveUtilisationProduitsSemiFini
            {
                CodeUtilisationRessource = codeURes,
                CodeProduitSemiFini = psf.CodeProduitSemiFini,
                QuantiteProduitSemiFini = int.Parse(li.SubItems[1].Text)
            };

            db.EveUtilisationProduitsSemiFinis.Add(upsf);
            db.SaveChanges();
            
        }

        private void AjouterRessourcesProduitSemiFini(int codeRessource)
        {
            try
            {
                // Ajouter ressources : produit semi fini à la liste des produits semi finis 
                // utilisées pour la présente production         
                for (int i = 0; i < lvwListProduitsSemiFinisUtilises.Items.Count; i++)
                {
                    UtiliserRessourcesProduitsSemiFinis(codeRessource, lvwListProduitsSemiFinisUtilises.Items[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le produit semi-fini n'a pas pu être ajouté: ", ex.Message);
            }
        }

        private void UtiliserTravailleur(string nomTravailleur, int codeURessources)
        {
            AgeEmploye travailleur = db.AgeEmployes.FirstOrDefault(emp => emp.PrenomNom == nomTravailleur);

            (from preE in db.EvePresenceEmployes
             where preE.CodeEmploye == travailleur.CodeEmploye
             where preE.Date == dateTimePicker1.Value.Date
             select preE)
             .ToList()
             .ForEach(em => em.CodeUtilisationDesRessources = codeURessources);
            
            db.SaveChanges();
        }

        private void AjouterRessourcesTravailleurs(int codeURessource)
        {
            if (clbEmployes.CheckedItems.Count > 0)
            {
                for (int i = 0; i < clbEmployes.CheckedItems.Count; i++)
                {
                    var trav = clbEmployes.CheckedItems[i].ToString();
                    UtiliserTravailleur(trav, codeURessource);
                }
            }
            else
            {
                MessageBox.Show("Une production doit être réalisée par au moins un employé.");
                return;
            }
        }

        private EveProduction CreerProduction(int codeRessource, int codeResProduitsFinis)
        {
            EveProduction prod = new EveProduction
            {
                CodeUtilisationRessources = codeRessource,
                CodeEmploye_Resp_stock_produits_finis = codeResProduitsFinis,
                Date = DateTime.Parse(dateTimePicker1.Text)
            };

            db.EveProductions.Add(prod);
            db.SaveChanges();
            return prod;
        }

        private void AjouterResultatProductionALaListe(string quantite, string element, ListView liste)
        {
            VerifierChampsQuantite(quantite);

            try
            {
                if (float.Parse(quantite) > 0f || int.Parse(quantite) > 0)
                {
                    ListViewItem resultats = new ListViewItem(element);
                    resultats.Name = element;

                    if (!liste.Items.ContainsKey(resultats.Name))
                    {
                        resultats.SubItems.Add(quantite);
                        liste.Items.Add(resultats);
                        quantite = "";
                    }
                    else
                    {
                        MessageBox.Show("Cet élément a déjà été ajouté une première fois.");
                        return;
                    }                  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("La quantité ne doit pas être nulle.", ex.Message);
            }
            
        }

        private void BtnAjouterMatierePProduction_Click(object sender, EventArgs e)
        {                       
            if ( float.Parse(txtStockMatierePremiereDispo.Text) <= 0f || float.Parse(txtStockMatierePremiereDispo.Text) < float.Parse(txtQuantiteMatiereP.Text))
            {
                MessageBox.Show("Le stock de matière première disponible est insuffisant.");
                return;
            }

           
            AjouterResultatProductionALaListe(txtQuantiteMatiereP.Text, cbxNomMatiereP.Text, lvwListeMatieresP);
            txtQuantiteMatiereP.Clear();
                    
        }

        private void BtnAjouterPSemiFiniProduction_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtStockProduitSFini.Text) <= 0 || int.Parse(txtStockProduitSFini.Text) < int.Parse(txtQuantiteProduitSemiFiniUtilise.Text))
            {
                MessageBox.Show("Le stock de matière première disponible est insuffisant.");
                return;
            }

            AjouterResultatProductionALaListe(
                txtQuantiteProduitSemiFiniUtilise.Text, 
                cbxNomProduitSemiFini.Text, 
                lvwListProduitsSemiFinisUtilises);

            txtQuantiteProduitSemiFiniUtilise.Clear();
        }

        private void BtnAjouterProduitFini_Click(object sender, EventArgs e)
        {
            AjouterResultatProductionALaListe(txtQuantiteProduitFini.Text, cbxProduitsFinis.Text, lvwListeProduitsF);
            txtQuantiteProduitFini.Clear();
        }

        private void BtnAjouterProduitSemiFini_Click(object sender, EventArgs e)
        {
            AjouterResultatProductionALaListe(txtQuantiteProduitSemiFini.Text, cbxProduitsSemiFinis.Text, lvwListeProduitsSemiF);
            txtQuantiteProduitSemiFini.Clear();
        }

        private void BtnNouvelleProduction_Click(object sender, EventArgs e)
        {
            EnregistrerProduction();
        }

        private void VerifierInfoIntrantsEtExtrantsProduction()
        {
            if (lvwListeMatieresP.Items.Count == 0 && lvwListProduitsSemiFinisUtilises.Items.Count == 0)
            {
                MessageBox.Show("Il est impératif d'utiliser une matière première ou un produit semi-fini pour réaliser une production.");
                return;
            }

            if (lvwListeProduitsSemiF.Items.Count == 0 && lvwListeProduitsF.Items.Count == 0)
            {
                MessageBox.Show("Le résultat de la production en termes de quantité de produits finis ou semi-finis doit être renseigné.");
                return;
            }
        }

        private void EnregistrerProduction()
        {
            AgeEmploye respProd = db.AgeEmployes.FirstOrDefault(rp => rp.PrenomNom == cbxResponsableProduction.Text);
            AgeEmploye respStockMatPrem = db.AgeEmployes.FirstOrDefault(rsmp => rsmp.PrenomNom == cbxRespMatPrem.Text);
            AgeEmploye respStockProduitsFinis = db.AgeEmployes.FirstOrDefault(rspf => rspf.PrenomNom == cbxResponsableStockProduitFinis.Text);

            VerifierInfoIntrantsEtExtrantsProduction();
            //VerifierPresenceEmployesDansLaProduction();
            // Creer une nouvelle utilisation des ressources
            EveUtilisationRessource utilisationRessource = new EveUtilisationRessource
            {
                CodeEmploye_Resp_production_ = respProd.CodeEmploye,
                CodeEmploye_Resp_stock_matiere_premiere_ = respStockMatPrem.CodeEmploye
            };

            db.EveUtilisationRessources.Add(utilisationRessource);
            db.SaveChanges();

            var codeUtilisationRessources = utilisationRessource.CodeUtilisationRessources;

            AjouterRessourcesMatieresPremieres(codeUtilisationRessources);
            AjouterRessourcesTravailleurs(codeUtilisationRessources);
            AjouterRessourcesProduitSemiFini(codeUtilisationRessources);

            // Créer production
            var creerProduction = CreerProduction(codeUtilisationRessources, respStockProduitsFinis.CodeEmploye);
            var codeProduction = creerProduction.CodeProduction;

            // Ajouter la liste des produits finis produits
            EnregistrerProductionProduitFini(codeProduction);

            // Ajouter la liste des produits semi-finis produits
            EnregistrerProductionProduitSemiFini(codeProduction);
            // Effacer les donnees deja enregistrees
            lvwListeMatieresP.Items.Clear();
            lvwListeProduitsF.Items.Clear();
            lvwListeProduitsSemiF.Items.Clear();
            lvwListProduitsSemiFinisUtilises.Items.Clear();

            var nomMatierePrem = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            txtStockMatierePremiereDispo.Text = ChargerStockMatierePremiere(nomMatierePrem).ToString();
        }

        private void ProductionProduitFini(int codeProduction, string nomProduit, int quantite)
        {
            ResStockProduitsFini npf = db.ResStockProduitsFinis.FirstOrDefault(n => n.NomProduit == nomProduit);
            EveProductionStockProduitsFini prodPFini = new EveProductionStockProduitsFini
            {
                CodeProduction = codeProduction,
                CodeProduitFini = npf.CodeProduit,
                QuantiteProduitFini = quantite
            };

            db.EveProductionStockProduitsFinis.Add(prodPFini);
            db.SaveChanges();

            MessageBox.Show("La production a été enregistrée avec succès.");
        }

        private void EnregistrerProductionProduitFini(int codeProduction)
        {
            for (int i = 0; i < lvwListeProduitsF.Items.Count; i++)
            {
                var produit = lvwListeProduitsF.Items[i];
                ProductionProduitFini(codeProduction, produit.Text, int.Parse(produit.SubItems[1].Text));
            }

        }

        private void ProductionProduitSemiFiniProduit(int codeProduction, string nomProduit, int quantite)
        {
            ResStockProduitsSemiFini npsf = db.ResStockProduitsSemiFinis.FirstOrDefault(n => n.Description == nomProduit);
            EveProductionProduitsSemiFini prodPSFini = new EveProductionProduitsSemiFini
            {
                CodeProduction = codeProduction,
                CodeProduitSemiFini = npsf.CodeProduitSemiFini,
                QuantiteProduitSemiFini = quantite
            };

            db.EveProductionProduitsSemiFinis.Add(prodPSFini);
            db.SaveChanges();

            MessageBox.Show("La production a été enregistrée avec succès.");
        }

        private void EnregistrerProductionProduitSemiFini(int codeProduction)
        {
            for (int i = 0; i < lvwListeProduitsSemiF.Items.Count; i++)
            {
                var produit = lvwListeProduitsSemiF.Items[i];
                ProductionProduitSemiFiniProduit(codeProduction, produit.Text, int.Parse(produit.SubItems[1].Text));
            }
        }

        private void CbxNomProduitSemiFini_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherSoldeStocksProduitsSemiFinis();
        }

        private void AfficherSoldeStocksProduitsSemiFinis()
        {
            try
            {
                var prodSF = cbxNomProduitSemiFini.GetItemText(cbxNomProduitSemiFini.SelectedItem);

                var codeQuery = (from st3 in db.ResStockProduitsSemiFinis
                                 where st3.Description == prodSF
                                 select st3).FirstOrDefault();

                var stockInitial = codeQuery.Quantite;
                var entrees = (from epsf in db.EveProductionProduitsSemiFinis
                               where epsf.ResStockProduitsSemiFini.Description == prodSF
                               select (int?)epsf.QuantiteProduitSemiFini).Sum() ?? 0;
                var sorties = (from ufsp in db.EveUtilisationProduitsSemiFinis
                               where ufsp.ResStockProduitsSemiFini.Description == prodSF
                               select (int?)ufsp.QuantiteProduitSemiFini).Sum() ?? 0;

                var soldeStock = stockInitial + entrees - sorties;
                txtStockProduitSFini.Text = soldeStock.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Il n'y a pas encore de données dans la liste des produits semi-finis.", ex.Message);
            }
        }

        private void BtnOuvrirFormNouveauProduit_Click(object sender, EventArgs e)
        {
            using (frmNouveauProduitFiniOuSemiFini np = new frmNouveauProduitFiniOuSemiFini())
            {
                np.ShowDialog();
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeTravailleurs();
        }

        private void CbxNomMatiereP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matP = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            txtStockMatierePremiereDispo.Text = ChargerStockMatierePremiere(matP).ToString();
        }      
    }
}

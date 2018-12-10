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

        public void LoadData()
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.ToList();
            resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.ToList();
            resStockProduitsSemiFiniBindingSource2.DataSource = db.ResStockProduitsSemiFinis.ToList();

            ageEmployeBindingSource2.DataSource = db.AgeEmployes.ToList();
            ageEmployeBindingSource1.DataSource = db.AgeEmployes.ToList();
            ageEmployeBindingSource3.DataSource = db.AgeEmployes.ToList();

            
        }

        private void UC_Production_Load(object sender, EventArgs e)
        {
            LoadData();

            var listeEmployes = from em in db.AgeEmployes
                                select em.PrenomNom;
            clbEmployes.Items.AddRange(listeEmployes.ToArray());



            var listProduitsSemiFinis = from em in db.ResStockProduitsSemiFinis
                                        // where em.CodeMatierePremiere.Equals(em.ResStockMatieresPremiere.CodeMatierePremiere)
                                        select em.ResStockMatieresPremiere.NomMatiere;

            cbxNomProduitSemiFini.Items.AddRange(listProduitsSemiFinis.ToArray());
            cbxProduitsSemiFinis.Items.AddRange(listProduitsSemiFinis.ToArray());
            cbxNomProduitSemiFini.SelectedIndex = 0;
            cbxProduitsSemiFinis.SelectedIndex = 0;


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
                var temp = Convert.ToInt32(quantite);
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
                QuantiteMatierePremiere = int.Parse(li.SubItems[1].Text),
            };

            db.EveUtilisationMatieresPremieres.Add(uMatP);
            db.SaveChanges();
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

        private void UtiliserTravailleur(string nomTravailleur, int codeURessources)
        {
            AgeEmploye travailleur = db.AgeEmployes.FirstOrDefault(emp => emp.PrenomNom == nomTravailleur);

            EvePresenceEmploye pEmp = new EvePresenceEmploye
            {
                CodeEmploye = travailleur.CodeEmploye,
                CodeUtilisationDesRessources = codeURessources
            };

            db.EvePresenceEmployes.Add(pEmp);
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
                if (int.Parse(quantite) > 0)
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
            if ( int.Parse(cbxStock.Text) <= 0 || int.Parse(cbxStock.Text) < int.Parse(txtQuantiteMatiereP.Text))
            {
                MessageBox.Show("Le stock de matière première disponible est insuffisant.");
                return;
            }

           
            AjouterResultatProductionALaListe(txtQuantiteMatiereP.Text, cbxNomMatiereP.Text, lvwListeMatieresP);
                    
        }

        private void BtnAjouterProduitFini_Click(object sender, EventArgs e)
        {
            AjouterResultatProductionALaListe(txtQuantiteProduitFini.Text, cbxProduitsFinis.Text, lvwListeProduitsF);          
        }

        private void BtnAjouterProduitSemiFini_Click(object sender, EventArgs e)
        {
            AjouterResultatProductionALaListe(txtQuantiteProduitSemiFini.Text, cbxProduitsSemiFinis.Text, lvwListeProduitsSemiF);
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
            VerifierPresenceEmployesDansLaProduction();
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

            // Créer production
            var creerProduction = CreerProduction(codeUtilisationRessources, respStockProduitsFinis.CodeEmploye);
            var codeProduction = creerProduction.CodeProduction;

            // Ajouter la liste des produits finis produits
            EnregistrerProductionProduitFini(codeProduction);

            // Ajouter la liste des produits semi-finis produits
            EnregistrerProductionProduitSemiFini(codeProduction);
        }

        private void VerifierPresenceEmployesDansLaProduction()
        {
            throw new NotImplementedException();
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
            lvwListeProduitsF.Items.Clear();
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
            ResStockProduitsSemiFini npsf = db.ResStockProduitsSemiFinis.FirstOrDefault(n => n.ResStockMatieresPremiere.NomMatiere == nomProduit);
            EveProductionProduitsSemiFini prodPSFini = new EveProductionProduitsSemiFini
            {
                CodeProduction = codeProduction,
                CodeProduitSemiFini = npsf.CodeProduitSemiFini,
                QuantiteProduitSemiFini = quantite
            };

            db.EveProductionProduitsSemiFinis.Add(prodPSFini);
            db.SaveChanges();

            MessageBox.Show("La production a été enregistrée avec succès.");
            lvwListeProduitsSemiF.Items.Clear();
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
            try
            {
                var prodSF = cbxNomProduitSemiFini.SelectedItem.ToString();

                var codeQuery = from st3 in db.ResStockMatieresPremieres
                                where st3.NomMatiere == prodSF
                                select st3;

                var code = codeQuery.FirstOrDefault().CodeMatierePremiere;
                var stockQuery = from st2 in db.ResStockProduitsSemiFinis
                                 where st2.CodeMatierePremiere.Equals(code)
                                 select st2;

                if (stockQuery != null)
                {
                    var stock = stockQuery.FirstOrDefault().Quantite;
                    txtStockProduitSFini.Text = stock.ToString();
                }               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Il n'y a pas encore de données dans la liste des produits semi-finis.", ex.Message);
            }
        }

        private void BtnOuvrirFormNouveauProduit_Click(object sender, EventArgs e)
        {
            using (NouveauProduitFiniOuSemiFini np = new NouveauProduitFiniOuSemiFini())
            {
                np.ShowDialog();
            }
        }
    }
}

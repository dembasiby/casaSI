using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_Production : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();        

        public UC_Production()
        {
            InitializeComponent();
        }

        public void ChargerDonneesInitiales()
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.Where(mp => mp.TypeMatiere != "emballage").ToList();
            resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.ToList().OrderBy(p => p.NomProduit);
            resStockProduitsSemiFiniBindingSource2.DataSource = db.ResStockProduitsSemiFinis.ToList();

            MontrerListeProduitsFinis();
            ChargerListeEmployes();

            var nomMatierePrem = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            txtStockMatierePremiereDispo.Text = ChargerStockMatierePremiere(nomMatierePrem).ToString();

            cbxEmballage.DataSource = db.ResStockMatieresPremieres.Where(mp => mp.TypeMatiere == "emballage").ToList();
            cbxEmballage.DisplayMember = "NomMatiere";
            cbxEmballage.ValueMember = "CodeMatierePremiere";
            cbxEmballage.SelectedIndex = -1;

            cbxEtiquettes.DataSource = db.ResStockMatieresPremieres.Where(mp => mp.TypeMatiere == "emballage" && mp.NomMatiere.ToLower().StartsWith("etiquette")).ToList();
            cbxEtiquettes.DisplayMember = "NomMatiere";
            cbxEtiquettes.ValueMember = "CodeMatierePremiere";
            cbxEtiquettes.SelectedIndex = -1;
        }
        
        private float ChargerStockMatierePremiere(string nomMatierePrem)
        {
            return GestionStocks.CalculerSoldeStockMatierePremiere(nomMatierePrem, dtpDateProduction.Value.Date);
        }
        
        private void ChargerListeEmployes()
        {
            ageEmployeBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateProduction).OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();
            ageEmployeBindingSource2.DataSource = Conversion.ListeEmployesPresents(dtpDateProduction).OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();
            ageEmployeBindingSource3.DataSource = Conversion.ListeEmployesPresents(dtpDateProduction).OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();

        }

        // Affiche la liste des travailleurs présent le jour de la production
        private void ChargerListeTravailleurs()
        {

            clbEmployes.Items.Clear();

            var listeEmployes = Conversion
                                .ListeEmployesPresents(dtpDateProduction)
                                .Select(em => em.PrenomNom)
                                .ToList();

            clbEmployes.Items.AddRange(listeEmployes.ToArray());
        }

        private void UC_Production_Load(object sender, EventArgs e)
        {
            ChargerDonneesInitiales();
            ChargerListeTravailleurs();
            ChargerListeEmployes();

            var listProduitsSemiFinis = from em in db.ResStockProduitsSemiFinis
                                        select em.Description;

           
            cbxNomProduitSemiFini.Items.AddRange(listProduitsSemiFinis.ToArray());

            if (cbxNomProduitSemiFini.Items.Count > 0)
            {
                cbxNomProduitSemiFini.SelectedIndex = 0;
            }

            AfficherSoldeStocksProduitsSemiFinis();
        }

        public bool VerifierChampsQuantite (string quantite)
        {
            if (string.IsNullOrEmpty(quantite))
            {
                MessageBox.Show("Le champs 'Quantité' ne peut être vide.");
                return false;
            }

            try
            {
                var item = (quantite == txtQuantiteMatiereP.Text ? Convert.ToSingle(quantite) : Convert.ToInt32(quantite));
            }
            catch (Exception)
            {
                MessageBox.Show("Le champs 'Quantité' doit contenir des nombres.");
                return false;
            }

            return true;
        }

        private void UtiliserEmballage(int codeURes, string emballage, int quantite)
        {
            ResStockMatieresPremiere matP = db.ResStockMatieresPremieres.FirstOrDefault(
                   mp => mp.NomMatiere == emballage);

            EveUtilisationMatieresPremiere uMatP = new EveUtilisationMatieresPremiere
            {
                CodeUtilisationRessource = codeURes,
                CodeMatierePremiere = matP.CodeMatierePremiere,
                QuantiteMatierePremiere = quantite,
            };

            db.EveUtilisationMatieresPremieres.Add(uMatP);
            db.SaveChanges();
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
                QuantiteProduitSemiFini = float.Parse(li.SubItems[1].Text)
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
             where preE.Date == dtpDateProduction.Value.Date
             select preE)
             .ToList()
             .ForEach(em => em.CodeUtilisationDesRessources = codeURessources);
            
            db.SaveChanges();
        }

        private bool ProductionRealiseeParAuMoinsUnEmploye()
        {
            if (clbEmployes.CheckedItems.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Une production doit être réalisée par au moins un employé.");
                return false;
            }        
        }

        private void AjouterRessourcesTravailleurs(int codeURessource)
        {

            for (int i = 0; i < clbEmployes.CheckedItems.Count; i++)
            {
                var trav = clbEmployes.CheckedItems[i].ToString();
                UtiliserTravailleur(trav, codeURessource);
            }    
        }

        private EveProduction CreerProduction(int codeRessource, int codeResProduitsFinis)
        {
            EveProduction prod = new EveProduction
            {
                CodeUtilisationRessources = codeRessource,
                CodeEmploye_Resp_stock_produits_finis = codeResProduitsFinis,
                Date = DateTime.Parse(dtpDateProduction.Text)
            };

            db.EveProductions.Add(prod);
            db.SaveChanges();
            return prod;
        }

    
        
        private void AjouterIntrantsALaListe(string quantite, string element, ListView liste)
        {
            VerifierChampsQuantite(quantite);

            try
            {
                if (float.Parse(quantite) > 0f || int.Parse(quantite) > 0)
                {
                    ListViewItem resultats = new ListViewItem(element)
                    {
                        Name = element
                    };

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
            try
            {
                if (float.Parse(txtStockMatierePremiereDispo.Text) <= 0f || float.Parse(txtStockMatierePremiereDispo.Text) < float.Parse(txtQuantiteMatiereP.Text))
                {
                    MessageBox.Show("Le stock de matière première disponible est insuffisant.");
                    return;
                }

                AjouterIntrantsALaListe(txtQuantiteMatiereP.Text, cbxNomMatiereP.Text, lvwListeMatieresP);
                string matiereSelectionne = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
                txtStockMatierePremiereDispo.Text =
                    (ChargerStockMatierePremiere(matiereSelectionne)
                    - int.Parse(txtQuantiteMatiereP.Text))
                    .ToString();
                txtQuantiteMatiereP.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Merci de vérifier les données entrées.");
                return;
            }
                    
        }

        private void BtnAjouterPSemiFiniProduction_Click(object sender, EventArgs e)
        {
            try
            {
                bool stockSuffisant = (float.Parse(txtStockProduitSFini.Text) > 0f);
                bool stockSuperieurAQuantiteAUtiliser = (float.Parse(txtStockProduitSFini.Text) >= float.Parse(txtQuantiteProduitSemiFiniUtilise.Text));
                Validation.VerifierChampsMontant(txtQuantiteProduitSemiFiniUtilise.Text);

                AjouterIntrantsALaListe(
                txtQuantiteProduitSemiFiniUtilise.Text,
                cbxNomProduitSemiFini.Text,
                lvwListProduitsSemiFinisUtilises);

                txtQuantiteProduitSemiFiniUtilise.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Le stock de matière première disponible est insuffisant.");
                return;
            }
        }

        private void BtnNouvelleProduction_Click(object sender, EventArgs e)
        {
            EnregistrerProduction();
        }

        private bool VerifierInfoIntrantsEtExtrantsProduction()
        {
            if (lvwListeMatieresP.Items.Count == 0 && lvwListProduitsSemiFinisUtilises.Items.Count == 0)
            {
                MessageBox.Show("Il est impératif d'utiliser une matière première ou un produit semi-fini pour réaliser une production.");
                return false;
            }

            if (!Validation.QuantiteSuperieurAZero(txtQuantiteProduitProduit.Text))
            {
                return false;
            }

            if (rbtnProduitsFinis.Checked && int.Parse(cbxEmballage.SelectedIndex.ToString()) < 0)
            {
                MessageBox.Show("Merci de choisir un emballage");
                return false;
            }
            return true;
        }

        private void EnregistrerProduction()
        {
            AgeEmploye respProd = db.AgeEmployes.FirstOrDefault(rp => rp.PrenomNom == cbxResponsableProduction.Text);
            AgeEmploye respStockMatPrem = db.AgeEmployes.FirstOrDefault(rsmp => rsmp.PrenomNom == cbxRespMatPrem.Text);
            AgeEmploye respStockProduitsFinis = db.AgeEmployes.FirstOrDefault(rspf => rspf.PrenomNom == cbxResponsableStockProduitFinis.Text);

            if (VerifierInfoIntrantsEtExtrantsProduction() && ProductionRealiseeParAuMoinsUnEmploye())
            {
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
                string nomProduit = cbxProduitsProduits.GetItemText(cbxProduitsProduits.SelectedItem);

                if (rbtnProduitsFinis.Checked)
                {
                    ResStockProduitsFini npf = db.ResStockProduitsFinis.FirstOrDefault(n => n.NomProduit == nomProduit);
                    string emballage = cbxEmballage.GetItemText(cbxEmballage.SelectedItem);
                    string etiquette = cbxEtiquettes.GetItemText(cbxEtiquettes.SelectedItem);
                    UtiliserEmballage(codeUtilisationRessources, emballage, int.Parse(txtQuantiteProduitProduit.Text));
                    UtiliserEmballage(codeUtilisationRessources, etiquette, int.Parse(txtQuantiteProduitProduit.Text));

                    EveProductionStockProduitsFini prodPFini = new EveProductionStockProduitsFini
                    {
                        CodeProduction = codeProduction,
                        CodeProduitFini = npf.CodeProduit,
                        QuantiteProduitFini = int.Parse(txtQuantiteProduitProduit.Text)
                    };

                    db.EveProductionStockProduitsFinis.Add(prodPFini);
                    db.SaveChanges();                       
                }
                else
                {                    
                    ResStockProduitsSemiFini npsf = db.ResStockProduitsSemiFinis.FirstOrDefault(n => n.Description == nomProduit);
                    EveProductionProduitsSemiFini prodPSFini = new EveProductionProduitsSemiFini
                    {
                        CodeProduction = codeProduction,
                        CodeProduitSemiFini = npsf.CodeProduitSemiFini,
                        QuantiteProduitSemiFini = int.Parse(txtQuantiteProduitProduit.Text)
                    };

                    db.EveProductionProduitsSemiFinis.Add(prodPSFini);
                    db.SaveChanges();
                }

                MessageBox.Show("La production a été enregistrée avec succès.");

                // Effacer les donnees deja enregistrees
                lvwListeMatieresP.Items.Clear();
                cbxEmballage.SelectedIndex = -1;
                txtQuantiteProduitProduit.Clear();
                lvwListProduitsSemiFinisUtilises.Items.Clear();

                var nomMatierePrem = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
                txtStockMatierePremiereDispo.Text = ChargerStockMatierePremiere(nomMatierePrem).ToString();
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
                               select (float?)epsf.QuantiteProduitSemiFini).Sum() ?? 0f;
                var sorties = (from ufsp in db.EveUtilisationProduitsSemiFinis
                               where ufsp.ResStockProduitsSemiFini.Description == prodSF
                               select (float?)ufsp.QuantiteProduitSemiFini).Sum() ?? 0f;

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
            ChargerListeEmployes();
        }

        private void CbxNomMatiereP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matP = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            txtStockMatierePremiereDispo.Text = ChargerStockMatierePremiere(matP).ToString();
        }

        private void RbtnProduitsFinis_CheckedChanged(object sender, EventArgs e)
        {
            MontrerListeProduitsFinis();
        }

        private void RbtnProduitsSemiFinis_CheckedChanged(object sender, EventArgs e)
        {
            MontrerListeProduitsSemiFinis();
        }

        private void MontrerListeProduitsSemiFinis()
        {
            cbxProduitsProduits.DataSource = resStockProduitsSemiFiniBindingSource2;
            cbxProduitsProduits.DisplayMember = "Description";
            cbxProduitsProduits.ValueMember = "CodeProduitSemiFini";
        }

        private void MontrerListeProduitsFinis()
        {
            cbxProduitsProduits.DataSource = resStockProduitsFiniBindingSource;
            cbxProduitsProduits.DisplayMember = "NomProduit";
            cbxProduitsProduits.ValueMember = "CodeProduit";
        }

        private void BtnMettreAJourListeProduits_Click(object sender, EventArgs e)
        {
            ChargerDonneesInitiales();
        }

        private void BtnDiminuerQuantiteMP_Click(object sender, EventArgs e)
        {
            DiminuerQuantite(lvwListeMatieresP);
        }

        private void BtnAugmenterQuantiteMP_Click(object sender, EventArgs e)
        {
            DateTime aujourdhui = DateTime.Today;
            string matiere = lvwListeMatieresP.FocusedItem.SubItems[0].Text;
            float stockMatierePremiere = GestionStocks.CalculerSoldeStockMatierePremiere(matiere, aujourdhui);

            AugmenterQuantite(lvwListeMatieresP, stockMatierePremiere);
        }

        private void BtnRetirerMP_Click(object sender, EventArgs e)
        {
            lvwListeMatieresP.FocusedItem.Remove();
        }

        private void BtnDecrementQuantitePSF_Click(object sender, EventArgs e)
        {
            DiminuerQuantite(lvwListProduitsSemiFinisUtilises);
        }

        private void BtnIncrementQuantitePSF_Click(object sender, EventArgs e)
        {
            DateTime aujourdhui = DateTime.Today;
            string produit = lvwListeMatieresP.FocusedItem.SubItems[0].Text;
            float stockProduitSFinis = GestionStocks.CalculerSoldeStockProduitSemiFini(produit, aujourdhui);

            AugmenterQuantite(lvwListProduitsSemiFinisUtilises, stockProduitSFinis);
        }

        private void BtnRetirerPSF_Click(object sender, EventArgs e)
        {
            lvwListProduitsSemiFinisUtilises.FocusedItem.Remove();
        }

        private void DiminuerQuantite(ListView listView)
        {
            try
            {
                var checkNumber = int.TryParse(listView.FocusedItem.SubItems[1].Text, out int result);
                var total = Convert.ToInt32(listView.FocusedItem.SubItems[1].Text);
           
                total -= 1;
                listView.FocusedItem.SubItems[1].Text = total.ToString();

                if (total == 0)
                {
                    listView.FocusedItem.Remove();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez selectionner un élément dans la liste.", "Erreur de choix d'un produit");
                return;
            }
        }

        private void AugmenterQuantite(ListView listView, float stock)
        {
            try
            {
                var checkNumber = int.TryParse(listView.FocusedItem.SubItems[1].Text, out int result);
                var total = Convert.ToInt32(listView.FocusedItem.SubItems[1].Text);

                if (total < stock)
                {
                    total += 1;
                    listView.FocusedItem.SubItems[1].Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez plus augmenter cette quantité. Il n'y a pas assez de produits en stocks.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez selectionner un élément dans la liste.");
                return;
            }
        }

        private void CbxRespMatPrem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }

        private void CbxResponsableStockProduitFinis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }

        private void CbxResponsableProduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }

        private void CbxEmballage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nomMatierePrem = cbxEmballage.GetItemText(cbxEmballage.SelectedItem);
            txtEmballagesDisponibles.Text = ChargerStockMatierePremiere(nomMatierePrem).ToString();
        }

        private void cbxEtiquettes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nomMatierePrem = cbxEtiquettes.GetItemText(cbxEtiquettes.SelectedItem);
            txtEtiquettesDisponibles.Text = ChargerStockMatierePremiere(nomMatierePrem).ToString();
        }
    }
}

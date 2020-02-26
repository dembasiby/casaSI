using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdateProduction : UserControl
    {
        private int _codeProduction;

        public UC_UpdateProduction()
        {
            InitializeComponent();
        }

        private void UC_UpdateProduction_Load(object sender, EventArgs e)
        {
            AfficherDatesProductions();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherDatesProductions();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherDatesProductions();
        }

        private void DgvListeProductions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListeProductions.Rows[e.RowIndex];
            int codeProduction = int.Parse(row.Cells["Code"].Value.ToString());
            _codeProduction = codeProduction;
            ReloadAll();
            LoadDetailsProduction(_codeProduction);
        }

        private void BtnMettreProductionAJour_Click(object sender, EventArgs e)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var production = db.EveProductions.Where(prod => prod.CodeProduction == _codeProduction).First();
                    bool cestUnFruit = CEstUnQuiEstFruitUtilise(_codeProduction);

                    // Vérifier intrants
                    if (cestUnFruit)
                    {
                        MettreIntrantFruitAJour(_codeProduction);
                    }
                    else
                    {
                        MettreIntrantProduitSemiFiniAJour(_codeProduction);
                    }

                    if (CEstUnProduitFini(_codeProduction))
                    {
                        string nomProduit = cbxProduitFini.GetItemText(cbxProduitFini.SelectedItem);

                        if (!IlYAvaitDuSucre(_codeProduction))
                        {
                            AjouterSucre(production);
                            MessageBox.Show("La production a été mise à jour.");
                        }
                        else if (float.Parse(txtQuantiteSucre.Text) != production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                            .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Sucre")
                            .Select(ump => ump.QuantiteMatierePremiere).FirstOrDefault())
                        {
                            MettreQuantiteSucreAJour(production);
                            MessageBox.Show("La quantité de sucre a été mise à jour.");
                        }

                        MettreProduitFiniAJour(_codeProduction);

                        if (nomProduit.ToLower().StartsWith("sachet") || nomProduit.ToLower().StartsWith("pastille"))
                        {
                            MettreEmballageAJour(_codeProduction, "sachet");
                        }
                        else
                        {
                            MettreEmballageAJour(_codeProduction, "emballage");
                            MettreEtiquetteAJour(_codeProduction);
                        }
                    }
                    else
                    {
                        MettreProduitSemiFiniAJour(_codeProduction);
                    }

                    MessageBox.Show("La production a été mise à jour.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur d'enregisrement: la production n'a pas été enregistrée.");
                }
            }
        }


        /***************************************************************
            FONCTIONS D'AFFICHAGE DES DONNEES
        /***************************************************************/

        private void ReloadAll()
        {
            // throw new NotImplementedException();
        }

        private void AfficherDatesProductions()
        {
            Production.AfficherDatesProduction(dtpDebut, dtpFin, dgvListeProductions);
        }

        private void LoadDetailsProduction(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    AfficherDetailsIntrants(codeProduction);

                    if (CEstUnProduitFini(codeProduction))
                    {
                        AfficherDetailsProductionProduitFini(codeProduction);
                    }
                    else
                    {
                        AfficherDetailsProductionProduitSemiFini(codeProduction);
                    }                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur d'affichage");
                }
            }
        }

        private void AfficherDetailsIntrants(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();
                bool cestUnFruit = CEstUnQuiEstFruitUtilise(codeProduction);

                if (cestUnFruit)
                {
                    AfficherDetailsIntrantFruit(codeProduction);                   
                }
                else
                {
                    AfficherDetailsIntrantsProduitSemiFini(codeProduction);
                }

                AfficherEmballage(codeProduction);
                txtQuantiteSucre.Text = QuantiteDeSucre(codeProduction);
            }
        }

       private void AfficherEmballage(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();
                AfficherEtiquettes(production);
                AfficherBouteillesOuSachets(production);
            }
        }

        private void AfficherBouteillesOuSachets(EveProduction production)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                cbxEmballage.DataSource = db.ResStockMatieresPremieres
                    .Where(mp => mp.TypesMatiere.NomType == "Emballage" || mp.TypesMatiere.NomType == "Sachet")
                    .OrderBy(mp => mp.NomMatiere)
                    .ToList();

                cbxEmballage.DisplayMember = "NomMatiere";
                cbxEmballage.ValueMember = "CodeMatierePremiere";
                cbxEmballage.SelectedValue = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Emballage" || mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Sachet")
                    .Select(mp => mp.ResStockMatieresPremiere.CodeMatierePremiere)
                    .FirstOrDefault();
            }
        }

        private void AfficherEtiquettes(EveProduction production)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                cbxEtiquette.DataSource = db.ResStockMatieresPremieres
                    .Where(mp => mp.TypesMatiere.NomType == "Etiquette")
                    .OrderBy(mp => mp.NomMatiere)
                    .ToList();

                cbxEtiquette.DisplayMember = "NomMatiere";
                cbxEtiquette.ValueMember = "CodeMatierePremiere";
                cbxEtiquette.SelectedValue = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Etiquette")
                    .Select(mp => mp.ResStockMatieresPremiere.CodeMatierePremiere)
                    .FirstOrDefault();
            }
        }

        private void AfficherDetailsIntrantFruit(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                cbxFruitUtilise.DataSource = db.ResStockMatieresPremieres
                        .Where(mp => mp.TypesMatiere.NomType == "Fruit")
                        .OrderBy(pf => pf.NomMatiere)
                        .ToList();

                cbxFruitUtilise.DisplayMember = "NomMatiere";
                cbxFruitUtilise.ValueMember = "CodeMatierePremiere";

                cbxFruitUtilise.SelectedValue = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Fruit")
                    .Select(mp => mp.ResStockMatieresPremiere.CodeMatierePremiere)
                    .FirstOrDefault();

                txtQuantiteFruit.Text = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Fruit")
                    .Select(mp => mp.QuantiteMatierePremiere)
                    .FirstOrDefault().ToString();
            }
        }

        private void AfficherDetailsIntrantsProduitSemiFini(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                cbxFruitUtilise.DataSource = db.ResStockProduitsSemiFinis
                        .OrderBy(psf => psf.Description)
                        .ToList();

                cbxFruitUtilise.DisplayMember = "Description";
                cbxFruitUtilise.ValueMember = "CodeProduitSemiFini";

                cbxFruitUtilise.SelectedValue = production.EveUtilisationRessource.EveUtilisationProduitsSemiFinis
                    .Select(mp => mp.CodeProduitSemiFini)
                    .FirstOrDefault();

                txtQuantiteFruit.Text = production.EveUtilisationRessource.EveUtilisationProduitsSemiFinis
                    .Select(psf => psf.QuantiteProduitSemiFini)
                    .FirstOrDefault().ToString();
            }
        }

        private void AfficherDetailsProductionProduitSemiFini(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                cbxProduitFini.DataSource = db.ResStockProduitsSemiFinis.OrderBy(pf => pf.Description).ToList();
                cbxProduitFini.DisplayMember = "Description";
                cbxProduitFini.ValueMember = "CodeProduitSemiFini";
                cbxProduitFini.SelectedValue = production.EveProductionProduitsSemiFinis
                    .Where(ppf => ppf.CodeProduction == codeProduction)
                    .Select(pf => pf.ResStockProduitsSemiFini.CodeProduitSemiFini)
                    .FirstOrDefault();

                var productionProduitSemiFini = production.EveProductionProduitsSemiFinis
                    .Where(ppf => ppf.CodeProduction == codeProduction)
                    .FirstOrDefault();
                txtNombreProduitsFinis.Text = productionProduitSemiFini.QuantiteProduitSemiFini.ToString();
            }
        }

        private void AfficherDetailsProductionProduitFini(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                cbxProduitFini.DataSource = db.ResStockProduitsFinis.OrderBy(pf => pf.NomProduit).ToList();
                cbxProduitFini.DisplayMember = "NomProduit";
                cbxProduitFini.ValueMember = "CodeProduit";
                cbxProduitFini.SelectedValue = production.EveProductionStockProduitsFinis
                    .Where(ppf => ppf.CodeProduction == codeProduction)
                    .Select(pf => pf.ResStockProduitsFini.CodeProduit)
                    .FirstOrDefault();

                var productionProduitFini = production.EveProductionStockProduitsFinis
                    .Where(ppf => ppf.CodeProduction == codeProduction)
                    .FirstOrDefault();
                txtNombreProduitsFinis.Text = productionProduitFini.QuantiteProduitFini.ToString();
            }
        }

        /***************************************************************
             HELPERS
        /***************************************************************/

        private string QuantiteDeSucre(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                return production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                        .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Sucre")
                        .Select(mp => mp.QuantiteMatierePremiere)
                        .FirstOrDefault().ToString();
            }
        }

        private void AjouterSucre(EveProduction production)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    float.TryParse(txtQuantiteSucre.Text, out float quantiteSucre);

                    ResStockMatieresPremiere matP = db.ResStockMatieresPremieres.FirstOrDefault(
                    mp => mp.TypesMatiere.NomType == "Sucre");

                    int codeURes = production.EveUtilisationRessource.CodeUtilisationRessources;

                    EveUtilisationMatieresPremiere uMatP = new EveUtilisationMatieresPremiere
                    {
                        CodeUtilisationRessource = codeURes,
                        CodeMatierePremiere = matP.CodeMatierePremiere,
                        QuantiteMatierePremiere = quantiteSucre
                    };

                    db.EveUtilisationMatieresPremieres.Add(uMatP);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Veuillez mettre un nombre valide dans le champ 'Quantité de sucre");
                    return;
                }
            }
        }



        private void MettreQuantiteSucreAJour(EveProduction production)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    float.TryParse(txtQuantiteSucre.Text, out float quantiteSucre);

                    EveUtilisationMatieresPremiere utilisationSucre = (from p in db.EveProductions
                                                                       where p.CodeProduction == production.CodeProduction
                                                                       join ur in db.EveUtilisationRessources on p.CodeUtilisationRessources equals ur.CodeUtilisationRessources
                                                                       join ump in db.EveUtilisationMatieresPremieres on ur.CodeUtilisationRessources equals ump.CodeUtilisationRessource
                                                                       where ump.ResStockMatieresPremiere.NomMatiere == "Sucre en poudre"
                                                                       select ump).FirstOrDefault();

                    utilisationSucre.QuantiteMatierePremiere = quantiteSucre;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("La quantité de sucre n'a pas été mise à jour.");
                    return;
                }
            }
        }

        private bool CEstUnProduitFini(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var prodution = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                return prodution.EveProductionStockProduitsFinis
                        .Any(pf => pf.ResStockProduitsFini.NomProduit != null);
            }
        }

        private bool CEstUnQuiEstFruitUtilise(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var prodution = db.EveProductions.Where(prod => prod.CodeProduction == codeProduction).First();

                return prodution.EveUtilisationRessource.EveUtilisationMatieresPremieres
                        .Any(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Fruit");
            }
        }

        private bool IlYAvaitDuSucre(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var production = db.EveProductions.Where(p => p.CodeProduction == codeProduction).FirstOrDefault();
                bool prodAvecSucre = production
                    .EveUtilisationRessource
                    .EveUtilisationMatieresPremieres
                    .Any(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Sucre");
                return prodAvecSucre;
            }
        }

        private void MettreProduitFiniAJour(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    EveProductionStockProduitsFini productionProduitFini = (from p in db.EveProductions
                                                 where p.CodeProduction == _codeProduction
                                                 join ppf in db.EveProductionStockProduitsFinis on p.CodeProduction equals ppf.CodeProduction
                                                 select ppf).FirstOrDefault();

                    string produitFini = productionProduitFini.ResStockProduitsFini.NomProduit;
                    int.TryParse(txtNombreProduitsFinis.Text, out int quantite);

                    if (produitFini != cbxProduitFini.Text)
                    {
                        int.TryParse(cbxProduitFini.SelectedValue.ToString(), out int codeProduitFini);
                        db.EveProductionStockProduitsFinis.Remove(productionProduitFini);
                        db.SaveChanges();

                        EveProductionStockProduitsFini newProdProduitFini = new EveProductionStockProduitsFini
                        {
                            CodeProduitFini = codeProduitFini,
                            CodeProduction = codeProduction,
                            QuantiteProduitFini = quantite
                        };

                        db.EveProductionStockProduitsFinis.Add(newProdProduitFini);
                        db.SaveChanges();
                    }

                    if (productionProduitFini.QuantiteProduitFini != quantite)
                    {                     
                        productionProduitFini.QuantiteProduitFini = quantite;
                        int codeUtilisationRess = productionProduitFini.EveProduction.CodeUtilisationRessources;
                        var utilisationRess = db.EveUtilisationRessources.Where(ur => ur.CodeUtilisationRessources == codeUtilisationRess).FirstOrDefault();

                        EveUtilisationMatieresPremiere utilisationEmballage;

                        if (!produitFini.ToLower().StartsWith("sachet") && !produitFini.ToLower().StartsWith("pastille"))
                        {
                            var utilisationEtiquette = utilisationRess.EveUtilisationMatieresPremieres
                                                    .Where(ump => ump.ResStockMatieresPremiere.TypesMatiere.NomType.ToLower() == "etiquette")
                                                    .FirstOrDefault();

                            utilisationEmballage = utilisationRess.EveUtilisationMatieresPremieres
                                                    .Where(ump => ump.ResStockMatieresPremiere.TypesMatiere.NomType.ToLower() == "emballage")
                                                    .FirstOrDefault();

                            utilisationEtiquette.QuantiteMatierePremiere = quantite;
                            utilisationEmballage.QuantiteMatierePremiere = quantite;
                        }
                        else
                        {
                            utilisationEmballage = utilisationRess.EveUtilisationMatieresPremieres
                                                    .Where(ump => ump.ResStockMatieresPremiere.TypesMatiere.NomType.ToLower() == "sachet")
                                                    .FirstOrDefault();

                            utilisationEmballage.QuantiteMatierePremiere = quantite;
                        }

                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erreur de correction. Verifier la quantité de produits finis.");
                }              
            }
        }

        private void MettreProduitSemiFiniAJour(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    EveProductionProduitsSemiFini productionProduitSemiFini = (from p in db.EveProductions
                                                                            where p.CodeProduction == _codeProduction
                                                                            join ppsf in db.EveProductionProduitsSemiFinis on p.CodeProduction equals ppsf.CodeProduction
                                                                            select ppsf).FirstOrDefault();

                    string produitFini = productionProduitSemiFini.ResStockProduitsSemiFini.Description;
                    int.TryParse(txtNombreProduitsFinis.Text, out int quantite);

                    if (produitFini != cbxProduitFini.Text)
                    {
                        int.TryParse(cbxProduitFini.SelectedValue.ToString(), out int codeProduitSemiFini);
                        db.EveProductionProduitsSemiFinis.Remove(productionProduitSemiFini);
                        db.SaveChanges();

                        EveProductionProduitsSemiFini newProdProduitSemiFini = new EveProductionProduitsSemiFini
                        {
                            CodeProduitSemiFini = codeProduitSemiFini,
                            CodeProduction = codeProduction,
                            QuantiteProduitSemiFini = quantite
                        };

                        db.EveProductionProduitsSemiFinis.Add(newProdProduitSemiFini);
                        db.SaveChanges();
                    }

                    if (productionProduitSemiFini.QuantiteProduitSemiFini != quantite)
                    {
                        productionProduitSemiFini.QuantiteProduitSemiFini = quantite;
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de correction. Verifier la quantité de produits semi finis.");
                }
            }
        }

        private void MettreIntrantFruitAJour(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var production = db.EveProductions.Where(p => p.CodeProduction == codeProduction).FirstOrDefault();
                    var fruitUtilise = production.EveUtilisationRessource
                        .EveUtilisationMatieresPremieres
                        .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Fruit")
                        .FirstOrDefault();

                    var fruit = fruitUtilise.ResStockMatieresPremiere.NomMatiere;

                    if (fruit != cbxFruitUtilise.Text)
                    {
                        fruitUtilise.CodeMatierePremiere = int.Parse(cbxFruitUtilise.SelectedValue.ToString());
                        db.SaveChanges();
                    }

                    if (fruitUtilise.QuantiteMatierePremiere != float.Parse(txtQuantiteFruit.Text))
                    {
                        float.TryParse(txtNombreProduitsFinis.Text, out float quantite);
                        fruitUtilise.QuantiteMatierePremiere = quantite;
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de correction. Verifier la quantité de matière première.");
                }
            }
        }


        private void MettreIntrantProduitSemiFiniAJour(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var production = db.EveProductions.Where(p => p.CodeProduction == codeProduction).FirstOrDefault();
                    var produitSemiFiniUtilise = production.EveUtilisationRessource
                        .EveUtilisationProduitsSemiFinis
                        .FirstOrDefault();

                    var produitSemiFini = produitSemiFiniUtilise.ResStockProduitsSemiFini.Description;

                    if (produitSemiFini != cbxFruitUtilise.Text)
                    {
                        produitSemiFiniUtilise.CodeProduitSemiFini = int.Parse(cbxFruitUtilise.SelectedValue.ToString());
                        db.SaveChanges();
                    }

                    if (produitSemiFiniUtilise.QuantiteProduitSemiFini != float.Parse(txtQuantiteFruit.Text))
                    {
                        float.TryParse(txtNombreProduitsFinis.Text, out float quantite);
                        produitSemiFiniUtilise.QuantiteProduitSemiFini = quantite;
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de correction. Verifier la quantité de produit semi fini.");
                }
            }
        }

        private void MettreEmballageAJour(int codeProduction, string typeEmballage)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var production = db.EveProductions.Where(p => p.CodeProduction == codeProduction).FirstOrDefault();
                    var emballageUtilise = production.EveUtilisationRessource
                        .EveUtilisationMatieresPremieres
                        .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType.ToLower() == typeEmballage)
                        .FirstOrDefault();

                    var emballage = emballageUtilise.ResStockMatieresPremiere.NomMatiere;
                    var emballageSelectionne = cbxEmballage.GetItemText(cbxEmballage.SelectedItem);

                    int.TryParse(txtNombreProduitsFinis.Text, out int quantite);

                    if (emballage != emballageSelectionne)
                    {
                        db.EveUtilisationMatieresPremieres.Remove(emballageUtilise);
                        db.SaveChanges();

                        EveUtilisationMatieresPremiere utilisationEmballage = new EveUtilisationMatieresPremiere
                        {
                            CodeUtilisationRessource = production.CodeUtilisationRessources,
                            CodeMatierePremiere = int.Parse(cbxEmballage.SelectedValue.ToString()),
                            QuantiteMatierePremiere = quantite
                        };

                        db.EveUtilisationMatieresPremieres.Add(utilisationEmballage);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de correction. L'emballage n'a pas été mis à jour.");
                }
            }
        }


        private void MettreEtiquetteAJour(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var production = db.EveProductions.Where(p => p.CodeProduction == codeProduction).FirstOrDefault();
                    var etiquetteUtilise = production.EveUtilisationRessource
                        .EveUtilisationMatieresPremieres
                        .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.NomType == "Etiquette")
                        .FirstOrDefault();

                    var etiquette = etiquetteUtilise.ResStockMatieresPremiere.NomMatiere;
                    var etiquetteSelectionne = cbxEtiquette.GetItemText(cbxEtiquette.SelectedItem);

                    int.TryParse(txtNombreProduitsFinis.Text, out int quantite);


                    if (etiquette != etiquetteSelectionne)
                    {
                        db.EveUtilisationMatieresPremieres.Remove(etiquetteUtilise);
                        db.SaveChanges();

                        EveUtilisationMatieresPremiere utilisationEtiquette = new EveUtilisationMatieresPremiere
                        {
                            CodeUtilisationRessource = production.CodeUtilisationRessources,
                            CodeMatierePremiere = int.Parse(cbxEtiquette.SelectedValue.ToString()),
                            QuantiteMatierePremiere = quantite
                        };

                        db.EveUtilisationMatieresPremieres.Add(utilisationEtiquette);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de correction. L'etiquette n'a pas été mise à jour.");
                }
            }
        }

        private void BtnSupprimerProduction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette production?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SupprimerProduction(_codeProduction);
                ReloadAll();
            }
        }

        private void SupprimerProduction(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    // production
                    var production = db.EveProductions.Where(p => p.CodeProduction == codeProduction).First();
                    var utilisationRessources = production.EveUtilisationRessource;
 
                    // production produit fini
                    var productionProduitFini = production.EveProductionStockProduitsFinis.FirstOrDefault();
                    if (productionProduitFini != null)
                    {
                        db.EveProductionStockProduitsFinis.Remove(productionProduitFini);
                    }
                    // production produit semi fini
                    var productionProduitSemiFini = production.EveProductionProduitsSemiFinis.FirstOrDefault();
                    if (productionProduitSemiFini != null)
                    {
                        db.EveProductionProduitsSemiFinis.Remove(productionProduitSemiFini);
                    }
                    // utilisation ressources
                    // utilisation mat premiere
                    var useMatPr = utilisationRessources.EveUtilisationMatieresPremieres.ToList();
                    if (useMatPr.Count > 0)
                    {
                        foreach (var item in useMatPr)
                        {
                            db.EveUtilisationMatieresPremieres.Remove(item);
                        }
                    }
                    //utilisation produit semi fini
                    var usePrdtSFini = utilisationRessources.EveUtilisationProduitsSemiFinis.ToList();
                    if (usePrdtSFini.Count > 0)
                    {
                        foreach (var item in usePrdtSFini)
                        {
                            db.EveUtilisationProduitsSemiFinis.Remove(item);
                        }
                    }

                    db.EveProductions.Remove(production);
                    db.EveUtilisationRessources.Remove(utilisationRessources);
                    db.SaveChanges();
                    MessageBox.Show("La production a été supprimée.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur: la production n'a pas été supprimée.");
                }
            }            
        }

        private void CbxProduitFini_SelectedIndexChanged(object sender, EventArgs e)
        {
            Production.ActiverListeEtiquettes(cbxProduitFini, cbxEtiquette);
        }
    }
}

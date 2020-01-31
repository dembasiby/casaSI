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

                    if (!IlYAvaitDuSucre(_codeProduction))
                    {
                        AjouterSucre(production);
                        MessageBox.Show("La production a été mise à jour.");
                    }
                    else
                    {
                        MettreQuantiteSucreAJour(production);
                        MessageBox.Show("La quantité de sucre a été mise à jour.");
                    }
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
                    .Where(mp => mp.TypesMatiere.nomType == "Emballage" || mp.TypesMatiere.nomType == "Sachet")
                    .OrderBy(mp => mp.NomMatiere)
                    .ToList();

                cbxEmballage.DisplayMember = "NomMatiere";
                cbxEmballage.ValueMember = "CodeMatierePremiere";
                cbxEmballage.SelectedValue = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Emballage" || mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Sachet")
                    .Select(mp => mp.ResStockMatieresPremiere.CodeMatierePremiere)
                    .FirstOrDefault();
            }
        }

        private void AfficherEtiquettes(EveProduction production)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                cbxEtiquette.DataSource = db.ResStockMatieresPremieres
                    .Where(mp => mp.TypesMatiere.nomType == "Etiquette")
                    .OrderBy(mp => mp.NomMatiere)
                    .ToList();

                cbxEtiquette.DisplayMember = "NomMatiere";
                cbxEtiquette.ValueMember = "CodeMatierePremiere";
                cbxEtiquette.SelectedValue = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Etiquette")
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
                        .Where(mp => mp.TypesMatiere.nomType == "Fruit")
                        .OrderBy(pf => pf.NomMatiere)
                        .ToList();

                cbxFruitUtilise.DisplayMember = "NomMatiere";
                cbxFruitUtilise.ValueMember = "CodeMatierePremiere";

                cbxFruitUtilise.SelectedValue = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Fruit")
                    .Select(mp => mp.ResStockMatieresPremiere.CodeMatierePremiere)
                    .FirstOrDefault();

                txtQuantiteFruit.Text = production.EveUtilisationRessource.EveUtilisationMatieresPremieres
                    .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Fruit")
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
                        .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Sucre")
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
                    mp => mp.TypesMatiere.nomType == "Sucre");

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

                    EveUtilisationMatieresPremiere utilisationSucre = production
                        .EveUtilisationRessource
                        .EveUtilisationMatieresPremieres
                        .Where(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Sucre")
                        .FirstOrDefault();

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
                        .Any(mp => mp.ResStockMatieresPremiere.TypesMatiere.nomType == "Fruit");
            }
        }

        private bool IlYAvaitDuSucre(int codeProduction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                return false;
            }
        }

        

    }
}

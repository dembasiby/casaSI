using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_Transvasage : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_Transvasage()
        {
            InitializeComponent();
        }

        private void UC_Transvasage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnTransvaser_Click(object sender, EventArgs e)
        {
            Transvaser();
        }

        // HELPERS METHODS

        private void LoadData()
        {
            cbxEmballageInitial.DataSource = db.ResStockMatieresPremieres
                .Where(mp => mp.TypesMatiere.nomType == "Emballage")
                .OrderBy(n => n.NomMatiere)
                .ToList();

            cbxEmballageFinal.DataSource = db.ResStockMatieresPremieres
                .Where(mp => mp.TypesMatiere.nomType == "Emballage")
                .OrderBy(n => n.NomMatiere)
                .ToList();

            cbxProduitInitial.DataSource = db.ResStockProduitsFinis.OrderBy(p => p.NomProduit).ToList();
            cbxProduitFinal.DataSource = db.ResStockProduitsFinis.OrderBy(p => p.NomProduit).ToList();

            DefinirDisplayMemberEtValueMember();
        }

        private void LierDonnees(ComboBox ctr, string display, string value)
        {
            ctr.DisplayMember = display;
            ctr.ValueMember = value;
        }

        private void LierDonneesEmballage(ComboBox ctr)
        {
            LierDonnees(ctr, "NomMatiere", "CodeMatierePremiere");
        }

        private void LierDonneesProduit(ComboBox ctr)
        {
            LierDonnees(ctr, "NomProduit", "CodeProduit");
        }

        private void DefinirDisplayMemberEtValueMember()
        {
            LierDonneesEmballage(cbxEmballageInitial);
            LierDonneesEmballage(cbxEmballageFinal);
            LierDonneesProduit(cbxProduitInitial);
            LierDonneesProduit(cbxProduitFinal);
        }

        private void Transvaser()
        {    
            DefinirDisplayMemberEtValueMember();

            if (Validation.VerifierChampsMontant(txtQuantiteATransvaser.Text) 
                && cbxEmballageInitial.Text != cbxEmballageFinal.Text
                && cbxProduitInitial.Text != cbxProduitFinal.Text)
            {
                EveTransvasement transv = new EveTransvasement
                {
                    DateOperation = dtpDateTransvasage.Value.Date,
                    CodeEmballageInitial = Convert.ToInt32(cbxEmballageInitial.SelectedValue.ToString()),
                    CodeEmballageFinal = Convert.ToInt32(cbxEmballageFinal.SelectedValue.ToString()),
                    CodeProduitInitial = Convert.ToInt32(cbxProduitInitial.SelectedValue.ToString()),
                    CodeProduitFinal = Convert.ToInt32(cbxProduitFinal.SelectedValue.ToString()),
                    QuantiteATransvaser = Convert.ToInt32(txtQuantiteATransvaser.Text)
                };

                db.EveTransvasements.Add(transv);
                db.SaveChanges();
                MessageBox.Show("L'opération de transvasement a été enregistrée avec succès.");
                txtQuantiteATransvaser.Clear();
            }
            else
            {
                MessageBox.Show("Enregistrement annulé. Veuillez vérifier les données des champs.");
                return;
            }
        }
    }
}

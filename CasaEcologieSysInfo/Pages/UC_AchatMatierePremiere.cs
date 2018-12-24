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
    public partial class UC_AchatMatierePremiere : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_AchatMatierePremiere()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
           
            ageFournisseursMatieresPremieresBindingSource.DataSource = db.AgeFournisseursMatieresPremieres.ToList();
            resStockMatieresPremieresBindingSource.DataSource = db.ResStockMatieresPremieres.ToList();
            ageEmployesBindingSource.DataSource = db.AgeEmployes.ToList();
            ageEmployesBindingSource1.DataSource = db.AgeEmployes.ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
           
        }

        private void UC_AchatMatierePremiere_Load(object sender, EventArgs e)
        {
            DateTimePicker myPicker = new DateTimePicker
            {
                Value = DateTime.Now
            };
            LoadData();
            
        }

        private void BtnAjouterNouvelleMatierePremiere_Click(object sender, EventArgs e)
        {
           
            ResStockMatieresPremiere matierePremiere = new ResStockMatieresPremiere
            {
                NomMatiere = txtNomMatierePremiere.Text,
                StockMatiere = int.Parse(txtStockInitial.Text)
            };

            db.ResStockMatieresPremieres.Add(matierePremiere);
            db.SaveChanges();
            txtNomMatierePremiere.Text = "";
            txtStockInitial.Text = "00";
            MessageBox.Show("Une nouvelle matière première a été ajoutée avec succès");
            LoadData();
            
        }

        private void AjouterNouvelleAchatMatierePremiere()
        {          
            ResStockMatieresPremiere matPrem = db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
            AgeFournisseursMatieresPremiere fournMp = db.AgeFournisseursMatieresPremieres.FirstOrDefault(fmp => fmp.Nom == cbxFournisseurMPrem.Text);
            AgeEmploye resStocks = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxRespStocks.Text);
            AgeEmploye tresoriere = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxTresoriere.Text);
            ResComptesTresorerie tres = db.ResComptesTresoreries.FirstOrDefault(tr => tr.NomCompte == cbxComptePaiement.Text);


            EveReceptionMatieresPremiere achatMatiere = new EveReceptionMatieresPremiere
            {
                CodeMatierePremiere = matPrem.CodeMatierePremiere,
                DateReception = DateTime.Parse(dtpDateApprovisionnement.Text),
                Quantite = int.Parse(txtQuantite.Text),
                Montant = int.Parse(txtMontant.Text),
                CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                CodeEmploye = resStocks.CodeEmploye,
            };
            /*
            matPrem.StockMatiere += int.Parse(txtQuantite.Text);
            fournMp.SoldeDette += int.Parse(txtMontant.Text);
            fournMp.SoldeDette -= int.Parse(txtMontantPaye.Text);
            txtLocaliteFournisseur.Text = fournMp.Localite; 
            */
            if (int.Parse(txtMontantPaye.Text) > 0)
            {
                EveDecaissement decaiss = new EveDecaissement
                {
                    CodeReceptionMatierePremiere = achatMatiere.CodeReceptionMatierePremiere,
                    CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                    Description = "Achat de " + matPrem.NomMatiere,
                    DateDecaissement = achatMatiere.DateReception,
                    CodeEmploye = tresoriere.CodeEmploye,
                    CodeCompte = tres.CodeCompte,
                    Montant = int.Parse(txtMontantPaye.Text),
                };
                tres.SoldeCompte -= int.Parse(txtMontantPaye.Text);
                db.EveDecaissements.Add(decaiss);
            }
            db.EveReceptionMatieresPremieres.Add(achatMatiere);
            db.SaveChanges();
            
        }

        private void BtnEnregistrerAchatMatierePremiere_Click(object sender, EventArgs e)
        {
            try
            {
                AjouterNouvelleAchatMatierePremiere();
                MessageBox.Show("Un nouvel achat de matière première a été enregistré avec succès");
                txtQuantite.Text = "";
                txtMontant.Text = "";
                txtMontantPaye.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur {0}", ex.Message);
            }           
        }

        
    }
}

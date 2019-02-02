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
    public partial class UC_NouveauDecaissement : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_NouveauDecaissement()
        {
            InitializeComponent();
        }

        private List<string> ListeDesFournisseursDeMatierePremiereAPayer()
        {
            return (from fmp in db.AgeFournisseursMatieresPremieres
                    select new
                    {
                        NomFournisseur = fmp.Nom,
                        Solde = ((decimal?)fmp.SoldeDette ?? 0m) 
                        + ((decimal?)fmp.EveReceptionMatieresPremieres.Sum(s => s.Montant) ?? 0m) 
                        - ((decimal?)fmp.EveDecaissements.Sum(m => m.Montant) ?? 0m)
                    })
                    .OrderByDescending(s => s.Solde)
                    .Where(s => s.Solde > 0)
                    .Select(f => f.NomFournisseur)
                    .ToList();
        }

        private decimal CalculerSoldeDetteFournisseurMatierePremiere(string nomFournisseur)
        {
            return (from fmp in db.AgeFournisseursMatieresPremieres
                    where fmp.Nom == nomFournisseur
                    select new
                    {
                        NomFournisseur = fmp.Nom,
                        SoldeInitial = (decimal?)fmp.SoldeDette ?? 0m,
                        Achat = fmp.EveReceptionMatieresPremieres.Select(s => (decimal?)s.Montant).Sum() ?? 0m,
                        Paiements = fmp.EveDecaissements.Select(m => (decimal?)m.Montant).Sum() ?? 0m
                    })
                     .Sum(f => f.SoldeInitial + f.Achat - f.Paiements);
        }

        private List<string> ListeDesFournisseursDEquipementEtInfrastructuresAPayer()
        {
            return (from af in db.AgeAutreFournisseurs
                    select new
                    {
                        NomFournisseur = af.NomAutreFournisseur,
                        Solde = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(d => d.Montant).Sum() ?? 0m + (decimal?)af.SoldeInitialDetteFournisseur ?? 0m
                        - (decimal?)af.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                    })
                    .OrderByDescending(s => s.Solde)
                    .Where(s => s.Solde > 0)
                    .Select(f => f.NomFournisseur)
                    .ToList();
        }

        private decimal CalculerSoldeDetteFournisseurEquipementsEtInfrastructure(string nomFournisseur)
        {
            return (from af in db.AgeAutreFournisseurs
                    where af.NomAutreFournisseur == nomFournisseur
                    select new
                    {
                        Solde = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(d => d.Montant).Sum() ?? 0m + (decimal?)af.SoldeInitialDetteFournisseur ?? 0m
                        - (decimal?)af.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                    })
                    .Select(f => f.Solde)
                    .FirstOrDefault();
        }

        private List<string> ListeDesFournisseursDeServicesEtFournituresAPayer()
        {
            return (from f in db.AgeFournisseursServicesFournitures
                    select new
                    {
                        NomFournisseur = f.NomFournisseurServiceFourniture,
                        Solde = (decimal?)f.SoldeDette ?? 0m + (decimal?)f.EveAcquisitionServicesFournitures.Select(d => d.Montant).Sum() ?? 0m
                        - (decimal?)f.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                    })
                    .OrderByDescending(s => s.Solde)
                    .Where(s => s.Solde > 0)
                    .Select(f => f.NomFournisseur)
                    .ToList();
        }

        private decimal CalculerSoldeDetteFournisseurServicesEtFournitures(string nomFournisseur)
        {
            return (from f in db.AgeFournisseursServicesFournitures
                    where f.NomFournisseurServiceFourniture == nomFournisseur
                    select new
                    {
                        Solde = (decimal?)f.SoldeDette ?? 0m + (decimal?)f.EveAcquisitionServicesFournitures.Select(d => d.Montant).Sum() ?? 0m
                        - (decimal?)f.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                    })                  
                    .Select(f => f.Solde)
                    .FirstOrDefault();
        }

       
        private void DefinirListeDesFournisseursAAfficher()
        {
            if (cbxTypeFournisseur.Text == "Fournisseur de matière première")
            {
                cbxNomFournisseur.DataSource = ListeDesFournisseursDeMatierePremiereAPayer();
                
            }
            else if (cbxTypeFournisseur.Text == "Fournisseur d'équipement ou entrepreneur")
            {
                cbxNomFournisseur.DataSource = ListeDesFournisseursDEquipementEtInfrastructuresAPayer();             
            }
            else if (cbxTypeFournisseur.Text == "Fournisseur de services ou fournitures")
            {
                cbxNomFournisseur.DataSource = ListeDesFournisseursDeServicesEtFournituresAPayer();                
            }            
        }

        private void AfficherDetteDuFournisseurSelectionne()
        {
            var nomFournisseur = cbxNomFournisseur.GetItemText(cbxNomFournisseur.SelectedItem);
            txtDetteFournisseur.Text = Conversion.CalculerSoldeDetteParFournisseur(nomFournisseur).ToString("c0"); 
        }

        private bool VerifierChampsMontantEncaisse()
        {
            var nomCompte = cbxCompte.GetItemText(cbxCompte.SelectedItem);
            var soldeCompte = Conversion.SoldeDisponibleDuCompteDeTresorerie(nomCompte);

            if (string.IsNullOrEmpty(txtMontantPaye.Text))
            {
                MessageBox.Show("Ce champs doit être renseigné.");
                return false;
            }
           

            try
            {
                int temp = Convert.ToInt32(txtMontantPaye.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce champs doit contenir uniquement des nombres.");
                return false;
            }

            try
            {
                bool verif = int.Parse(txtMontantPaye.Text) < soldeCompte;
            }
            catch (Exception)
            {

                MessageBox.Show("Il n'y a pas assez de fonds dans le compte séléctionné pour effectuer ce paiement. Veuillez changer de compte ou diminuer le montant.");
                return false;
            }

            return true;
        }


        private void CbxTypeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefinirListeDesFournisseursAAfficher();
            AfficherDetteDuFournisseurSelectionne();
        }

        private void UC_NouveauDecaissement_Load(object sender, EventArgs e)
        {
            DefinirListeDesFournisseursAAfficher();
            ageEmployeBindingSource.DataSource = db.AgeEmployes.ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();

            var nomCompte = cbxCompte.GetItemText(cbxCompte.SelectedItem);
            txtSoldeCompte.Text = Conversion.SoldeDisponibleDuCompteDeTresorerie(nomCompte).ToString("c0");
            AfficherDetteDuFournisseurSelectionne();
        }

        private void CbxNomFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetteDuFournisseurSelectionne();          
        }

        private void BtnEnregistrerDecaissement_Click(object sender, EventArgs e)
        {
            if (VerifierChampsMontantEncaisse())
            {
                ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(c => c.NomCompte == cbxCompte.Text);
                AgeEmploye em = db.AgeEmployes.FirstOrDefault(emp => emp.PrenomNom == cbxTresoriere.Text);

                if (cbxTypeFournisseur.Text == "Fournisseur de matière première")
                {
                    AgeFournisseursMatieresPremiere typeFournisseur = db.AgeFournisseursMatieresPremieres.FirstOrDefault(f => f.Nom == cbxNomFournisseur.Text);
                    var codeFourniseur = typeFournisseur.CodeFournisseurMatierePremiere;
                    EveDecaissement decaiss = new EveDecaissement
                    {
                        DateDecaissement = DateTime.Parse(dtpDateDecaissement.Text),
                        CodeFournisseurMatierePremiere = codeFourniseur,
                        CodeEmploye = em.CodeEmploye,
                        Description = "Paiement dette fournisseur matière première",
                        Montant = int.Parse(txtMontantPaye.Text),
                        CodeCompte = cpte.CodeCompte,
                    };

                    db.EveDecaissements.Add(decaiss);
                    db.SaveChanges();
                    txtMontantPaye.Clear();
                }
                else if (cbxTypeFournisseur.Text == "Fournisseur d'équipement ou entrepreneur")
                {
                    AgeAutreFournisseur typeFournisseur = db.AgeAutreFournisseurs.FirstOrDefault(f => f.NomAutreFournisseur == cbxNomFournisseur.Text);
                    var codeFourniseur = typeFournisseur.CodeAutreFournisseur;
                    EveDecaissement decaiss = new EveDecaissement
                    {
                        DateDecaissement = DateTime.Parse(dtpDateDecaissement.Text),
                        CodeAutreFournisseur = codeFourniseur,
                        CodeEmploye = em.CodeEmploye,
                        Description = "Paiement dette fournisseur équipements et infrastructures",
                        Montant = int.Parse(txtMontantPaye.Text),
                        CodeCompte = cpte.CodeCompte,
                    };

                    db.EveDecaissements.Add(decaiss);
                    db.SaveChanges();
                    txtMontantPaye.Clear();
                }
                else if (cbxTypeFournisseur.Text == "Fournisseur de services ou fournitures")
                {
                    AgeFournisseursServicesFourniture typeFournisseur = db.AgeFournisseursServicesFournitures.FirstOrDefault(f => f.NomFournisseurServiceFourniture == cbxNomFournisseur.Text);
                    var codeFourniseur = typeFournisseur.CodeFournisseurServiceFourniture;
                    EveDecaissement decaiss = new EveDecaissement
                    {
                        DateDecaissement = DateTime.Parse(dtpDateDecaissement.Text),
                        CodeFournisseurService = codeFourniseur,
                        CodeEmploye = em.CodeEmploye,
                        Description = "Paiement dette fournisseur services et fournitures",
                        Montant = int.Parse(txtMontantPaye.Text),
                        CodeCompte = cpte.CodeCompte,
                    };

                    db.EveDecaissements.Add(decaiss);
                    db.SaveChanges();
                    txtMontantPaye.Clear();
                }
                MessageBox.Show("Le paiement du fournisseur a été effectué avec succès.");
            }   
        }

        private void cbxCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nomCompte = cbxCompte.GetItemText(cbxCompte.SelectedItem);
            txtSoldeCompte.Text = Conversion.SoldeDisponibleDuCompteDeTresorerie(nomCompte).ToString("c0");
        }
    }
}

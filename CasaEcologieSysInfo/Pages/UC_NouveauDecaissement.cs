using CasaEcologieSysInfo.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        private decimal CalculerSoldeDetteFournisseurMatierePremiere(int codeFournisseur)
        {
            return (from fmp in db.AgeFournisseursMatieresPremieres
                    where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                    select new
                    {
                        NomFournisseur = fmp.Nom,
                        SoldeInitial = (decimal?)fmp.SoldeDette ?? 0m,
                        Achat = fmp.EveReceptionMatieresPremieres.Select(s => (decimal?)s.Montant).Sum() ?? 0m,
                        Paiements = fmp.EveDecaissements.Select(m => (decimal?)m.Montant).Sum() ?? 0m
                    })
                     .Sum(f => f.SoldeInitial + f.Achat - f.Paiements);
        }

        private decimal CalculerSoldeDetteFournisseurEquipementsEtInfrastructure(string nomFournisseur)
        {
            return (from af in db.AgeAutreFournisseurs
                    where af.NomAutreFournisseur == nomFournisseur
                    select new
                    {
                        Solde = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(d => d.ResEquipementsInfrastructure.Montant).Sum() ?? 0m + (decimal?)af.SoldeInitialDetteFournisseur ?? 0m
                        - (decimal?)af.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                    })
                    .Select(f => f.Solde)
                    .FirstOrDefault();
        }
 
        private decimal CalculerSoldeDetteFournisseurServicesEtFournitures(int codeFournisseur)
        {
            return (from f in db.AgeFournisseursServicesFournitures
                    where f.CodeFournisseurServiceFourniture == codeFournisseur
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
                cbxNomFournisseur.DataSource = (from fmp in db.AgeFournisseursMatieresPremieres
                                                select new
                                                {
                                                    CodeFournisseur = fmp.CodeFournisseurMatierePremiere,
                                                    NomFournisseur = fmp.Nom,
                                                    Solde = ((decimal?)fmp.SoldeDette ?? 0m)
                                                    + ((decimal?)fmp.EveReceptionMatieresPremieres.Sum(s => s.Montant) ?? 0m)
                                                    - ((decimal?)fmp.EveDecaissements.Sum(m => m.Montant) ?? 0m)
                                                })
                                                .Where(s => s.Solde > 0)
                                                .OrderByDescending(s => s.Solde)
                                                .ToList();

                cbxNomFournisseur.DisplayMember = "NomFournisseur";
                cbxNomFournisseur.ValueMember = "CodeFournisseur";               
            }
            else if (cbxTypeFournisseur.Text == "Fournisseur d'équipement ou entrepreneur")
            {
                cbxNomFournisseur.DataSource = (from af in db.AgeAutreFournisseurs
                                                select new
                                                {
                                                    NomFournisseur = af.NomAutreFournisseur,
                                                    Solde = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(d => d.ResEquipementsInfrastructure.Montant).Sum() ?? 0m + (decimal?)af.SoldeInitialDetteFournisseur ?? 0m
                                                    - (decimal?)af.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                                                })
                                                .OrderByDescending(s => s.Solde)
                                                .Where(s => s.Solde > 0)
                                                .ToList();

                cbxNomFournisseur.DisplayMember = "NomFournisseur";
                cbxNomFournisseur.ValueMember = "CodeFournisseur";
            }
            else if (cbxTypeFournisseur.Text == "Fournisseur de services ou fournitures")
            {
                cbxNomFournisseur.DataSource = (from f in db.AgeFournisseursServicesFournitures
                                                select new
                                                {
                                                    NomFournisseur = f.NomFournisseurServiceFourniture,
                                                    Solde = (decimal?)f.SoldeDette ?? 0m + (decimal?)f.EveAcquisitionServicesFournitures.Select(d => d.Montant).Sum() ?? 0m
                                                    - (decimal?)f.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m
                                                })
                                                .OrderByDescending(s => s.Solde)
                                                .Where(s => s.Solde > 0)
                                                .ToList();

                cbxNomFournisseur.DisplayMember = "NomFournisseur";
                cbxNomFournisseur.ValueMember = "CodeFournisseur";
            }            
        }

        private void AfficherDetteDuFournisseurSelectionne()
        {
            int codeFournisseur = int.Parse(cbxNomFournisseur.SelectedValue.ToString());
            txtDetteFournisseur.Text = Tresorerie.CalculerSoldeDetteParFournisseur(codeFournisseur).ToString("c0"); 
        }


        private void CbxTypeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefinirListeDesFournisseursAAfficher();
            AfficherDetteDuFournisseurSelectionne();
        }

        private void UC_NouveauDecaissement_Load(object sender, EventArgs e)
        {
            DefinirListeDesFournisseursAAfficher();
            ChargerListeEmployes();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();

            Tresorerie.AfficherSoldeTresorerie(cbxCompte, txtSoldeCompte);

            AfficherDetteDuFournisseurSelectionne();
        }

        private void CbxNomFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetteDuFournisseurSelectionne();          
        }

        private void BtnEnregistrerDecaissement_Click(object sender, EventArgs e)
        {
            if (Tresorerie.IlYaAssezDeFondsDansLeCompte(cbxCompte, txtMontantPaye))
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

        private void CbxCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tresorerie.AfficherSoldeTresorerie(cbxCompte, txtSoldeCompte);
        }

        private void DtpDateDecaissement_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }

        private void ChargerListeEmployes()
        {
            ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateDecaissement)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();
        }
    }
}

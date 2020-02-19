using CasaEcologieSysInfo.Classes;
using DGVPrinterHelper;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_DettesFournisseurs : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_DettesFournisseurs()
        {
            InitializeComponent();
        }

        private void UC_DettesFournisseurs_Load(object sender, EventArgs e)
        {
            AfficherDetailsFournisseur();
            txtTotalDettesFournisseurs.Text = Tresorerie.CalculerTotalDettesFournisseurs().ToString("c0");
        }

        private void AfficherDetailsFournisseur()
        {
            lbxListeFournisseursDettes.DisplayMember = "NomFournisseur";
            lbxListeFournisseursDettes.ValueMember = "CodeFournisseur";
            ListerFournisseurDettesFournisseurs();
        }

        private void ListerFournisseurDettesFournisseurs()
        {
            var fournisseursMP = (from fmp in db.AgeFournisseursMatieresPremieres
                                    select new
                                    {
                                        CodeFournisseur = fmp.CodeFournisseurMatierePremiere,
                                        NomFournisseur = fmp.Nom,
                                        DetteInitial = (decimal?)fmp.SoldeDette ?? 0m,
                                        MontantAchat = (decimal?)fmp.EveReceptionMatieresPremieres.Sum(s => s.Montant) ?? 0m,
                                        MontantPaye = (decimal?)fmp.EveDecaissements.Sum(m => m.Montant) ?? 0m,
                                        Solde = ((decimal?)fmp.SoldeDette ?? 0m)
                                              + ((decimal?)fmp.EveReceptionMatieresPremieres.Sum(s => s.Montant) ?? 0m)
                                              - ((decimal?)fmp.EveDecaissements.Sum(m => m.Montant) ?? 0m)
                                    }).ToList();

            var fournisseursEI = (from af in db.AgeAutreFournisseurs
                                  select new
                                  {
                                      CodeFournisseur = af.CodeAutreFournisseur,
                                      NomFournisseur = af.NomAutreFournisseur,
                                      DetteInitial = (decimal?)af.SoldeInitialDetteFournisseur ?? 0m,
                                      MontantAchat = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(d => d.ResEquipementsInfrastructure.Montant).Sum() ?? 0m,
                                      MontantPaye = (decimal?)af.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m,
                                      Solde = ((decimal?)af.SoldeInitialDetteFournisseur ?? 0m)
                                            + ((decimal?)af.EveReceptionEquipementsInfrastructures.Select(d => d.ResEquipementsInfrastructure.Montant).Sum() ?? 0m)
                                            - ((decimal?)af.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m)
                                  }).ToList();

            var fournisseurFS = (from f in db.AgeFournisseursServicesFournitures
                                 select new
                                 {
                                     CodeFournisseur = f.CodeFournisseurServiceFourniture,
                                     NomFournisseur = f.NomFournisseurServiceFourniture,
                                     DetteInitial = (decimal?)f.SoldeDette ?? 0m,
                                     MontantAchat = (decimal?)f.EveAcquisitionServicesFournitures.Select(d => d.Montant).Sum() ?? 0m,
                                     MontantPaye = (decimal?)f.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m,
                                     Solde = ((decimal?)f.SoldeDette ?? 0m)
                                           + ((decimal?)f.EveAcquisitionServicesFournitures.Select(d => d.Montant).Sum() ?? 0m)
                                           - ((decimal?)f.EveDecaissements.Select(d => d.Montant).Sum() ?? 0m)
                                 }).ToList();

            var listFournisseurs = fournisseursMP
                                    .Concat(fournisseursEI)
                                    .Concat(fournisseurFS)
                                    .Where(f => f.Solde > 0)
                                    .OrderByDescending(s => s.Solde)
                                    .ToList();

            lbxListeFournisseursDettes.DataSource = listFournisseurs;
            lbxListeFournisseursDettes.DisplayMember = "NomFournisseur";
            lbxListeFournisseursDettes.ValueMember = "CodeFournisseur";

            //string codeText = lbxListeFournisseursDettes.SelectedValue.ToString();
            //int codeFournisseur = int.Parse(codeText);
            //(codeFournisseur);
            //lbxListeFournisseursDettes.Sorted = true;
        }

        private void MontrerDetailsDettesFournisseurs(int codeFournisseur)
        {
            var achatMatierePrem = (from fmp in db.AgeFournisseursMatieresPremieres
                                    from rmp in db.EveReceptionMatieresPremieres
                                    where rmp.CodeFournisseurMatierePremiere == fmp.CodeFournisseurMatierePremiere
                                    where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                                    select new
                                    {
                                        Date = rmp.DateReception,
                                        Description = "Achat de " + rmp.ResStockMatieresPremiere.NomMatiere,
                                        MontantAchat = (decimal?)rmp.Montant ?? 0m,
                                        MontantPaye = 0m,
                                        Solde = 0m
                                    }
                                 );

            var achatEquipementInfr = (from af in db.AgeAutreFournisseurs
                                       where af.CodeAutreFournisseur == codeFournisseur
                                       select new
                                       {
                                           Date = af.EveReceptionEquipementsInfrastructures.Select(d => d.ResEquipementsInfrastructure.DateAcquisition).FirstOrDefault(),
                                           Description = "Achat de " + af.EveReceptionEquipementsInfrastructures.Select(recep => recep.ResEquipementsInfrastructure.Nom).FirstOrDefault(),
                                           MontantAchat = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(s => s.ResEquipementsInfrastructure.Montant).FirstOrDefault() ?? 0m,
                                           MontantPaye = 0m,
                                           Solde = 0m
                                       }
                                 );

            var achatServFournitures = (from fs in db.AgeFournisseursServicesFournitures
                                        where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                        select new
                                        {
                                            Date = fs.EveAcquisitionServicesFournitures.Select(d => d.Date).FirstOrDefault(),
                                            Description = fs.EveAcquisitionServicesFournitures.Select(eve => eve.ResServicesFourniture.NomServiceFourniture).FirstOrDefault(),
                                            MontantAchat = (decimal?)fs.EveAcquisitionServicesFournitures.Select(s => s.Montant).FirstOrDefault() ?? 0m,
                                            MontantPaye = 0m,
                                            Solde = 0m
                                        }
                                 );

            var decaissementMP = (from fmp in db.AgeFournisseursMatieresPremieres
                                  from d in db.EveDecaissements
                                  where d.CodeFournisseurMatierePremiere == fmp.CodeFournisseurMatierePremiere
                                  where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                                  select new
                                  {
                                      Date = d.DateDecaissement,
                                      d.Description,
                                      MontantAchat = 0m,
                                      MontantPaye = (decimal?)d.Montant ?? 0m,
                                      Solde = 0m
                                  }
                                 );

            var decaisementEquip = (from af in db.AgeAutreFournisseurs
                                where af.CodeAutreFournisseur == codeFournisseur
                                select new
                                {
                                    Date = af.EveDecaissements.Select(d => d.DateDecaissement).FirstOrDefault(),
                                    Description = af.EveDecaissements.Select(decaiss => decaiss.Description).FirstOrDefault(),
                                    MontantAchat = 0m,
                                    MontantPaye = (decimal?)af.EveDecaissements.Select(m => m.Montant).FirstOrDefault() ?? 0m,
                                    Solde = 0m
                                }
                                 );

            var decaissementServFourn = (from fs in db.AgeFournisseursServicesFournitures
                                        where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                        select new
                                        {
                                            Date = fs.EveDecaissements.Select(d => d.DateDecaissement).FirstOrDefault(),
                                            Description = fs.EveDecaissements.Select(decaiss => decaiss.Description).FirstOrDefault(),
                                            MontantAchat = 0m,
                                            MontantPaye = (decimal?)fs.EveDecaissements.Select(m => m.Montant).FirstOrDefault() ?? 0m,
                                            Solde = 0m
                                        }
                                 );
            var totalOperations = achatMatierePrem.Concat(achatEquipementInfr)
               .Concat(achatServFournitures)
               .Concat(decaissementMP)
               .Concat(decaisementEquip)
               .Concat(decaissementServFourn)
               .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(totalOperations);
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);
            dr["MontantAchat"] = 0;
            dr["MontantPaye"] = 0;
            dr["Solde"] = 0;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MontantAchat"].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns["MontantPaye"].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns["Solde"].DefaultCellStyle.Format = "n0";
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var detteFournisseurInitialMP = (from fmp in db.AgeFournisseursMatieresPremieres
                                             where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                                             select (decimal?)fmp.SoldeDette).Sum() ?? 0m;
                     
            var detteFournisseurInitialAF = (from af in db.AgeAutreFournisseurs
                                             where af.CodeAutreFournisseur == codeFournisseur
                                             select (decimal?)af.SoldeInitialDetteFournisseur).Sum() ?? 0m;

            var detteFournisseurInitialFS = (from fs in db.AgeFournisseursServicesFournitures
                                             where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                             select (decimal?)fs.SoldeDette).Sum() ?? 0m;

            var soldeInitial = detteFournisseurInitialMP + detteFournisseurInitialAF + detteFournisseurInitialFS;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i > 0)
                {
                    dataGridView1.Rows[i].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[4].Value)
                    + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Value = soldeInitial + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
            }
        }

        private void LbxListeFournisseursDettes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxListeFournisseursDettes.Items.Count > 0)
            {
                AfficherDetailsFournisseur();
            }
            else
            {
                MessageBox.Show("Le GIE n'a pas de dettes fournisseurs en ce moment.");
            }
            
        }

        private void BtnImprimerTableau_Click(object sender, EventArgs e)
        {          
            Impression.ImprimerTableauTransactions(lbxListeFournisseursDettes, dataGridView1);
        }
    }
}

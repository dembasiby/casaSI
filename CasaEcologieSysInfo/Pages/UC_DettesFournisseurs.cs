using CasaEcologieSysInfo.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
            rbtFMatieresPremieres.Checked = true;
            ListerFournisseurAvecDettesFournisseurs();
            txtTotalDettesFournisseurs.Text = Tresorerie.CalculerTotalDettesFournisseurs().ToString("c0");
        }

        private void RbtFMatieresPremieres_CheckedChanged(object sender, EventArgs e)
        {
            ClearTable();
            ListerFournisseurAvecDettesFournisseurs();
        }

        private void RbtFEquipementsInfra_CheckedChanged(object sender, EventArgs e)
        {
            ClearTable();
            ListerFournisseurAvecDettesFournisseurs();
        }

        private void RbtAutresFournisseurs_CheckedChanged(object sender, EventArgs e)
        {
            ClearTable();
            ListerFournisseurAvecDettesFournisseurs();
        }

        private int ExtraireCodeFournisseur()
        {
            string fournisseur = lbxListeFournisseursDettes.GetItemText(lbxListeFournisseursDettes.SelectedItem);
            int codeFournisseur;

            if (rbtFMatieresPremieres.Checked)
            {
                codeFournisseur = db.AgeFournisseursMatieresPremieres
                                  .Where(f => f.Nom == fournisseur)
                                  .Select(f => f.CodeFournisseurMatierePremiere)
                                  .FirstOrDefault();

            }
            else if (rbtFEquipementsInfra.Checked)
            {
                codeFournisseur = db.AgeAutreFournisseurs
                                .Where(f => f.NomAutreFournisseur == fournisseur)
                                .Select(f => f.CodeAutreFournisseur)
                                .FirstOrDefault();
            }
            else
            {
                codeFournisseur = db.AgeFournisseursServicesFournitures
                                .Where(f => f.NomFournisseurServiceFourniture == fournisseur)
                                .Select(f => f.CodeFournisseurServiceFourniture)
                                .FirstOrDefault();
            }

            return codeFournisseur;
        }

        private void LbxListeFournisseursDettes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxListeFournisseursDettes.Items.Count > 0)
            {
                MontrerDetailsDettesFournisseur(ExtraireCodeFournisseur());
            }
            else
            {
                MessageBox.Show($"Le GIE n'a pas de dettes fournisseurs en ce moment pour cette catégorie.");
            }
        }

        private void BtnImprimerTableau_Click(object sender, EventArgs e)
        {
            Impression.ImprimerTableauTransactions(lbxListeFournisseursDettes, dataGridView1);
        }


         /************************************************************
         *                         HELPERS
         ************************************************************/
        private List<AgeFournisseursMatieresPremiere> ListeFournisseurMatieresPremieres ()
        {
            var listeFournisseurs = db.AgeFournisseursMatieresPremieres.ToList();
            return listeFournisseurs
                .Where(f => Tresorerie.CalculerTotalDettesFournisseurMatierePremiere(f.CodeFournisseurMatierePremiere) > 0)
                .ToList();
        }

        private List<AgeAutreFournisseur> ListeFournisseursEquipementsInfrastructures()
        {
            var listeFournisseurs = db.AgeAutreFournisseurs.ToList();
            return listeFournisseurs
                .Where(f => Tresorerie.CalculerTotalDettesFournisseurMatierePremiere(f.CodeAutreFournisseur) > 0)
                .ToList();
        }

        private List<AgeFournisseursServicesFourniture> ListeFournisseursServicesFournitures()
        {
            var listeFournisseurs = db.AgeFournisseursServicesFournitures.ToList();
            return listeFournisseurs
                .Where(f => Tresorerie.CalculerTotalDettesFournisseurMatierePremiere(f.CodeFournisseurServiceFourniture) > 0)
                .ToList();
        }

        private void ListerFournisseurAvecDettesFournisseurs()
        {
            if (rbtFMatieresPremieres.Checked)
            {
                lbxListeFournisseursDettes.DataSource = ListeFournisseurMatieresPremieres();
                lbxListeFournisseursDettes.DisplayMember = "Nom";
                lbxListeFournisseursDettes.ValueMember = "CodeFournisseurMatierePremiere";
            }
            else if (rbtFEquipementsInfra.Checked)
            {
                lbxListeFournisseursDettes.DataSource = ListeFournisseursEquipementsInfrastructures();
                lbxListeFournisseursDettes.DisplayMember = "NomAutreFournisseur";
                lbxListeFournisseursDettes.ValueMember = "CodeAutreFournisseur";
            }
            else if (rbtAutresFournisseurs.Checked)
            {
                lbxListeFournisseursDettes.DataSource = ListeFournisseursServicesFournitures();
                lbxListeFournisseursDettes.DisplayMember = "NomFournisseurServiceFourniture";
                lbxListeFournisseursDettes.ValueMember = "CodeFournisseurServiceFourniture";
            }        
        }

        private void MontrerDetailsDettesFournisseur(int codeFournisseur)
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
                                    });

            var achatEquipementInfr = (from af in db.AgeAutreFournisseurs
                                       where af.CodeAutreFournisseur == codeFournisseur
                                       select new
                                       {
                                           Date = af.EveReceptionEquipementsInfrastructures.Select(d => d.ResEquipementsInfrastructure.DateAcquisition).FirstOrDefault(),
                                           Description = "Achat de " + af.EveReceptionEquipementsInfrastructures.Select(recep => recep.ResEquipementsInfrastructure.Nom).FirstOrDefault(),
                                           MontantAchat = (decimal?)af.EveReceptionEquipementsInfrastructures.Select(s => s.ResEquipementsInfrastructure.Montant).FirstOrDefault() ?? 0m,
                                           MontantPaye = 0m,
                                           Solde = 0m
                                       });

            var achatServFournitures = (from fs in db.AgeFournisseursServicesFournitures
                                        where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                        select new
                                        {
                                            Date = fs.EveAcquisitionServicesFournitures.Select(d => d.Date).FirstOrDefault(),
                                            Description = fs.EveAcquisitionServicesFournitures.Select(eve => eve.ResServicesFourniture.NomServiceFourniture).FirstOrDefault(),
                                            MontantAchat = (decimal?)fs.EveAcquisitionServicesFournitures.Select(s => s.Montant).FirstOrDefault() ?? 0m,
                                            MontantPaye = 0m,
                                            Solde = 0m
                                        });

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
                                  });

            var decaisementEquip = (from af in db.AgeAutreFournisseurs
                                where af.CodeAutreFournisseur == codeFournisseur
                                select new
                                {
                                    Date = af.EveDecaissements.Select(d => d.DateDecaissement).FirstOrDefault(),
                                    Description = af.EveDecaissements.Select(decaiss => decaiss.Description).FirstOrDefault(),
                                    MontantAchat = 0m,
                                    MontantPaye = (decimal?)af.EveDecaissements.Select(m => m.Montant).FirstOrDefault() ?? 0m,
                                    Solde = 0m
                                });

            var decaissementServFourn = (from fs in db.AgeFournisseursServicesFournitures
                                        where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                        select new
                                        {
                                            Date = fs.EveDecaissements.Select(d => d.DateDecaissement).FirstOrDefault(),
                                            Description = fs.EveDecaissements.Select(decaiss => decaiss.Description).FirstOrDefault(),
                                            MontantAchat = 0m,
                                            MontantPaye = (decimal?)fs.EveDecaissements.Select(m => m.Montant).FirstOrDefault() ?? 0m,
                                            Solde = 0m
                                        });
            var operationsAchatMP = achatMatierePrem.Concat(decaissementMP).OrderBy(op => op.Date).ToList();
            var operationsAchatEquip = achatEquipementInfr.Concat(decaisementEquip).OrderBy(op => op.Date).ToList();
            var operationsAchatFournServ = achatServFournitures.Concat(decaissementServFourn).OrderBy(op => op.Date).ToList();

            DataTable dt;
            var soldeInitial = 0m;
         
            if (rbtFMatieresPremieres.Checked)
            {
                dt = Conversion.ConvertirEnTableDeDonnees(operationsAchatMP);
                soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                where fmp.CodeFournisseurMatierePremiere == codeFournisseur
                                select (decimal?)fmp.SoldeDette).Sum() ?? 0m;
            }
            else if (rbtFEquipementsInfra.Checked)
            {
                dt = Conversion.ConvertirEnTableDeDonnees(operationsAchatEquip);
                soldeInitial = (from af in db.AgeAutreFournisseurs
                                where af.CodeAutreFournisseur == codeFournisseur
                                select (decimal?)af.SoldeInitialDetteFournisseur).Sum() ?? 0m;
            }
            else 
            {
                dt = Conversion.ConvertirEnTableDeDonnees(operationsAchatFournServ);
                soldeInitial = (from fs in db.AgeFournisseursServicesFournitures
                                where fs.CodeFournisseurServiceFourniture == codeFournisseur
                                select (decimal?)fs.SoldeDette).Sum() ?? 0m;
            }

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

        private void ClearTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
    }
}

﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_JournalTresorerie : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_JournalTresorerie()
        {
            InitializeComponent();
        }

        private void UC_JournalTresorerie_Load(object sender, EventArgs e)
        {

            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string nomCompte = listBox1.GetItemText(listBox1.SelectedItem);

            AfficherJournalCorrespondant(nomCompte);
        }

        private void AfficherJournalCorrespondant(string nomCompte)
        {
            
            var query1 = (from c in db.EveEncaissements
                          from env in db.EveEncaissementsVentes
                          where c.CodeEncaissement == env.CodeEncaissement
                          where c.ResComptesTresorerie.NomCompte == nomCompte

                          select new
                          {
                              Date = env.DateEncaissement,
                              Description = "Encaissement vente",//vpf.ResStockProduitsFini.NomProduit,
                              Entree = env.MontantEncaisse,
                              Sortie = 0m,
                              Solde = 0m
                          });
            var query3 = (from c in db.EveEncaissements
                          from aut in db.EveEncaissementsAutres
                          where c.CodeEncaissement == aut.CodeEncaissement
                          where c.ResComptesTresorerie.NomCompte == nomCompte

                          select new
                          {
                              Date = aut.DateEncaissement,
                              aut.Description,
                              Entree = aut.MontantEncaisse,
                              Sortie = 0m,
                              Solde = 0m
                          });

            var query4 = (from c in db.EveEncaissements
                          from aut in db.EveEncaissementsCreances
                          where c.CodeEncaissement == aut.CodeEncaissement
                          where c.ResComptesTresorerie.NomCompte == nomCompte

                          select new
                          {
                              Date = aut.DateEncaissement,
                              Description = "Encaissement créance",
                              Entree = aut.MontantEncaisse,
                              Sortie = 0m,
                              Solde = 0m
                          });

            var query2 = (from d in db.EveDecaissements
                          where d.ResComptesTresorerie.NomCompte == nomCompte
                          select new
                          {
                              Date = d.DateDecaissement,
                              d.Description,
                              Entree = 0m,
                              Sortie = d.Montant,
                              Solde = 0m
                          });
            var combinedQuery = query1
                .Concat(query4)
                .Concat(query3)
                .Concat(query2)
                .OrderByDescending(o => o.Date)
                .ToList();


            var soldeInitial = (from c in db.ResComptesTresoreries
                                             where c.NomCompte == nomCompte
                                             select c.SoldeCompte).FirstOrDefault();


            DataTable dt = Conversion.ConvertirEnTableDeDonnees(combinedQuery);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, dt.Rows.Count);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Solde initial";

            dgvJournalTresorerieDetails.DataSource = dt;

            for (int i = dgvJournalTresorerieDetails.Rows.Count -1; i >= 0 ; i--)
            {

                if (i < dgvJournalTresorerieDetails.Rows.Count - 1)
                {
                    dgvJournalTresorerieDetails.Rows[i].Cells[4].Value = Convert.ToInt32(dgvJournalTresorerieDetails.Rows[i + 1].Cells[4].Value)
                    + Convert.ToInt32(dgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
                }
                else
                {
                    dgvJournalTresorerieDetails.Rows[i].Cells[4].Value = soldeInitial + Convert.ToInt32(dgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
                }

            }

            dgvJournalTresorerieDetails.Columns["Entree"].DefaultCellStyle.Format = "n0";
            dgvJournalTresorerieDetails.Columns["Sortie"].DefaultCellStyle.Format = "n0";
            dgvJournalTresorerieDetails.Columns["Solde"].DefaultCellStyle.Format = "n0";
            dgvJournalTresorerieDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvJournalTresorerieDetails.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Calcul des soldes

            var soldeInitiaux = (from c in db.ResComptesTresoreries
                                 select (decimal?)c.SoldeCompte).Sum() ?? 0m;

            var totalEncaissementsVentes = (from c in db.EveEncaissements
                                           from env in db.EveEncaissementsVentes
                                           where c.CodeEncaissement == env.CodeEncaissement
                                           select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

            var encaissementCreance = (from c in db.EveEncaissements
                                      from env in db.EveEncaissementsCreances
                                      where c.CodeEncaissement == env.CodeEncaissement
                                      select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

            var totalAutresEn = (from enc in db.EveEncaissements
                                 from aut in db.EveEncaissementsAutres
                                 where aut.FondsExternes == true
                                 where enc.CodeEncaissement == aut.CodeEncaissement
                                 select (decimal?)aut.MontantEncaisse).Sum() ?? 0m;

            var totalDecaissements = (from d in db.EveDecaissements
                                      where d.DecaissementInterne == false
                                      select (decimal?)d.Montant).Sum() ?? 0m;

            var fondsDisponibleEnCaissesEtEnBanques = soldeInitiaux
                + totalEncaissementsVentes + totalAutresEn + encaissementCreance
                - totalDecaissements;

            txtSoldesInitiaux.Text = soldeInitiaux.ToString("c0");
            txtTotalEncaissements.Text = (totalEncaissementsVentes + encaissementCreance + totalAutresEn).ToString("c0");
            txtTotalDecaissements.Text = totalDecaissements.ToString("c0");

            txtSolde.Text = Tresorerie.CalculerSoldeTresorerie(DateTime.Today);
        }

        private void BtnImprimerJournal_Click(object sender, EventArgs e)
        {
            Impression.ImprimerJournalTresorerie(listBox1, dgvJournalTresorerieDetails);
        }
    }
}


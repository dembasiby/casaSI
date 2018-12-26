﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CasaEcologieSysInfo.Pages
{
    public partial class txtEquipmentsInfr : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public txtEquipmentsInfr()
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
            
            var query1 = (from ev in db.EveEncaissementsVentes
                          from vpf in db.EveVenteStockProduitsFinis
                          where vpf.CodeVente== ev.CodeVente
                          from pf in db.ResStockProduitsFinis
                          where pf.CodeProduit == vpf.CodeProduitFini
                          where ev.EveEncaissement.ResComptesTresorerie.NomCompte == nomCompte

                          select new
                          {
                              Date = ev.DateEncaissement,
                              Description = "",//vpf.ResStockProduitsFini.NomProduit,
                              Entree = ev.MontantEncaisse,
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
            var combinedQuery = query1.Union(query2).ToList();


            var soldeInitial = (from c in db.ResComptesTresoreries
                                             where c.NomCompte == nomCompte
                                             select c.SoldeCompte).FirstOrDefault();


            DataTable dt = Conversion.ConvertirEnTableDeDonnees(combinedQuery);

            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Report";

            adgvJournalTresorerieDetails.DataSource = dt;


            for (int i = 0; i < adgvJournalTresorerieDetails.Rows.Count; i++)
            {

                if (i > 0)
                {
                    adgvJournalTresorerieDetails.Rows[i].Cells[4].Value = Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i - 1].Cells[4].Value)
                    + Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
                }
                else
                {
                    adgvJournalTresorerieDetails.Rows[i].Cells[4].Value = soldeInitial + Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(adgvJournalTresorerieDetails.Rows[i].Cells[3].Value);
                }

            }

            adgvJournalTresorerieDetails.Columns["Entree"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Sortie"].DefaultCellStyle.Format = "c0";
            adgvJournalTresorerieDetails.Columns["Solde"].DefaultCellStyle.Format = "c0";

            // Calcul des soldes

            var soldeInitiaux = (from c in db.ResComptesTresoreries
                                 select c.SoldeCompte).Sum();

            var totalEncaissements = (from c in db.EveEncaissements
                                      from env in db.EveEncaissementsVentes
                                      where c.CodeEncaissement == env.CodeEncaissement
                                      select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

            var totalAchatMatierePrem = (from d in db.EveDecaissements
                                         from m in db.EveReceptionMatieresPremieres
                                         where d.CodeReceptionMatierePremiere == m.CodeReceptionMatierePremiere
                                         select (decimal?)d.Montant).Sum() ?? 0m;

            var totalEquipmentsInfrastructures = (from d in db.EveDecaissements
                                                  from re in db.EveReceptionEquipementsInfrastructures
                                                  where d.CodeReceptionEquipementInfrastructure == re.CodeReceptionEquipementInfrastructure
                                                  select (decimal?)d.Montant).Sum() ?? 0m;

            var totalFournituresServices = (from d in db.EveDecaissements
                                            from fs in db.EveAcquisitionServicesFournitures
                                            where d.CodeAcquisitionServiceFourniture == fs.CodeAcquisitionServiceFourniture
                                            select (decimal?)d.Montant).Sum() ?? 0m;

            var fondsDisponibleEnCaissesEtEnBanques = soldeInitiaux
                + totalEncaissements
                - totalAchatMatierePrem
                - totalEquipmentsInfrastructures
                - totalFournituresServices;

            txtSoldesInitiaux.Text = soldeInitiaux.ToString("c0");
            txtTotalEncaissements.Text = totalEncaissements.ToString("c0");
            txtTotalMatPrem.Text = totalAchatMatierePrem.ToString("c0");
            txtTotalEquipementsInfr.Text = totalEquipmentsInfrastructures.ToString("c0");
            txtFournServ.Text = totalFournituresServices.ToString("c0");

            txtSolde.Text = fondsDisponibleEnCaissesEtEnBanques.ToString("c0");

            
        }
    }
}


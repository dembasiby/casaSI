using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Client
    {
        public static void MontrerDetailsCreances(int codeClient, DataGridView dgvDetailsClient)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventesClients = (from c in db.AgeClients
                                     join v in db.EveVentes on c.CodeClient equals v.CodeClient
                                     join vpf in db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                                     where c.CodeClient == codeClient
                                     select new
                                     {
                                         Date = v.DateVente,
                                         Description = vpf.ResStockProduitsFini.NomProduit,
                                         vpf.Montant,
                                         Encaissement = 0m,
                                         Solde = 0m
                                     });

                var totalPaiementClient = (from c in db.AgeClients
                                           join ev in db.EveEncaissementsVentes on c.CodeClient equals ev.CodeClient
                                           where c.CodeClient == codeClient
                                           select new
                                           {
                                               Date = ev.DateEncaissement,
                                               Description = "Encaissement vente",
                                               Montant = 0m,
                                               Encaissement = ev.MontantEncaisse,
                                               Solde = 0m
                                           });

                var encaissementCreances = (from c in db.AgeClients
                                            join ecc in db.EveEncaissementsCreances on c.CodeClient equals ecc.CodeClient
                                            where c.CodeClient == codeClient
                                            select new
                                            {
                                                Date = ecc.DateEncaissement,
                                                Description = "Encaissement créance",
                                                Montant = 0m,
                                                Encaissement = ecc.MontantEncaisse,
                                                Solde = 0m
                                            });

                var combinedQuery = ventesClients
                                    .Concat(totalPaiementClient)
                                    .Concat(encaissementCreances)
                                    .OrderByDescending(c => c.Date)
                                    .ToList();
                DataTable dt = Conversion.ConvertirEnTableDeDonnees(combinedQuery);

                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);
                dr["Montant"] = 0;
                dr["Encaissement"] = 0;
                dr["Description"] = "Montant créance initiale";
                dgvDetailsClient.DataSource = dt;

                dgvDetailsClient.Columns["Montant"].DefaultCellStyle.Format = "n0";
                dgvDetailsClient.Columns["Encaissement"].DefaultCellStyle.Format = "n0";
                dgvDetailsClient.Columns["Solde"].DefaultCellStyle.Format = "n0";
                dgvDetailsClient.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetailsClient.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvDetailsClient.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvDetailsClient.Columns["Description"].FillWeight = 250;


                var creanceInitialClient = (from c in db.AgeClients
                                            where c.CodeClient == codeClient
                                            select c.SoldeInitialeCreance).FirstOrDefault();

                for (int i = 0; i < dgvDetailsClient.Rows.Count; i++)
                {

                    if (i > 0)
                    {
                        dgvDetailsClient.Rows[i].Cells[4].Value = Convert.ToInt32(dgvDetailsClient.Rows[i - 1].Cells[4].Value)
                        + Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[2].Value)
                        - Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        dgvDetailsClient.Rows[i].Cells[4].Value = creanceInitialClient + Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[2].Value)
                        - Convert.ToInt32(dgvDetailsClient.Rows[i].Cells[3].Value);
                    }

                } 
            }
        }

        public static decimal MettreCreanceAJour(ComboBox cbxNomClient)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var codeClient = Convert.ToInt32(cbxNomClient.SelectedValue);

                var ventesClients = (from c in db.AgeClients
                                     from vf in db.EveVenteStockProduitsFinis
                                     from v in db.EveVentes
                                     where v.CodeClient == c.CodeClient
                                     where vf.CodeVente == v.CodeVente
                                     where c.CodeClient == codeClient
                                     select (decimal?)vf.Montant).Sum() ?? 0m;

                var totalPaiementClient = (from c in db.AgeClients
                                           from ev in db.EveEncaissementsVentes
                                           where c.CodeClient == codeClient
                                           where c.CodeClient == ev.CodeClient
                                           select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;

                var totalPaiementCreances = (from c in db.AgeClients
                                             from pc in db.EveEncaissementsCreances
                                             where c.CodeClient == codeClient
                                             where pc.CodeClient == c.CodeClient
                                             select (decimal?)pc.MontantEncaisse).Sum() ?? 0m;

                var creanceInitialClient = (from c in db.AgeClients where c.CodeClient == codeClient select c.SoldeInitialeCreance).FirstOrDefault();

                var creancesClients = ventesClients + creanceInitialClient - totalPaiementClient - totalPaiementCreances;

                return creancesClients;
            }
        }
    }
}

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_NouvelEncaissement : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_NouvelEncaissement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            ageClientBindingSource.DataSource = Conversion.ListeClientsAvecCreances().OrderBy(c => c.NomClient).ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
        }

        private void MettreCreanceAJour()
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

            txtCreancesClient.Text = creancesClients.ToString("c0");
        }

        private void BtnEnregistrerEncaissement_Click(object sender, EventArgs e)
        {
            AgeClient client = db.AgeClients.FirstOrDefault(c => c.NomClient == cbxNomClient.Text);
            AgeEmploye tres = db.AgeEmployes.FirstOrDefault(rv => rv.PrenomNom == cbxTres.Text);
            ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(cte => cte.NomCompte == cbxCompte.Text);

            if (Validation.VerifierChampsMontant(txtMontantEncaisse.Text))
            {
                if (int.Parse(txtMontantEncaisse.Text) > 0)
                {
                    EveEncaissement enc = new EveEncaissement
                    {
                        CodeEmploye = tres.CodeEmploye,
                        CodeCompte = cpte.CodeCompte,
                    };

                    db.EveEncaissements.Add(enc);
                    db.SaveChanges();

                    EveEncaissementsCreance encC = new EveEncaissementsCreance
                    {
                        CodeEncaissement = enc.CodeEncaissement,
                        CodeClient = client.CodeClient,
                        MontantEncaisse = int.Parse(txtMontantEncaisse.Text),
                        DateEncaissement = DateTime.Parse(dtpDateEncaissement.Text)
                    };

                    db.EveEncaissementsCreances.Add(encC);
                    db.SaveChanges();
                    txtMontantEncaisse.Clear();
                    LoadData();
                    MettreCreanceAJour();
                }
            }           
        }

        private void UC_NouvelEncaissement_Load(object sender, EventArgs e)
        {
            LoadData();
            MettreCreanceAJour();
        }

        private void CbxNomClient_SelectedValueChanged(object sender, EventArgs e)
        {
            MettreCreanceAJour();
        }

        private void DtpDateEncaissement_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }

        private void ChargerListeEmployes()
        {
            ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateEncaissement)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();
        }
    }
}

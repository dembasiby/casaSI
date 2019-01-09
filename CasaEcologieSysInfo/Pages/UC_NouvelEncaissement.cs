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
    public partial class UC_NouvelEncaissement : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_NouvelEncaissement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            ageEmployeBindingSource.DataSource = db.AgeEmployes.ToList();
            ageClientBindingSource.DataSource = db.AgeClients.ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
        }

        private void MettreCreanceAJour()
        {
            var ventesClients = (from c in db.AgeClients
                                 from vf in db.EveVenteStockProduitsFinis
                                 from v in db.EveVentes
                                 where v.CodeClient == c.CodeClient
                                 where vf.CodeVente == v.CodeVente
                                 where c.NomClient == cbxNomClient.Text
                                 select (decimal?)vf.Montant).Sum() ?? 0m;

            var totalPaiementClient = (from c in db.AgeClients
                                       where c.NomClient == cbxNomClient.Text
                                       select (decimal?)c.EveEncaissements.Sum(s => s.EveEncaissementsVentes.Sum(t => t.MontantEncaisse))).Sum() ?? 0m;

            var creanceInitialClient = (from c in db.AgeClients where c.NomClient == cbxNomClient.Text select c.SoldeInitialeCreance).FirstOrDefault();

            var creancesClients = ventesClients + creanceInitialClient - totalPaiementClient;

            txtCreancesClient.Text = creancesClients.ToString("c0");
        }

        private bool VerifierChampsMontantEncaisse()
        {
            if (string.IsNullOrEmpty(txtMontantEncaisse.Text))
            {
                MessageBox.Show("Ce champs doit être renseigné.");
                return false;
            }

            try
            {
                int temp = Convert.ToInt32(txtMontantEncaisse.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce champs doit contenir uniquement des nombres.");
                return false;
            }

            return true;
        }

        private void BtnEnregistrerEncaissement_Click(object sender, EventArgs e)
        {
            AgeClient client = db.AgeClients.FirstOrDefault(c => c.NomClient == cbxNomClient.Text);
            AgeEmploye tres = db.AgeEmployes.FirstOrDefault(rv => rv.PrenomNom == cbxTres.Text);
            ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(cte => cte.NomCompte == cbxCompte.Text);

            if (VerifierChampsMontantEncaisse())
            {
                if (int.Parse(txtMontantEncaisse.Text) > 0)
                {
                    EveEncaissement enc = new EveEncaissement
                    {
                        CodeClient = client.CodeClient,
                        CodeEmploye = tres.CodeEmploye,
                        CodeCompte = cpte.CodeCompte,
                    };

                    db.EveEncaissements.Add(enc);
                    db.SaveChanges();

                    EveVente vente = db.EveVentes.FirstOrDefault(nc => nc.CodeClient == client.CodeClient);
                    EveEncaissementsVente encV = new EveEncaissementsVente
                    {
                        CodeEncaissement = enc.CodeEncaissement,
                        CodeVente = vente.CodeVente,
                        MontantEncaisse = int.Parse(txtMontantEncaisse.Text),
                        DateEncaissement = DateTime.Parse(dtpDateEncaissement.Text)
                    };

                    db.EveEncaissementsVentes.Add(encV);
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

        private void cbxNomClient_SelectedValueChanged(object sender, EventArgs e)
        {
            MettreCreanceAJour();
        }
    }


}

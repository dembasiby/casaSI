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

        private void VerifierChampsMontantEncaisse()
        {
            if (string.IsNullOrEmpty(txtMontantEncaisse.Text))
            {
                MessageBox.Show("Ce champs doit être renseigné.");
                return;
            }

            try
            {
                int temp = Convert.ToInt32(txtMontantEncaisse.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce champs doit contenir uniquement des nombres.");
                return;
            }
        }

        private void BtnEnregistrerEncaissement_Click(object sender, EventArgs e)
        {
            AgeClient client = db.AgeClients.FirstOrDefault(c => c.NomClient == cbxNomClient.Text);
            AgeEmploye tres = db.AgeEmployes.FirstOrDefault(rv => rv.PrenomNom == cbxTres.Text);
            ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(cte => cte.NomCompte == cbxCompte.Text);

            VerifierChampsMontantEncaisse();
            
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
                cpte.SoldeCompte += int.Parse(txtMontantEncaisse.Text);
                client.SoldeInitialeCreance -= int.Parse(txtMontantEncaisse.Text);
                db.SaveChanges();
                LoadData();

            }

        }

        private void UC_NouvelEncaissement_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_ReceptionDonMatierePremiere : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_ReceptionDonMatierePremiere()
        {
            InitializeComponent();
        }

        private void UC_ReceptionDonMatierePremiere_Load(object sender, EventArgs e)
        {
            ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateReception).OrderBy(em => em.PrenomNom).ToList();
            ageFournisseursMatieresPremiereBindingSource.DataSource = db.AgeFournisseursMatieresPremieres.OrderBy(f => f.Nom).ToList();
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.OrderBy(m => m.NomMatiere).ToList();
        }

        private EveReceptionDonsMatieresPremiere ReceptionDonMatierePremiere()
        {
            var codeEmploye = int.Parse(cbxEmploye.SelectedValue.ToString());
            var codeFournisseur = int.Parse(cbxFournisseur.SelectedValue.ToString());
            var codeMatierePremiere = int.Parse(cbxMatierePremiere.SelectedValue.ToString());

            EveReceptionDonsMatieresPremiere don = new EveReceptionDonsMatieresPremiere
            {
                DateReception = dtpDateReception.Value.Date,
                CodeMatierePremiere = codeMatierePremiere,
                CodeEmploye = codeEmploye,
                CodeFournisseur = codeFournisseur,
                Quantite = int.Parse(txtQuantite.Text),
            };

            db.EveReceptionDonsMatieresPremieres.Add(don);
            db.SaveChanges();
            MessageBox.Show("Le nouveau don de matière première a été enregistré avec succès.");
            txtQuantite.Text = "0";
            txtTransport.Text = "0";

            return don;
        }

        private void PayerTransportMatierePremiere(EveReceptionDonsMatieresPremiere don)
        {
            if (int.Parse(txtTransport.Text) > 0)
            {
                EveDecaissement decaiss = new EveDecaissement
                {
                    DateDecaissement = don.DateReception,
                    Montant = int.Parse(txtTransport.Text),
                    Description = "Transport don matière premiere",
                    CodeCompte = int.Parse(cbxCompte.GetItemText(cbxCompte.SelectedValue)),
                    //CodeReceptionMatierePremiere = don.CodeReceptionDonMatierePremiere
                };

                db.EveDecaissements.Add(decaiss);
                db.SaveChanges();
            }        
        }

        private void BtnFiltrer_Click(object sender, EventArgs e)
        {
            var don = ReceptionDonMatierePremiere();
            PayerTransportMatierePremiere(don);
        }
    }
}

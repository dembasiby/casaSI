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
    public partial class UC_SortieDechetsMatierePremiere : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_SortieDechetsMatierePremiere()
        {
            InitializeComponent();
        }

        private void UC_SortieDechetsMatierePremiere_Load(object sender, EventArgs e)
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres
                                                                 .OrderBy(n => n.NomMatiere)
                                                                 .ToList();

            ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateSortieDechets).OrderBy(em => em.PrenomNom).ToList();
            ageEmployeBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateSortieDechets).OrderBy(em => em.PrenomNom).ToList();
        }

        private void BtnEnregistrerSortie_Click(object sender, EventArgs e)
        {
            try
            {
                int codeMatierePremiere = Convert.ToInt32(cbxMatierePremiere.SelectedValue.ToString());
                int codeResponsableStock = Convert.ToInt32(cbxResponsableStock.SelectedValue.ToString());
                int codeEmployantRecevantLesDechets = Convert.ToInt32(cbxEmployeAyantRecuLesDechets.SelectedValue.ToString());
                Validation.MontantEstValide(txtQuantite.Text);

                EveSortieDechetsMatieresPremiere sdmp = new EveSortieDechetsMatieresPremiere()
                {
                    DateSortie = dtpDateSortieDechets.Value.Date,
                    Description = txtDescription.Text,
                    CodeMatierePremiere = codeMatierePremiere,
                    QuantiteMatierePremiere = Convert.ToInt32(txtQuantite.Text),
                    CodeEmploye_responsable_stock_ = codeResponsableStock,
                    CodeEmploye_autre_responsable_ = codeEmployantRecevantLesDechets
                };

                db.EveSortieDechetsMatieresPremieres.Add(sdmp);
                db.SaveChanges();
                MessageBox.Show("L'opération a été enregistrée avec succès.");
            }
            catch (Exception)
            {
                MessageBox.Show("Echec de l'enregistrement. L'opération n'a pas pu être effectuée.");
            }
        }
    }
}

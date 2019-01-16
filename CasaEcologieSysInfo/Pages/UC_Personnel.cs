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
    public partial class UC_Personnel : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_Personnel()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var listePersonnel = (from p in db.AgeEmployes
                                  select new { Nom = p.PrenomNom, p.Poste }).ToList();

            dgvListePersonnel.DataSource = listePersonnel;
            cbxTimeSheetNomEmploye.DataSource = listePersonnel.Select(p => p.Nom).ToList();
        }

        private void UC_Personnel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnNouvelEmploye_Click(object sender, EventArgs e)
        {
            if (txtPosteEmploye.Text.Trim().Length > 0 && txtPrenomNom.Text.Trim().Length > 0)
            {
                AgeEmploye emp = new AgeEmploye()
                {
                    PrenomNom = txtPrenomNom.Text,
                    Poste = txtPosteEmploye.Text
                };

                db.AgeEmployes.Add(emp);
                db.SaveChanges();
                MessageBox.Show("Le nouvel employé a été ajouté avec succès à la base de données.");
                LoadData();
                txtPrenomNom.Clear();
                txtPosteEmploye.Clear();
            }
            else
            {
                MessageBox.Show("Les champs 'Prenom et Nom' et 'Poste' ne peuvent pas être vides.");
            }
        }

        private void btnPresenceEmploye_Click(object sender, EventArgs e)
        {
            var employe = cbxTimeSheetNomEmploye.GetItemText(cbxTimeSheetNomEmploye.SelectedItem);
            var codeEmploye = (from em in db.AgeEmployes
                               where em.PrenomNom == employe
                               select em.CodeEmploye).FirstOrDefault();

            if (EmployeNonEncoreEnregistrePourCeJour(codeEmploye))
            {
                EvePresenceEmploye pe = new EvePresenceEmploye()
                {
                    CodeEmploye = codeEmploye,
                    CodeUtilisationDesRessources = 0,
                    Date = DateTime.Parse(dtpDate.Text),
                    Arrivee = dtpArrivee.Value.TimeOfDay,
                    Depart = dtpDepart.Value.TimeOfDay,
                };

                db.EvePresenceEmployes.Add(pe);
                db.SaveChanges();
                MessageBox.Show("La présence de l'employé a été enregistrée avec succès.");
            }
            else
            {
                MessageBox.Show($"{employe} a déjà été enregistré pour le {dtpDate.Value.ToShortDateString()}");
                return;
            }
        }

        private bool EmployeNonEncoreEnregistrePourCeJour(int codeEmploye)
        {
            try
            {
                var presenceEmploye = (from pe in db.EvePresenceEmployes
                                       where pe.CodeEmploye == codeEmploye
                                       where pe.Date == dtpDate.Value.Date
                                       select pe).First();
                return false;
            }
            catch (Exception)
            {

                return true;
            }        
        }
    }
}

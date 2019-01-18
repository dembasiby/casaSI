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
            cbxTempsEtRemun.DataSource = listePersonnel.Select(p => p.Nom).ToList();
            cbxTimeSheetNomEmploye.DataSource = listePersonnel.Select(p => p.Nom).ToList();
            AfficherTempsEtRemunerationEmploye(dateTimePicker2.Value.Date);
        }

        private void AfficherTempsEtRemunerationEmploye(DateTime fin, DateTime debut = default(DateTime))
        {
            var employe = cbxTempsEtRemun.GetItemText(cbxTempsEtRemun.SelectedItem);

            var liste = (from pe in db.EvePresenceEmployes
                         where pe.AgeEmploye.PrenomNom == employe
                         where pe.Date >= debut.Date
                         where pe.Date <= fin.Date

                         select new
                         {
                             pe.Date,
                             Description = "Present",
                             TotalHeures = pe.Depart.Hours - pe.Arrivee.Hours,
                             TotalHeuresAPayer = 0,
                             TauxHoraire = 125,
                             Montant = 0,
                             
                         }).ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(liste);
            dgvTempsEtRemun.DataSource = dt;
            
            for (int i = 0; i < dgvTempsEtRemun.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvTempsEtRemun.Rows[i].Cells["TotalHeures"].Value) > 6)
                {
                    dgvTempsEtRemun.Rows[i].Cells["TotalHeuresAPayer"].Value = 6;
                }
                else
                {
                    dgvTempsEtRemun.Rows[i].Cells["TotalHeuresAPayer"].Value = dgvTempsEtRemun.Rows[i].Cells["TotalHeures"].Value;
                }

                dgvTempsEtRemun.Rows[i].Cells["Montant"].Value 
                    = Convert.ToInt32(dgvTempsEtRemun.Rows[i].Cells["TotalHeuresAPayer"].Value)
                    * Convert.ToInt32(dgvTempsEtRemun.Rows[i].Cells["TauxHoraire"].Value);
            }

            dt.Rows.Add(DateTime.Now, "Total", Conversion.CalculerTotal(dgvTempsEtRemun, "TotalHeures"), 
                Conversion.CalculerTotal(dgvTempsEtRemun, "TotalHeuresAPayer"), 0, 
                Conversion.CalculerTotal(dgvTempsEtRemun, "Montant"));
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

        private void cbxTempsEtRemun_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherTempsEtRemunerationEmploye(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AfficherTempsEtRemunerationEmploye(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AfficherTempsEtRemunerationEmploye(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date);
        }
    }
}

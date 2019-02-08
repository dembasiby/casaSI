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
    public partial class UC_RegistreImmobilisations : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_RegistreImmobilisations()
        {
            InitializeComponent();
        }

        private void UC_RegistreImmobilisations_Load(object sender, EventArgs e)
        {
            var immobilisations = (from inE in db.ResEquipementsInfrastructures
                                   where inE.DateAcquisition.Year + inE.DureeDeVie >= DateTime.Today.Year
                                   select new
                                   {
                                       Immobilisation = inE.Nom,
                                       inE.Quantite,
                                       ValeurDOrigine = inE.Montant,
                                       inE.DateAcquisition,
                                       inE.DureeDeVie,
                                       AmortissementMensuel = inE.Montant / (inE.DureeDeVie * 12),
                                       AmortissementTrimestriel = inE.Montant / (inE.DureeDeVie * 4),
                                       AmortissementAnnuel = inE.Montant / inE.DureeDeVie
                                   }).ToList();
            /*
            DataTable dt = Conversion.ConvertirEnTableDeDonnees(immobilisations);
            dgvImmobilisations.DataSource = dt;
            dt.Rows.Add("Total", 0, 0, DateTime.Today, 0, Conversion.CalculerTotal(dgvImmobilisations, "AmortissementMensuel"), Conversion.CalculerTotal(dgvImmobilisations, "AmortissementTrimestriel"), Conversion.CalculerTotal(dgvImmobilisations, "AmortissementAnnuel"));
            Formattage.RegistreImmobilisations(dgvImmobilisations);
            */
            ResEquipementsInfrastructureBindingSource.DataSource = db.ResEquipementsInfrastructures.ToList();
            reportViewer1.RefreshReport();

        

        }
    }
}

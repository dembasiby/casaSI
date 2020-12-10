using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;

namespace CasaEcologieSysInfo
{
    public partial class UC_TableauDeBord : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_TableauDeBord()
        {
            InitializeComponent();
        }

        private void UC_TableauDeBord_Load(object sender, EventArgs e)
        {
            AfficherTableauVentesMensuelles();
            AfficherTableaux();
        }

        private void AfficherTableaux()
        {
            AfficherDonneesGraphiqueQuantiteAcheteeParMatierePremiere();
            AfficherTop10DesProduitsVendus();
            AfficherCadeauxEtValeur();
            AfficherTop10DesClients();
        }

        private void AfficherDonneesGraphiqueQuantiteAcheteeParMatierePremiere()
        {
            var liste = (from mp in db.ResStockMatieresPremieres
                         join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                         where rmp.DateReception >= dtpDebut.Value.Date
                         where rmp.DateReception <= dtpFin.Value.Date

                         select new
                         {
                             Matiere = mp.NomMatiere,
                             Quantite = (from rm in db.EveReceptionMatieresPremieres
                                        join m in db.ResStockMatieresPremieres on rm.CodeMatierePremiere equals m.CodeMatierePremiere
                                        where rm.DateReception >= dtpDebut.Value.Date
                                        where rm.DateReception <= dtpFin.Value.Date
                                        where m.NomMatiere == mp.NomMatiere
                                        select rm.Quantite).Sum()
                         })
                         .DistinctBy(r => r.Matiere)
                         .OrderByDescending(m => m.Quantite)
                         .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(liste);
            
            dataGridView2.DataSource = dt;

            FormatterDonneesTableau(dataGridView2);
            dataGridView2.Columns["Quantite"].HeaderText = $"Quantité (kg)";
        }

        private void AfficherTableauVentesMensuelles()
        {
            ventesMensuellesResultBindingSource.DataSource = db.VentesMensuelles().ToList();
            var tableau = db.VentesMensuelles().ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(tableau);

            dataGridView1.DataSource = dt;

            var startingYear = 2020;
            var Annees = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Annees.Add(startingYear);
                startingYear++;
            }

            listBox1.DataSource = Annees;
            FormatterDonneesTableau(dataGridView1);
        }

        private void AfficherTop10DesProduitsVendus()
        {
            var liste = (from pf in db.ResStockProduitsFinis
                         join vpf in db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                         join v in db.EveVentes on vpf.CodeVente equals v.CodeVente
                         where v.DateVente >= dtpDebut.Value.Date
                         where v.DateVente <= dtpFin.Value.Date

                         select new
                         {
                             Produit = pf.NomProduit,
                             Ventes = (from vp in db.EveVenteStockProduitsFinis
                                         join pfin in db.ResStockProduitsFinis on vp.CodeProduitFini equals pfin.CodeProduit
                                         where vp.EveVente.DateVente >= dtpDebut.Value.Date
                                         where vp.EveVente.DateVente <= dtpFin.Value.Date
                                         where pfin.NomProduit == pf.NomProduit
                                         select vp.Montant).Sum(),
                             Quantite = (from vp in db.EveVenteStockProduitsFinis
                                            join pfin in db.ResStockProduitsFinis on vp.CodeProduitFini equals pfin.CodeProduit
                                            where vp.EveVente.DateVente >= dtpDebut.Value.Date
                                            where vp.EveVente.DateVente <= dtpFin.Value.Date
                                            where pfin.NomProduit == pf.NomProduit
                                            select vp.QuantiteProduitFini).Sum()
                         })
                        .DistinctBy(r => r.Produit)
                        .OrderByDescending(p => p.Ventes)
                        .Take(10)
                        .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(liste);

            dgvProduitsLesPlusVendus.DataSource = dt;

            FormatterDonneesTableau(dgvProduitsLesPlusVendus);
            dgvProduitsLesPlusVendus.Columns["Quantite"].HeaderText = $"Unités";
        }

        private void AfficherTop10DesClients()
        {
            var liste = (from c in db.AgeClients
                         join v in db.EveVentes on c.CodeClient equals v.CodeClient
                         where v.DateVente >= dtpDebut.Value.Date
                         where v.DateVente <= dtpFin.Value.Date

                         select new
                         {
                             Clients = c.NomClient + ", " + c.Localite,
                             Ventes = (from v in db.EveVentes
                                       join cl in db.AgeClients on v.CodeClient equals cl.CodeClient
                                       join vp in db.EveVenteStockProduitsFinis on v.CodeVente equals vp.CodeVente
                                       where v.DateVente >= dtpDebut.Value.Date
                                       where v.DateVente <= dtpFin.Value.Date
                                       where cl.NomClient == c.NomClient
                                       select vp.Montant).Sum(),
                         })
                        .DistinctBy(c => c.Clients)
                        .OrderByDescending(p => p.Ventes)
                        .Take(10)
                        .ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(liste);

            dgvTop10Clients.DataSource = dt;

            FormatterDonneesTableau(dgvTop10Clients);
            //dgvProduitsLesPlusVendus.Columns["Quantite"].HeaderText = $"Unités";
        }

        private void AfficherCadeauxEtValeur()
        {

            var liste = (from don in db.EveSortieDonsOuDechetsProduitsFinis
                         join pf in db.ResStockProduitsFinis on don.CodeProduitFini equals pf.CodeProduit
                         where don.DateSortie >= dtpDebut.Value.Date
                         where don.DateSortie <= dtpFin.Value.Date
                         select pf.NomProduit).Distinct().ToList();

            List<dynamic> listes = new List<object>();

            foreach (var item in liste)
            {
                var obj = (from don in db.EveSortieDonsOuDechetsProduitsFinis
                            join pf in db.ResStockProduitsFinis on don.CodeProduitFini equals pf.CodeProduit
                            where don.DateSortie >= dtpDebut.Value.Date
                            where don.DateSortie <= dtpFin.Value.Date
                            where pf.NomProduit == item
                            select new
                            {
                                Produit = pf.NomProduit,
                                Quantite = (from don in db.EveSortieDonsOuDechetsProduitsFinis
                                            join pf in db.ResStockProduitsFinis on don.CodeProduitFini equals pf.CodeProduit
                                            where don.DateSortie >= dtpDebut.Value.Date
                                            where don.DateSortie <= dtpFin.Value.Date
                                            where pf.NomProduit == item
                                            select don.QuantiteProduitFini).Sum(),
                                Valeur = (from don in db.EveSortieDonsOuDechetsProduitsFinis
                                            join pf in db.ResStockProduitsFinis on don.CodeProduitFini equals pf.CodeProduit
                                            where don.DateSortie >= dtpDebut.Value.Date
                                            where don.DateSortie <= dtpFin.Value.Date
                                            where pf.NomProduit == item
                                            select don.QuantiteProduitFini).Sum() * pf.PrixDeVenteStandard,
                            }).FirstOrDefault();
                listes.Add(obj);
            }

            if (listes.Count() > 0)
            {

                dgvCadeaux.DataSource = listes.OrderByDescending(p => p.Quantite).ToList();
                FormatterDonneesTableau(dgvCadeaux);
                dgvCadeaux.Columns["Quantite"].HeaderText = $"Unités";
            }
            else
            {
                dgvCadeaux.DataSource = null;
            }



        }


        // ****************************************************

        private void FormatterDonneesTableau(DataGridView grid)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].DefaultCellStyle.Format = "n0";
                if (i > 0)
                {
                    grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            AfficherTableaux();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            AfficherTableaux();
        }
    }
}

using ADGV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class Conversion
    {
        public static void AjouterNumeroVersion(Label lbl)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo infoVersion = FileVersionInfo.GetVersionInfo(assembly.Location);

            lbl.Text += $" v.{infoVersion.FileVersion } - Conception: Demba Siby (+221) 77 562 72 95";
        }

        // Conversion d'une liste en tableau de données
        public static DataTable ConvertirEnTableDeDonnees<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }

        // Filtre des tableaux AdvancedDataGridView
        public static void FiltrerTableau(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.RowFilter = myDataGrid.FilterString;
        }

        public static void TrierTableau(object sender, EventArgs e)
        {
            var myDataGrid = sender as ADGV.AdvancedDataGridView;
            (myDataGrid.DataSource as DataTable).DefaultView.Sort = myDataGrid.SortString;
        }

        // Calcul du total dans les tableaux
        public static Double CalculerTotal(int n, AdvancedDataGridView dataGrid, string columnName)
        {
            Double Tot = 0;

            for (int i = 0; i < dataGrid.Rows.Count - n; i++)
            {
                double V;
                if (dataGrid.Rows[i].Visible)
                {
                    V = string.IsNullOrEmpty(dataGrid.Rows[i].Cells[columnName].Value.ToString()) ? 0 
                        : Convert.ToDouble(dataGrid.Rows[i].Cells[columnName].Value.ToString().Replace("F CFA", "").Trim());
                }
                else
                {
                    V = 0;
                }

                Tot += V;
            }

            return Tot;
        }

        public static Double CalculerTotal(DataGridView dataGrid, string columnName)
        {
            Double Tot = 0;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                Tot += Convert.ToDouble(dataGrid.Rows[i].Cells[columnName].Value);

            }

            return Tot;
        }

        public static decimal CalculerTotalCreancesClients()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventesClients = (from c in db.AgeClients
                                     from vf in db.EveVenteStockProduitsFinis
                                     from v in db.EveVentes
                                     where v.CodeClient == c.CodeClient
                                     where vf.CodeVente == v.CodeVente
                                     select (decimal?)vf.Montant).Sum() ?? 0m;

                var totalPaiementClient = (from c in db.AgeClients
                                           from ev in db.EveEncaissementsVentes
                                           where c.CodeClient == ev.CodeClient
                                           select (decimal?)ev.MontantEncaisse).Sum() ?? 0m;
                var encaissementCreances = (from c in db.AgeClients
                                            from ec in db.EveEncaissementsCreances
                                            where c.CodeClient == ec.CodeClient
                                            select (decimal?)ec.MontantEncaisse).Sum() ?? 0m;

                var creanceInitialClient = (from c in db.AgeClients
                                            select (decimal?)c.SoldeInitialeCreance).Sum() ?? 0m;

                return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
            }         
        }

        public static Single CalculerTotalCreancesClientsALaDateDu(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var ventesClients = (from c in db.AgeClients
                                     from vf in db.EveVenteStockProduitsFinis
                                     from v in db.EveVentes
                                     where v.CodeClient == c.CodeClient
                                     where vf.CodeVente == v.CodeVente
                                     where v.DateVente <= date
                                     select (Single?)vf.Montant).Sum() ?? 0f;

                var totalPaiementClient = (from c in db.AgeClients
                                           from ev in db.EveEncaissementsVentes
                                           where c.CodeClient == ev.CodeClient
                                           where ev.DateEncaissement <= date
                                           select (Single?)ev.MontantEncaisse).Sum() ?? 0f;
                var encaissementCreances = (from c in db.AgeClients
                                            from ec in db.EveEncaissementsCreances
                                            where c.CodeClient == ec.CodeClient
                                            where ec.DateEncaissement <= date
                                            select (Single?)ec.MontantEncaisse).Sum() ?? 0f;

                var creanceInitialClient = (from c in db.AgeClients
                                            select (Single?)c.SoldeInitialeCreance).Sum() ?? 0f;

                return creanceInitialClient + ventesClients - totalPaiementClient - encaissementCreances;
            }
        }

        public static decimal CalculerTotalDettesFournisseurs()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                    select fmp.SoldeDette).Sum();

                var totalAchats = (from f in db.AgeFournisseursMatieresPremieres
                                   join rmp in db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                                   select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiements = (from fmp in db.AgeFournisseursMatieresPremieres
                                      join d in db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                                      select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFE = (from f in db.AgeAutreFournisseurs
                                      select f.SoldeInitialDetteFournisseur).Sum();

                var totalAchatsFE = (from f in db.AgeAutreFournisseurs
                                     join rmp in db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                                     join ei in db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                                     select (decimal?)ei.Montant).Sum() ?? 0m;

                var totalPaiementsFE = (from f in db.AgeAutreFournisseurs
                                        join d in db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFS = (from f in db.AgeFournisseursServicesFournitures
                                      select f.SoldeDette).Sum();

                var totalAchatsFS = (from f in db.AgeFournisseursServicesFournitures
                                     join rmp in db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiementsFS = (from f in db.EveAcquisitionServicesFournitures
                                        join d in db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                return soldeInitial + soldeInitialFE + soldeInitialFS
                    + totalAchats + totalAchatsFE + totalPaiementsFS
                    - totalPaiements - totalPaiementsFE - totalPaiementsFS;  
            }
        }

        public static decimal CalculerTotalDettesFournisseursALaDateDu(DateTime date)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                    select fmp.SoldeDette).Sum();

                var totalAchats = (from f in db.AgeFournisseursMatieresPremieres
                                   join rmp in db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                                   where rmp.DateReception <= date
                                   select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiements = (from fmp in db.AgeFournisseursMatieresPremieres
                                      join d in db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                                      where d.DateDecaissement <= date
                                      select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFE = (from f in db.AgeAutreFournisseurs
                                      select f.SoldeInitialDetteFournisseur).Sum();

                var totalAchatsFE = (from f in db.AgeAutreFournisseurs
                                     join rmp in db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                                     join ei in db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                                     where ei.DateAcquisition <= date
                                     select (decimal?)ei.Montant).Sum() ?? 0m;

                var totalPaiementsFE = (from f in db.AgeAutreFournisseurs
                                        join d in db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                        where d.DateDecaissement <= date
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFS = (from f in db.AgeFournisseursServicesFournitures
                                      select f.SoldeDette).Sum();

                var totalAchatsFS = (from f in db.AgeFournisseursServicesFournitures
                                     join rmp in db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                                     where rmp.Date <= date
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiementsFS = (from f in db.EveAcquisitionServicesFournitures
                                        join d in db.EveDecaissements on f.CodeAcquisitionServiceFourniture equals d.CodeAcquisitionServiceFourniture
                                        where d.DateDecaissement <= date
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                return soldeInitial + soldeInitialFE + soldeInitialFS
                    + totalAchats + totalAchatsFE + totalPaiementsFS
                    - totalPaiements - totalPaiementsFE - totalPaiementsFS;
            }
        }



        public static void CalculerSoldeStocksDeFaconProgressive(AdvancedDataGridView grid, float stockInitial)
        {
            for (int i = grid.Rows.Count - 1; i >= 0; i--)
            {

                if (i < grid.Rows.Count - 1)
                {
                    grid.Rows[i].Cells[4].Value = Convert.ToSingle(grid.Rows[i + 1].Cells[4].Value)
                    + Convert.ToSingle(grid.Rows[i].Cells[2].Value)
                    - Convert.ToSingle(grid.Rows[i].Cells[3].Value);
                }
                else
                {
                    grid.Rows[i].Cells[4].Value = stockInitial + Convert.ToSingle(grid.Rows[i].Cells[2].Value)
                    - Convert.ToSingle(grid.Rows[i].Cells[3].Value);
                }

            }
        }

        public static void CalculerSoldeStocksDeFaconProgressive(DataGridView grid, float stockInitial)
        {
            for (int i = grid.Rows.Count - 1; i >= 0; i--)
            {

                if (i < grid.Rows.Count - 1)
                {
                    grid.Rows[i].Cells[4].Value = Convert.ToSingle(grid.Rows[i + 1].Cells[4].Value)
                    + Convert.ToSingle(grid.Rows[i].Cells[2].Value)
                    - Convert.ToSingle(grid.Rows[i].Cells[3].Value);
                }
                else
                {
                    grid.Rows[i].Cells[4].Value = stockInitial + Convert.ToSingle(grid.Rows[i].Cells[2].Value)
                    - Convert.ToSingle(grid.Rows[i].Cells[3].Value);
                }

            }
        }

        public static decimal SoldeDisponibleDuCompteDeTresorerie(string nomCompte)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var soldeInitial = (from c in db.ResComptesTresoreries
                                    where c.NomCompte == nomCompte
                                   select c.SoldeCompte).FirstOrDefault();

                var totalEncaissements = (from c in db.EveEncaissements
                                         join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                          where nc.NomCompte == nomCompte
                                          from env in db.EveEncaissementsVentes
                                          where c.CodeEncaissement == env.CodeEncaissement
                                          
                                          select (decimal?)env.MontantEncaisse).Sum() ?? 0m;

                var encaissementCreances = (from c in db.EveEncaissements
                                            join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                            where nc.NomCompte == nomCompte
                                            from enc in db.EveEncaissementsCreances
                                            where c.CodeEncaissement == enc.CodeEncaissement

                                            select (decimal?)enc.MontantEncaisse).Sum() ?? 0m;

                var totalAutresEncaissement = (from c in db.EveEncaissements
                                               join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                               where nc.NomCompte == nomCompte
                                               from enA in db.EveEncaissementsAutres
                                               where c.CodeEncaissement == enA.CodeEncaissement

                                               select (decimal?)enA.MontantEncaisse).Sum() ?? 0m;

                var totalDecaissements = (from d in db.EveDecaissements
                                          where d.ResComptesTresorerie.NomCompte == nomCompte
                                          select (decimal?)d.Montant).Sum() ?? 0m;
              
                var fondsDisponibles = soldeInitial + totalEncaissements  + encaissementCreances + totalAutresEncaissement - totalDecaissements;

                return fondsDisponibles;
            }
        }

        public static void AfficherSoldeTresorerie(ComboBox listeComptes, TextBox txtBox)
        {
            var compte = listeComptes.GetItemText(listeComptes.SelectedItem);
            txtBox.Text = SoldeDisponibleDuCompteDeTresorerie(compte).ToString("n0");
        }

        public static bool IlYaAssezDeFondsDansLeCompte(ComboBox cbxCompte, TextBox txtMontantPaye)
        {
            var nomCompte = cbxCompte.GetItemText(cbxCompte.SelectedItem);
            var soldeCompte = SoldeDisponibleDuCompteDeTresorerie(nomCompte);

            if (Validation.VerifierChampsMontant(txtMontantPaye.Text) && int.Parse(txtMontantPaye.Text) < soldeCompte && soldeCompte > 0m)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Il n'y a pas assez de fonds dans le compte séléctionné pour effectuer ce paiement. Veuillez changer de compte ou diminuer le montant.");
                return false;
            }
    
        }

        public static decimal CalculerSoldeDetteParFournisseur(string nomFournisseur)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                
                var soldeInitial = (from fmp in db.AgeFournisseursMatieresPremieres
                                    where fmp.Nom == nomFournisseur
                                    select fmp.SoldeDette).FirstOrDefault();
                
                var totalAchats = (from f in db.AgeFournisseursMatieresPremieres
                                  where f.Nom == nomFournisseur
                                  join rmp in db.EveReceptionMatieresPremieres on f.CodeFournisseurMatierePremiere equals rmp.CodeFournisseurMatierePremiere
                                  select (decimal?)rmp.Montant).Sum() ?? 0m;
                
                var totalPaiements = (from fmp in db.AgeFournisseursMatieresPremieres
                                      where fmp.Nom == nomFournisseur
                                      join d in db.EveDecaissements on fmp.CodeFournisseurMatierePremiere equals d.CodeFournisseurMatierePremiere
                                      select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFE = (from f in db.AgeAutreFournisseurs
                                      where f.NomAutreFournisseur == nomFournisseur
                                      select f.SoldeInitialDetteFournisseur).FirstOrDefault();

                var totalAchatsFE = (from f in db.AgeAutreFournisseurs
                                     where f.NomAutreFournisseur == nomFournisseur
                                     join rmp in db.EveReceptionEquipementsInfrastructures on f.CodeAutreFournisseur equals rmp.CodeAutreFournisseur
                                     join ei in db.ResEquipementsInfrastructures on rmp.CodeEquipementInfrastructure equals ei.CodeEquipementInfrastructure
                                     select (decimal?)ei.Montant).Sum() ?? 0m;

                var totalPaiementsFE = (from f in db.AgeAutreFournisseurs
                                        where f.NomAutreFournisseur == nomFournisseur
                                        join d in db.EveDecaissements on f.CodeAutreFournisseur equals d.CodeAutreFournisseur
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                var soldeInitialFS = (from f in db.AgeFournisseursServicesFournitures
                                      where f.NomFournisseurServiceFourniture == nomFournisseur
                                      select f.SoldeDette).FirstOrDefault();

                var totalAchatsFS = (from f in db.AgeFournisseursServicesFournitures
                                     where f.NomFournisseurServiceFourniture == nomFournisseur
                                     join rmp in db.EveAcquisitionServicesFournitures on f.CodeFournisseurServiceFourniture equals rmp.CodeFournisseurServiceFourniture
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

                var totalPaiementsFS = (from f in db.AgeFournisseursServicesFournitures
                                        where f.NomFournisseurServiceFourniture == nomFournisseur
                                        join d in db.EveDecaissements on f.CodeFournisseurServiceFourniture equals d.CodeFournisseurService
                                        select (decimal?)d.Montant).Sum() ?? 0m;

                return soldeInitial + soldeInitialFE +  soldeInitialFS 
                    + totalAchats + totalAchatsFE + totalPaiementsFS
                    - totalPaiements - totalPaiementsFE - totalPaiementsFS;
            }
        }
    }
}

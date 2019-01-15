using ADGV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    class Conversion
    {

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
            using (CasaDBEntities2 db = new CasaDBEntities2())
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

                var creanceInitialClient = (from c in db.AgeClients
                                            select (decimal?)c.SoldeInitialeCreance).Sum() ?? 0m;

                return creanceInitialClient + ventesClients - totalPaiementClient;
            }         
        }

        public static decimal CalculerTotalDettesFournisseurs()
        {
            using (CasaDBEntities2 db = new CasaDBEntities2())
            {
                 var fournisseursMP = (from fmp in db.AgeFournisseursMatieresPremieres
                                    select new
                                    {
                                        Solde = ((decimal?)fmp.SoldeDette ?? 0m)
                                        + ((decimal?)fmp.EveReceptionMatieresPremieres.Sum(s => s.Montant) ?? 0m)
                                        - ((decimal?)fmp.EveDecaissements.Sum(m => m.Montant) ?? 0m)
                                    }
                                 ).Sum(d => (decimal?)d.Solde) ?? 0m;

                var achatEquip = (from rei in db.EveReceptionEquipementsInfrastructures
                                  select (decimal?)rei.Montant).Sum() ?? 0m;

                var soldeInitialFournisseurEquip = (from af in db.AgeAutreFournisseurs
                                                    select (decimal?)af.SoldeInitialDetteFournisseur).Sum() ?? 0m;

                var decaissementEquip = (from rei in db.EveReceptionEquipementsInfrastructures
                                         from d in db.EveDecaissements
                                         where d.CodeReceptionEquipementInfrastructure == rei.CodeReceptionEquipementInfrastructure
                                         select (decimal?)d.Montant).Sum() ?? 0m;

             

                var fournisseurFS = (from f in db.AgeFournisseursServicesFournitures
                                 select new
                                 {
                                     Solde = (decimal?)f.SoldeDette ?? 0m + (decimal?)f.EveAcquisitionServicesFournitures.Select(d => d.Montant).Sum() ?? 0m
                                     - (decimal?)f.EveDecaissements.Sum(m => m.Montant) ?? 0m
                                 }).Sum(s => (decimal?)s.Solde) ?? 0m;

                var totalDettesFournisseurs = fournisseursMP + achatEquip + soldeInitialFournisseurEquip - decaissementEquip + fournisseurFS;

                return totalDettesFournisseurs;
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
            using (CasaDBEntities2 db = new CasaDBEntities2())
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

                var totalAutresEncaissement = (from c in db.EveEncaissements
                                               join nc in db.ResComptesTresoreries on c.CodeCompte equals nc.CodeCompte
                                               where nc.NomCompte == nomCompte
                                               from enA in db.EveEncaissementsAutres
                                               where c.CodeEncaissement == enA.CodeEncaissement

                                               select (decimal?)enA.MontantEncaisse).Sum() ?? 0m;

                var totalDecaissements = (from d in db.EveDecaissements
                                          where d.ResComptesTresorerie.NomCompte == nomCompte
                                          select (decimal?)d.Montant).Sum() ?? 0m;
              
                var fondsDisponibles = soldeInitial + totalEncaissements  + totalAutresEncaissement - totalDecaissements;

                return fondsDisponibles;
            }
        }

        public static decimal CalculerSoldeDetteParFournisseur(string nomFournisseur)
        {
            using (CasaDBEntities2 db = new CasaDBEntities2())
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
                                     select (decimal?)rmp.Montant).Sum() ?? 0m;

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

       public static int CalculerSoldeStockProduitFini(string nomProduit)
        {
            using (CasaDBEntities2 db = new CasaDBEntities2())
            {
                var stockInitial = (from pf in db.ResStockProduitsFinis
                                    where pf.NomProduit == nomProduit
                                    select pf.StockProduit).FirstOrDefault();

                var entrees = (from pro in db.EveProductionStockProduitsFinis
                               where pro.ResStockProduitsFini.NomProduit == nomProduit
                               select (int?)pro.QuantiteProduitFini).Sum() ?? 0;

                var sorties = (from pf in db.EveVenteStockProduitsFinis
                               where pf.ResStockProduitsFini.NomProduit == nomProduit
                               select (int?)pf.QuantiteProduitFini).Sum() ?? 0;


                return stockInitial + entrees - sorties;
            }

        }

        public static bool MontantEstValide(string montant)
        {
            var estUnChiffre = int.TryParse(montant, out int n);

            if (string.IsNullOrEmpty(montant))
            {
                MessageBox.Show("Le champ 'Montant reçu' doit être renseigné.");
                return false;
            }
            else if (!estUnChiffre)
            {
                MessageBox.Show("Le champ 'Montant reçu' doit contenir uniquement des chiffres.");
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}

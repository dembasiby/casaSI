using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_StockMatieresPremieres : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();


        public UC_StockMatieresPremieres()
        {
            InitializeComponent();
        }

        private void UC_StockMatieresPremieres_Load(object sender, EventArgs e)
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.ToList();
            string nomCompte = listBox1.GetItemText(listBox1.SelectedItem);

            AfficherJournalCorrespondant(nomCompte);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomCompte = listBox1.GetItemText(listBox1.SelectedItem);
            AfficherJournalCorrespondant(nomCompte);
        }

        private void AfficherJournalCorrespondant(string nomMatiere)
        {
            float coutUnitaire = GestionStocks.CalculerCoutUnitaireMatierePremiere(nomMatiere);

            var entreesAchat = (from mp in db.ResStockMatieresPremieres
                           join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                           where mp.NomMatiere == nomMatiere
                           select new
                           {
                               Date = rmp.DateReception,
                               Description = "Achat de " + mp.NomMatiere,
                               Entree = rmp.Quantite,
                               Sortie = 0f,
                               Solde = 0f,
                           });
            var entreesDon = (from mp in db.ResStockMatieresPremieres
                              join dmp in db.EveReceptionDonsMatieresPremieres on mp.CodeMatierePremiere equals dmp.CodeMatierePremiere
                              where mp.NomMatiere == nomMatiere
                              select new
                              {
                                  Date = dmp.DateReception,
                                  Description = "Don de " + dmp.AgeFournisseursMatieresPremiere.Nom,
                                  Entree = (float)dmp.Quantite,
                                  Sortie = 0f,
                                  Solde = 0f
                              });

            var sortiesProduction = (from mp in db.ResStockMatieresPremieres
                           join ump in db.EveUtilisationMatieresPremieres on mp.CodeMatierePremiere equals ump.CodeMatierePremiere
                           join ur in db.EveUtilisationRessources on ump.CodeUtilisationRessource equals ur.CodeUtilisationRessources
                           join p in db.EveProductions on ur.CodeUtilisationRessources equals p.CodeUtilisationRessources
                           where mp.NomMatiere == nomMatiere
                           select new
                           {
                               p.Date,
                               Description = "Utilisation de " + mp.NomMatiere,
                               Entree = 0f,
                               Sortie = ump.QuantiteMatierePremiere,
                               Solde = 0f
                           });
            var sortiesAutre = (from mp in db.ResStockMatieresPremieres
                                join dmp in db.EveSortieDechetsMatieresPremieres on mp.CodeMatierePremiere equals dmp.CodeMatierePremiere
                                where mp.NomMatiere == nomMatiere
                                select new
                                {
                                    Date = dmp.DateSortie,
                                    Description = "Perte de " + mp.NomMatiere,
                                    Entree = 0f,
                                    Sortie = (float)dmp.QuantiteMatierePremiere,
                                    Solde = 0f
                                });

            var resultats = entreesAchat
                .Concat(entreesDon)
                .Concat(sortiesProduction)
                .Concat(sortiesAutre)
                .OrderByDescending(d => d.Date)
                .ToList();

            var stockInitial = (from mp in db.ResStockMatieresPremieres
                                where mp.NomMatiere == nomMatiere
                                select mp.StockMatiere).FirstOrDefault();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(resultats);
            
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, dt.Rows.Count);
            dr["Entree"] = 0;
            dr["Sortie"] = 0;
            dr["Description"] = "Stock Initial";

            dt.Columns.Add("PU", typeof(float));
            dt.Columns.Add("Valeur", typeof(float));
            
            dgvJournalStocksMatieresPremieres.DataSource = dt;

            Formattage.TableauDesStock(dgvJournalStocksMatieresPremieres);
            Conversion.CalculerSoldeStocksDeFaconProgressive(dgvJournalStocksMatieresPremieres, stockInitial);

            //float number;
            bool isNumeric = float.TryParse(coutUnitaire.ToString(), out float number);
            float pu = (isNumeric ? coutUnitaire : 0f);

            foreach (DataRow row in dt.Rows)
            {
                row["PU"] = pu;
                row["Valeur"] = Convert.ToSingle(row["Solde"].ToString()) * pu;
            }
        }
    }
}

 
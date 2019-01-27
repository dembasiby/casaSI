﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CasaEcologieSysInfo
{
    public partial class UC_StockMatieresPremieres : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();


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
            var entrees = (from mp in db.ResStockMatieresPremieres
                           join rmp in db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                           where mp.NomMatiere == nomMatiere
                           select new
                           {
                               Date = rmp.DateReception,
                               Description = "Achat de " + mp.NomMatiere,
                               Entree = rmp.Quantite,
                               Sortie = 0f,
                               Solde = 0f
                           });

            var sorties = (from mp in db.ResStockMatieresPremieres
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

            var resultats = entrees.Concat(sorties)
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
            
            adgvJournalStocksMatieresPremieres.DataSource = dt;

            Conversion.CalculerSoldeStocksDeFaconProgressive(adgvJournalStocksMatieresPremieres, stockInitial);
        }
    }
}

 
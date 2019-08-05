﻿using ADGV;
using DGVPrinterHelper;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Classes
{
    class Impression
    {
        public static void ImprimerTableau(string titre, DataGridView tableau)
        {
            try
            {
                DGVPrinter imprimante = new DGVPrinter
                {
                    Title = "Casa Ecologie de Bignona",
                    SubTitle = titre,
                    SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                    PageNumbers = true,
                    PageNumberInHeader = false,
                    PorportionalColumns = true,
                    HeaderCellAlignment = StringAlignment.Near,
                    Footer = DateTime.Today.ToShortDateString(),
                    FooterSpacing = 15
                };

                //imprimante.PrintPreviewNoDisplay(tableau);
                imprimante.printDocument.DefaultPageSettings.Landscape = true;
                imprimante.PrintDataGridView(tableau);             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur d'impression: {ex.Message}");
            }
        }

        public static void ImprimerTableau(string titre, AdvancedDataGridView tableau)
        {
            try
            {
                DGVPrinter imprimante = new DGVPrinter
                {
                    Title = "GIE Casa Ecologie de Bignona",
                    SubTitle = titre,
                    SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                    PageNumbers = true,
                    PageNumberInHeader = false,
                    PorportionalColumns = true,
                    HeaderCellAlignment = StringAlignment.Near,
                    Footer = DateTime.Today.ToShortDateString(),
                    FooterSpacing = 15,
                   
                };

                //imprimante.PrintPreviewNoDisplay(tableau);
                imprimante.printDocument.DefaultPageSettings.Landscape = true;
                imprimante.PrintDataGridView(tableau);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur d'impression: {ex.Message}");
            }          
        }

        public static void ImprimerFicheDeStock(ListBox liste, DataGridView grid)
        {
            var nomProduit = liste.GetItemText(liste.SelectedItem);
            ImprimerTableau($"Fiche de stock - {nomProduit}", grid);
        }

        public static void ImprimerJournalTresorerie(ListBox liste, DataGridView grid)
        {
            var nomCompte = liste.GetItemText(liste.SelectedItem);
            ImprimerTableau($"Journal de trésorerie - {nomCompte}", grid);
        }

        public static void ImprimerTableauTransactions(ListBox liste, DataGridView grid)
        {
            var fournisseur = liste.GetItemText(liste.SelectedItem);
            ImprimerTableau($"Tableau des transactions avec {fournisseur}", grid);
        }

        public static void ImprimerDetailsTransactionsClient(ListBox liste, DataGridView grid)
        {
            var client = liste.GetItemText(liste.SelectedItem);
            ImprimerTableau($"Tableau des transactions client avec {client}", grid);
        }
    }
}

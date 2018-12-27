using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class Accueil : Form
    {
        private bool isCollapsed = true;

        public Accueil()
        {
            InitializeComponent();
            UC_TableauDeBord tb = new UC_TableauDeBord();
            AddControlsToPanel(tb);
        } 
 
        private void AddControlsToPanel(Control c)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(c);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNouvelleVente_Click(object sender, EventArgs e)
        {
            UC_NouvelleVente nvente = new UC_NouvelleVente();
            AddControlsToPanel(nvente);
        }

        private void SetTimer(Panel p, Timer t)
        {
            if (isCollapsed)
            {
                p.Height += 10;
                if (p.Size == p.MaximumSize)
                {
                    t.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                p.Height -= 10;
                if (p.Size == p.MinimumSize)
                {
                    t.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetTimer(pnlVentes, timer1);
        }

        private void BtnVentes_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnDepenses_Click(object sender, EventArgs e)
        {
            tmrDepenses.Start();
        }

        private void BtnFournisseursEtClients_Click(object sender, EventArgs e)
        {
            tmrFournisseursClients.Start();
        }

        private void TmrDepenses_Tick(object sender, EventArgs e)
        {
            SetTimer(pnlDepenses, tmrDepenses);
        }

        private void TmrFournisseursClients_Tick(object sender, EventArgs e)
        {
            SetTimer(pnlFournisseurClient, tmrFournisseursClients);
        }

        private void TmrProductionStocks_Tick(object sender, EventArgs e)
        {
            SetTimer(pnlProductionStocks, tmrProductionStocks);
        }

        private void BtnProductionStock_Click(object sender, EventArgs e)
        {
            tmrProductionStocks.Start();
        }

        private void TmrTresorerie_Tick(object sender, EventArgs e)
        {
            SetTimer(pnlTresorerie, tmrTresorerie);
        }

        private void BtnTresorerie_Click(object sender, EventArgs e)
        {
            tmrTresorerie.Start();
        }

        private void TmrUtilisateurs_Tick(object sender, EventArgs e)
        {
            SetTimer(pnlUtilisateurs, tmrUtilisateurs);
        }

        private void BtnUtilisateurs_Click(object sender, EventArgs e)
        {
            tmrUtilisateurs.Start();
        }

        private void BtnMatierePremiere_Click(object sender, EventArgs e)
        {
            UC_AchatMatierePremiere amp = new UC_AchatMatierePremiere();
            AddControlsToPanel(amp);
        }

        private void BtnServiceFourniture_Click(object sender, EventArgs e)
        {
            UC_AcquisitionServicesFournitures asf = new UC_AcquisitionServicesFournitures();
            AddControlsToPanel(asf);
        }

        private void BtnEquipementInfrastructure_Click(object sender, EventArgs e)
        {
            UC_AchatEquipementInfrastructure aei = new UC_AchatEquipementInfrastructure();
            AddControlsToPanel(aei);
        }

        private void BtnJournalDepenses_Click(object sender, EventArgs e)
        {
            UC_JournalDepenses jd = new UC_JournalDepenses();
            AddControlsToPanel(jd);
        }

        private void BtnJournalVentes_Click(object sender, EventArgs e)
        {
            UC_JournalVentes jv = new UC_JournalVentes();
            AddControlsToPanel(jv);
        }

        private void BtnNouvelEncaissement_Click(object sender, EventArgs e)
        {
            UC_NouvelEncaissement ne = new UC_NouvelEncaissement();
            AddControlsToPanel(ne);
        }

        private void BtnNouvelleProduction_Click(object sender, EventArgs e)
        {
            UC_Production p = new UC_Production();
            AddControlsToPanel(p);
        }

        private void BtnTableauDeBord_Click(object sender, EventArgs e)
        {
            UC_TableauDeBord tb = new UC_TableauDeBord();
            AddControlsToPanel(tb);
        }

        private void BtnStockMatierePremiere_Click(object sender, EventArgs e)
        {
            UC_StockMatieresPremieres smp = new UC_StockMatieresPremieres();
            AddControlsToPanel(smp);
        }

        private void BtnStockProduitsFinis_Click(object sender, EventArgs e)
        {
            UC_StocksProduitsFinis spf = new UC_StocksProduitsFinis();
            AddControlsToPanel(spf);
        }

        private void BtnStockProduitsSemiFinis_Click(object sender, EventArgs e)
        {
            Pages.UC_StockProduitsSemiFinis spsf = new Pages.UC_StockProduitsSemiFinis();
            AddControlsToPanel(spsf);
        }

        private void BtnJournalTresorerie_Click(object sender, EventArgs e)
        {
            Pages.txtEquipmentsInfr jt = new Pages.txtEquipmentsInfr();
            AddControlsToPanel(jt);
        }

        private void btnCreancesClients_Click(object sender, EventArgs e)
        {
            Pages.UC_CreancesClients cc = new Pages.UC_CreancesClients();
            AddControlsToPanel(cc);
        }

        private void btnDettesFournisseurs_Click(object sender, EventArgs e)
        {
            Pages.UC_DettesFournisseurs df = new Pages.UC_DettesFournisseurs();
            AddControlsToPanel(df);
        }
    }
}

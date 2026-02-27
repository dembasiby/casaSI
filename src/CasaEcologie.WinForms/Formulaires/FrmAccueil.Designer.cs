namespace CasaEcologie.WinForms.Formulaires;

partial class FrmAccueil
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private Button CreateSidebarButton(string text, EventHandler clickHandler)
    {
        var btn = new Button();
        btn.Dock = DockStyle.Top;
        btn.FlatAppearance.BorderSize = 0;
        btn.FlatStyle = FlatStyle.Flat;
        btn.ForeColor = Color.White;
        btn.Size = new Size(220, 36);
        btn.Text = text;
        btn.TextAlign = ContentAlignment.MiddleLeft;
        btn.Padding = new Padding(10, 0, 0, 0);
        btn.Click += clickHandler;
        return btn;
    }

    private void InitializeComponent()
    {
        pnlSidebar = new Panel();
        lblTitre = new Label();
        pnlPrincipal = new Panel();
        pnlSidebar.SuspendLayout();
        SuspendLayout();
        //
        // pnlSidebar
        //
        pnlSidebar.BackColor = Color.FromArgb(45, 45, 48);
        pnlSidebar.AutoScroll = true;
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(240, 600);
        //
        // lblTitre
        //
        lblTitre.Dock = DockStyle.Top;
        lblTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitre.ForeColor = Color.White;
        lblTitre.Location = new Point(0, 0);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(240, 50);
        lblTitre.Text = "  Casa Écologie";
        lblTitre.TextAlign = ContentAlignment.MiddleLeft;
        //
        // Buttons (added in reverse order because Dock=Top stacks from bottom)
        //
        btnQuitter = CreateSidebarButton("Quitter", BtnQuitter_Click);
        btnQuitter.Dock = DockStyle.Bottom;
        btnUtilisateurs = CreateSidebarButton("Utilisateurs", BtnUtilisateurs_Click);
        btnEtatsFinanciers = CreateSidebarButton("États Financiers", BtnEtatsFinanciers_Click);
        btnJournalTresorerie = CreateSidebarButton("Journal trésorerie", BtnJournalTresorerie_Click);
        btnJournalProduction = CreateSidebarButton("Journal production", BtnJournalProduction_Click);
        btnJournalApprovisionnements = CreateSidebarButton("Journal approvision.", BtnJournalApprovisionnements_Click);
        btnJournalDepenses = CreateSidebarButton("Journal dépenses", BtnJournalDepenses_Click);
        btnJournalVentes = CreateSidebarButton("Journal ventes", BtnJournalVentes_Click);
        btnTransvasage = CreateSidebarButton("Transvasage", BtnTransvasage_Click);
        btnDechetsEtDonsProduitsFinis = CreateSidebarButton("Déchets/dons PF", BtnDechetsEtDonsProduitsFinis_Click);
        btnSortieDechetsMatierePremiere = CreateSidebarButton("Sortie déchets MP", BtnSortieDechetsMatierePremiere_Click);
        btnReceptionDonMatierePremiere = CreateSidebarButton("Réception don MP", BtnReceptionDonMatierePremiere_Click);
        btnAutreEncaissement = CreateSidebarButton("Autre encaissement", BtnAutreEncaissement_Click);
        btnNouveauCompteTresorerie = CreateSidebarButton("Nouveau compte", BtnNouveauCompteTresorerie_Click);
        btnMouvementCAC = CreateSidebarButton("Mouvement C à C", BtnMouvementCAC_Click);
        btnNouveauDecaissement = CreateSidebarButton("Nouveau décaissement", BtnNouveauDecaissement_Click);
        btnNouvelEncaissement = CreateSidebarButton("Nouvel encaissement", BtnNouvelEncaissement_Click);
        btnAchatEquipementInfrastructure = CreateSidebarButton("Achat équipements", BtnAchatEquipementInfrastructure_Click);
        btnAcquisitionServicesFournitures = CreateSidebarButton("Services / Fournitures", BtnAcquisitionServicesFournitures_Click);
        btnAchatMatierePremiere = CreateSidebarButton("Achat matière première", BtnAchatMatierePremiere_Click);
        btnNouvelleVente = CreateSidebarButton("Nouvelle Vente", BtnNouvelleVente_Click);
        btnPersonnel = CreateSidebarButton("Personnel", BtnPersonnel_Click);
        btnProduction = CreateSidebarButton("Production", BtnProduction_Click);
        btnCreancesClients = CreateSidebarButton("Créances clients", BtnCreancesClients_Click);
        btnDettesFournisseurs = CreateSidebarButton("Dettes fournisseurs", BtnDettesFournisseurs_Click);
        btnStockMatieresPremieres = CreateSidebarButton("Stock mat. premières", BtnStockMatieresPremieres_Click);
        btnStocksProduitsFinis = CreateSidebarButton("Stock produits finis", BtnStocksProduitsFinis_Click);
        btnStockProduitsSemiFinis = CreateSidebarButton("Stock prod. semi-finis", BtnStockProduitsSemiFinis_Click);
        btnStocksInventaire = CreateSidebarButton("Inventaire stocks", BtnStocksInventaire_Click);
        btnRegistreImmobilisations = CreateSidebarButton("Immobilisations", BtnRegistreImmobilisations_Click);
        btnTableauDeBord = CreateSidebarButton("Tableau de bord", BtnTableauDeBord_Click);
        //
        // Add controls to sidebar (reverse order for Dock=Top)
        //
        pnlSidebar.Controls.Add(btnQuitter);
        pnlSidebar.Controls.Add(btnUtilisateurs);
        pnlSidebar.Controls.Add(btnTableauDeBord);
        pnlSidebar.Controls.Add(btnEtatsFinanciers);
        pnlSidebar.Controls.Add(btnRegistreImmobilisations);
        pnlSidebar.Controls.Add(btnStocksInventaire);
        pnlSidebar.Controls.Add(btnStockProduitsSemiFinis);
        pnlSidebar.Controls.Add(btnStocksProduitsFinis);
        pnlSidebar.Controls.Add(btnStockMatieresPremieres);
        pnlSidebar.Controls.Add(btnDettesFournisseurs);
        pnlSidebar.Controls.Add(btnCreancesClients);
        pnlSidebar.Controls.Add(btnJournalTresorerie);
        pnlSidebar.Controls.Add(btnJournalProduction);
        pnlSidebar.Controls.Add(btnJournalApprovisionnements);
        pnlSidebar.Controls.Add(btnJournalDepenses);
        pnlSidebar.Controls.Add(btnJournalVentes);
        pnlSidebar.Controls.Add(btnTransvasage);
        pnlSidebar.Controls.Add(btnDechetsEtDonsProduitsFinis);
        pnlSidebar.Controls.Add(btnSortieDechetsMatierePremiere);
        pnlSidebar.Controls.Add(btnReceptionDonMatierePremiere);
        pnlSidebar.Controls.Add(btnAutreEncaissement);
        pnlSidebar.Controls.Add(btnNouveauCompteTresorerie);
        pnlSidebar.Controls.Add(btnMouvementCAC);
        pnlSidebar.Controls.Add(btnNouveauDecaissement);
        pnlSidebar.Controls.Add(btnNouvelEncaissement);
        pnlSidebar.Controls.Add(btnAchatEquipementInfrastructure);
        pnlSidebar.Controls.Add(btnAcquisitionServicesFournitures);
        pnlSidebar.Controls.Add(btnAchatMatierePremiere);
        pnlSidebar.Controls.Add(btnNouvelleVente);
        pnlSidebar.Controls.Add(btnProduction);
        pnlSidebar.Controls.Add(btnPersonnel);
        pnlSidebar.Controls.Add(lblTitre);
        //
        // pnlPrincipal
        //
        pnlPrincipal.Dock = DockStyle.Fill;
        pnlPrincipal.Location = new Point(240, 0);
        pnlPrincipal.Name = "pnlPrincipal";
        pnlPrincipal.Size = new Size(760, 600);
        //
        // FrmAccueil
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 600);
        Controls.Add(pnlPrincipal);
        Controls.Add(pnlSidebar);
        Name = "FrmAccueil";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Casa Écologie - Accueil";
        WindowState = FormWindowState.Maximized;
        pnlSidebar.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel pnlSidebar;
    private Panel pnlPrincipal;
    private Label lblTitre;
    private Button btnPersonnel;
    private Button btnNouvelleVente;
    private Button btnAchatMatierePremiere;
    private Button btnAcquisitionServicesFournitures;
    private Button btnAchatEquipementInfrastructure;
    private Button btnNouvelEncaissement;
    private Button btnNouveauDecaissement;
    private Button btnMouvementCAC;
    private Button btnNouveauCompteTresorerie;
    private Button btnAutreEncaissement;
    private Button btnReceptionDonMatierePremiere;
    private Button btnSortieDechetsMatierePremiere;
    private Button btnDechetsEtDonsProduitsFinis;
    private Button btnTransvasage;
    private Button btnJournalVentes;
    private Button btnJournalDepenses;
    private Button btnJournalApprovisionnements;
    private Button btnJournalProduction;
    private Button btnJournalTresorerie;
    private Button btnEtatsFinanciers;
    private Button btnUtilisateurs;
    private Button btnQuitter;
    private Button btnProduction;
    private Button btnCreancesClients;
    private Button btnDettesFournisseurs;
    private Button btnStockMatieresPremieres;
    private Button btnStocksProduitsFinis;
    private Button btnStockProduitsSemiFinis;
    private Button btnStocksInventaire;
    private Button btnRegistreImmobilisations;
    private Button btnTableauDeBord;
}

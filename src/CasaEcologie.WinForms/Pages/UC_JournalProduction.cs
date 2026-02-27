namespace CasaEcologie.WinForms.Pages;

public partial class UC_JournalProduction : UserControl
{
    private readonly ServiceContainer _services;

    public UC_JournalProduction(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_JournalProduction_Load(object sender, EventArgs e)
    {
        var year = DateTime.Today.Year;
        dtpDebut.Value = new DateTime(year, 1, 1);
        AfficherDatesProduction();
    }

    private void AfficherDatesProduction()
    {
        var productions = (from p in _services.Db.EveProductions
                           where p.Date >= dtpDebut.Value.Date
                           where p.Date <= dtpFin.Value.Date
                           orderby p.Date
                           select new
                           {
                               p.CodeProduction,
                               p.Date,
                           }).ToList();

        dgvJoursEtCodeProduction.DataSource = productions;
    }

    private void DgvJoursEtCodeProduction_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            lvwIntrantMatierePremiere.Items.Clear();
            lvwIntrantProduitSemiFini.Items.Clear();
            lvwExtrantProduitFini.Items.Clear();
            lvwExtrantProduitSemiFini.Items.Clear();
            lvwRessourcesHumaines.Items.Clear();

            int codeProduction = Convert.ToInt32(dgvJoursEtCodeProduction.SelectedCells[0].Value);

            AfficherListeMatieresPremieresUtilisees(codeProduction);
            AfficherListeProduitsSemiFinisUtilises(codeProduction);
            AfficherListeProduitsFinis(codeProduction);
            AfficherListeProduitsSemiFinisProduits(codeProduction);
            AfficherListeDesEmployes(codeProduction);
        }
        catch (Exception)
        {
            MessageBox.Show("Merci de cliquer sur la colonne des codes de production");
        }
    }

    private void AfficherListeMatieresPremieresUtilisees(int codeProduction)
    {
        var matieres = (from p in _services.Db.EveProductions
                        where p.CodeProduction == codeProduction
                        from ump in p.EveUtilisationRessource.EveUtilisationMatieresPremieres
                        select new
                        {
                            ump.ResStockMatieresPremiere.NomMatiere,
                            ump.QuantiteMatierePremiere,
                        }).ToList();

        foreach (var m in matieres)
        {
            var item = new ListViewItem(m.NomMatiere);
            item.SubItems.Add(m.QuantiteMatierePremiere.ToString());
            lvwIntrantMatierePremiere.Items.Add(item);
        }
    }

    private void AfficherListeProduitsSemiFinisUtilises(int codeProduction)
    {
        var produits = (from p in _services.Db.EveProductions
                        where p.CodeProduction == codeProduction
                        from upsf in p.EveUtilisationRessource.EveUtilisationProduitsSemiFinis
                        select new
                        {
                            upsf.ResStockProduitsSemiFini.Description,
                            upsf.QuantiteProduitSemiFini,
                        }).ToList();

        foreach (var pr in produits)
        {
            var item = new ListViewItem(pr.Description);
            item.SubItems.Add(pr.QuantiteProduitSemiFini.ToString());
            lvwIntrantProduitSemiFini.Items.Add(item);
        }
    }

    private void AfficherListeProduitsFinis(int codeProduction)
    {
        var produits = (from p in _services.Db.EveProductions
                        where p.CodeProduction == codeProduction
                        from ppf in p.EveProductionStockProduitsFinis
                        select new
                        {
                            ppf.ResStockProduitsFini.NomProduit,
                            ppf.QuantiteProduitFini,
                        }).ToList();

        foreach (var pr in produits)
        {
            var item = new ListViewItem(pr.NomProduit);
            item.SubItems.Add(pr.QuantiteProduitFini.ToString());
            lvwExtrantProduitFini.Items.Add(item);
        }
    }

    private void AfficherListeProduitsSemiFinisProduits(int codeProduction)
    {
        var produits = (from p in _services.Db.EveProductions
                        where p.CodeProduction == codeProduction
                        from ppsf in p.EveProductionProduitsSemiFinis
                        select new
                        {
                            ppsf.ResStockProduitsSemiFini.Description,
                            ppsf.QuantiteProduitSemiFini,
                        }).ToList();

        foreach (var pr in produits)
        {
            var item = new ListViewItem(pr.Description);
            item.SubItems.Add(pr.QuantiteProduitSemiFini.ToString());
            lvwExtrantProduitSemiFini.Items.Add(item);
        }
    }

    private void AfficherListeDesEmployes(int codeProduction)
    {
        var employes = (from p in _services.Db.EveProductions
                        where p.CodeProduction == codeProduction
                        from emp in _services.Db.EvePresenceEmployes
                        where emp.CodeUtilisationDesRessources == p.CodeUtilisationRessources
                        orderby emp.AgeEmploye.PrenomNom
                        select emp.AgeEmploye.PrenomNom).ToList();

        foreach (var nom in employes)
        {
            lvwRessourcesHumaines.Items.Add(new ListViewItem(nom));
        }
    }

    private void DtpDebut_ValueChanged(object sender, EventArgs e) => AfficherDatesProduction();
    private void DtpFin_ValueChanged(object sender, EventArgs e) => AfficherDatesProduction();
}

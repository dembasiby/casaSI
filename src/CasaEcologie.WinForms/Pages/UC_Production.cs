using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_Production : UserControl
{
    private readonly ServiceContainer _services;

    public UC_Production(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_Production_Load(object sender, EventArgs e)
    {
        ChargerDonneesInitiales();
        ChargerListeTravailleurs();

        var listePSF = _services.Db.ResStockProduitsSemiFinis
            .Select(psf => psf.Description)
            .ToList();
        cbxNomProduitSemiFini.Items.AddRange(listePSF.ToArray());
        if (cbxNomProduitSemiFini.Items.Count > 0)
            cbxNomProduitSemiFini.SelectedIndex = 0;

        AfficherSoldeStocksProduitsSemiFinis();
    }

    private void ChargerDonneesInitiales()
    {
        cbxNomMatiereP.DataSource = _services.Db.ResStockMatieresPremieres
            .Where(mp => mp.TypesMatiere.NomType == "Fruit")
            .OrderBy(mp => mp.NomMatiere)
            .ToList();
        cbxNomMatiereP.DisplayMember = "NomMatiere";
        cbxNomMatiereP.ValueMember = "CodeMatierePremiere";

        MontrerListeProduitsFinis();

        var employes = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateProduction.Value.Date)
            .Select(pe => pe.AgeEmploye.PrenomNom)
            .Distinct()
            .OrderBy(n => n)
            .ToList();

        cbxResponsableProduction.DataSource = new List<string>(employes);
        cbxRespMatPrem.DataSource = new List<string>(employes);
        cbxResponsableStockProduitFinis.DataSource = new List<string>(employes);

        var nomMatierePrem = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
        txtStockMatierePremiereDispo.Text = _services.Stock.CalculerSoldeStockMatierePremiere(nomMatierePrem, dtpDateProduction.Value.Date).ToString();

        cbxEmballage.DataSource = _services.Db.ResStockMatieresPremieres
            .Where(mp => mp.TypesMatiere.NomType == "Emballage" || mp.TypesMatiere.NomType == "Sachet")
            .ToList();
        cbxEmballage.DisplayMember = "NomMatiere";
        cbxEmballage.ValueMember = "CodeMatierePremiere";
        cbxEmballage.SelectedIndex = -1;

        cbxEtiquettes.DataSource = _services.Db.ResStockMatieresPremieres
            .Where(mp => mp.TypesMatiere.NomType == "Etiquette")
            .ToList();
        cbxEtiquettes.DisplayMember = "NomMatiere";
        cbxEtiquettes.ValueMember = "CodeMatierePremiere";
        cbxEtiquettes.SelectedIndex = -1;
    }

    private void ChargerListeTravailleurs()
    {
        clbEmployes.Items.Clear();
        var listeEmployes = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateProduction.Value.Date)
            .Select(pe => pe.AgeEmploye.PrenomNom)
            .Distinct()
            .OrderBy(n => n)
            .ToList();
        clbEmployes.Items.AddRange(listeEmployes.ToArray());
    }

    private void MontrerListeProduitsFinis()
    {
        cbxProduitsProduits.DataSource = _services.Db.ResStockProduitsFinis.OrderBy(p => p.NomProduit).ToList();
        cbxProduitsProduits.DisplayMember = "NomProduit";
        cbxProduitsProduits.ValueMember = "CodeProduit";
    }

    private void MontrerListeProduitsSemiFinis()
    {
        cbxProduitsProduits.DataSource = _services.Db.ResStockProduitsSemiFinis.OrderBy(psf => psf.Description).ToList();
        cbxProduitsProduits.DisplayMember = "Description";
        cbxProduitsProduits.ValueMember = "CodeProduitSemiFini";
    }

    private void DtpDateProduction_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeTravailleurs();
        ChargerDonneesInitiales();
    }

    private void CbxNomMatiereP_SelectedIndexChanged(object sender, EventArgs e)
    {
        var matP = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
        txtStockMatierePremiereDispo.Text = _services.Stock.CalculerSoldeStockMatierePremiere(matP, dtpDateProduction.Value.Date).ToString();
    }

    private void CbxNomProduitSemiFini_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeStocksProduitsSemiFinis();
    }

    private void AfficherSoldeStocksProduitsSemiFinis()
    {
        try
        {
            var prodSF = cbxNomProduitSemiFini.GetItemText(cbxNomProduitSemiFini.SelectedItem);
            var solde = _services.Stock.CalculerSoldeStockProduitSemiFini(prodSF, dtpDateProduction.Value.Date);
            txtStockProduitSFini.Text = solde.ToString();
        }
        catch
        {
            txtStockProduitSFini.Text = "0";
        }
    }

    private void RbtnProduitsFinis_CheckedChanged(object sender, EventArgs e)
    {
        MontrerListeProduitsFinis();
    }

    private void RbtnProduitsSemiFinis_CheckedChanged(object sender, EventArgs e)
    {
        MontrerListeProduitsSemiFinis();
    }

    private void BtnAjouterMatierePProduction_Click(object sender, EventArgs e)
    {
        try
        {
            if (float.Parse(txtStockMatierePremiereDispo.Text) <= 0f ||
                float.Parse(txtStockMatierePremiereDispo.Text) < float.Parse(txtQuantiteMatiereP.Text))
            {
                MessageBox.Show("Le stock de matière première disponible est insuffisant.");
                return;
            }

            AjouterIntrantsALaListe(txtQuantiteMatiereP.Text, cbxNomMatiereP.Text, lvwListeMatieresP);
            txtQuantiteMatiereP.Clear();
        }
        catch
        {
            MessageBox.Show("Merci de vérifier les données entrées.");
        }
    }

    private void BtnAjouterPSemiFiniProduction_Click(object sender, EventArgs e)
    {
        try
        {
            if (float.Parse(txtStockProduitSFini.Text) <= 0f ||
                float.Parse(txtStockProduitSFini.Text) < float.Parse(txtQuantiteProduitSemiFiniUtilise.Text))
            {
                MessageBox.Show("Le stock est insuffisant.");
                return;
            }

            AjouterIntrantsALaListe(txtQuantiteProduitSemiFiniUtilise.Text, cbxNomProduitSemiFini.Text, lvwListProduitsSemiFinisUtilises);
            txtQuantiteProduitSemiFiniUtilise.Clear();
        }
        catch
        {
            MessageBox.Show("Le stock de produit semi-fini disponible est insuffisant.");
        }
    }

    private void AjouterIntrantsALaListe(string quantite, string element, ListView liste)
    {
        if (string.IsNullOrEmpty(quantite))
        {
            MessageBox.Show("Le champs 'Quantité' ne peut être vide.");
            return;
        }

        if (float.Parse(quantite) <= 0)
        {
            MessageBox.Show("La quantité ne doit pas être nulle.");
            return;
        }

        var resultats = new ListViewItem(element) { Name = element };
        if (!liste.Items.ContainsKey(resultats.Name))
        {
            resultats.SubItems.Add(quantite);
            liste.Items.Add(resultats);
        }
        else
        {
            MessageBox.Show("Cet élément a déjà été ajouté une première fois.");
        }
    }

    private void BtnNouvelleProduction_Click(object sender, EventArgs e)
    {
        EnregistrerProduction();
    }

    private void EnregistrerProduction()
    {
        if (!cbxProdSansFruits.Checked && lvwListeMatieresP.Items.Count == 0 && lvwListProduitsSemiFinisUtilises.Items.Count == 0)
        {
            MessageBox.Show("Il est impératif d'utiliser une matière première ou un produit semi-fini pour réaliser une production.");
            return;
        }

        if (string.IsNullOrEmpty(txtQuantiteProduitProduit.Text) || int.Parse(txtQuantiteProduitProduit.Text) <= 0)
        {
            MessageBox.Show("La quantité produite doit être supérieure à zéro.");
            return;
        }

        if (clbEmployes.CheckedItems.Count == 0)
        {
            MessageBox.Show("Une production doit être réalisée par au moins un employé.");
            return;
        }

        if (rbtnProduitsFinis.Checked && cbxEmballage.SelectedIndex < 0)
        {
            MessageBox.Show("Merci de choisir un emballage");
            return;
        }

        var respProd = _services.Db.AgeEmployes.FirstOrDefault(rp => rp.PrenomNom == cbxResponsableProduction.Text);
        var respStockMatPrem = _services.Db.AgeEmployes.FirstOrDefault(rsmp => rsmp.PrenomNom == cbxRespMatPrem.Text);
        var respStockProduitsFinis = _services.Db.AgeEmployes.FirstOrDefault(rspf => rspf.PrenomNom == cbxResponsableStockProduitFinis.Text);

        if (respProd == null || respStockMatPrem == null || respStockProduitsFinis == null)
        {
            MessageBox.Show("Merci de sélectionner les responsables.");
            return;
        }

        // Créer utilisation des ressources
        var utilisationRessource = new EveUtilisationRessource
        {
            CodeEmployeRespProduction = respProd.CodeEmploye,
            CodeEmployeRespStockMatierePremiere = respStockMatPrem.CodeEmploye
        };
        _services.Db.EveUtilisationRessources.Add(utilisationRessource);
        _services.Db.SaveChanges();

        var codeUR = utilisationRessource.CodeUtilisationRessources;

        // Ajouter matières premières
        for (int i = 0; i < lvwListeMatieresP.Items.Count; i++)
        {
            var li = lvwListeMatieresP.Items[i];
            var matP = _services.Db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == li.Text);
            if (matP != null)
            {
                _services.Db.EveUtilisationMatieresPremieres.Add(new EveUtilisationMatieresPremiere
                {
                    CodeUtilisationRessource = codeUR,
                    CodeMatierePremiere = matP.CodeMatierePremiere,
                    QuantiteMatierePremiere = float.Parse(li.SubItems[1].Text)
                });
                _services.Db.SaveChanges();
            }
        }

        // Ajouter produits semi-finis
        for (int i = 0; i < lvwListProduitsSemiFinisUtilises.Items.Count; i++)
        {
            var li = lvwListProduitsSemiFinisUtilises.Items[i];
            var psf = _services.Db.ResStockProduitsSemiFinis.FirstOrDefault(p => p.Description == li.Text);
            if (psf != null)
            {
                _services.Db.EveUtilisationProduitsSemiFinis.Add(new EveUtilisationProduitsSemiFini
                {
                    CodeUtilisationRessource = codeUR,
                    CodeProduitSemiFini = psf.CodeProduitSemiFini,
                    QuantiteProduitSemiFini = float.Parse(li.SubItems[1].Text)
                });
                _services.Db.SaveChanges();
            }
        }

        // Ajouter travailleurs
        for (int i = 0; i < clbEmployes.CheckedItems.Count; i++)
        {
            var trav = clbEmployes.CheckedItems[i]!.ToString()!;
            var travailleur = _services.Db.AgeEmployes.FirstOrDefault(emp => emp.PrenomNom == trav);
            if (travailleur != null)
            {
                var presences = _services.Db.EvePresenceEmployes
                    .Where(pe => pe.CodeEmploye == travailleur.CodeEmploye && pe.Date == dtpDateProduction.Value.Date)
                    .ToList();
                presences.ForEach(em => em.CodeUtilisationDesRessources = codeUR);
                _services.Db.SaveChanges();
            }
        }

        // Créer production
        var production = new EveProduction
        {
            CodeUtilisationRessources = codeUR,
            CodeEmployeRespStockProduitsFinis = respStockProduitsFinis.CodeEmploye,
            Date = dtpDateProduction.Value.Date
        };
        _services.Db.EveProductions.Add(production);
        _services.Db.SaveChanges();

        var nomProduit = cbxProduitsProduits.GetItemText(cbxProduitsProduits.SelectedItem);

        if (rbtnProduitsFinis.Checked)
        {
            var emballage = cbxEmballage.GetItemText(cbxEmballage.SelectedItem);
            if (!string.IsNullOrEmpty(emballage))
            {
                var npf = _services.Db.ResStockProduitsFinis.FirstOrDefault(n => n.NomProduit == nomProduit);
                if (npf != null)
                {
                    // Utiliser emballage
                    UtiliserEmballage(codeUR, emballage, int.Parse(txtQuantiteProduitProduit.Text));

                    // Utiliser étiquette si coché
                    if (cbxUtiliserEtiquette.Checked && cbxEtiquettes.SelectedIndex >= 0)
                    {
                        var etiquette = cbxEtiquettes.GetItemText(cbxEtiquettes.SelectedItem);
                        UtiliserEmballage(codeUR, etiquette, int.Parse(txtQuantiteProduitProduit.Text));
                    }

                    // Utiliser sucre si coché
                    if (rbtnAvecSucre.Checked && !string.IsNullOrEmpty(txtQuantiteSucre.Text))
                    {
                        var matPSucre = _services.Db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == "Sucre en poudre");
                        if (matPSucre != null)
                        {
                            _services.Db.EveUtilisationMatieresPremieres.Add(new EveUtilisationMatieresPremiere
                            {
                                CodeUtilisationRessource = codeUR,
                                CodeMatierePremiere = matPSucre.CodeMatierePremiere,
                                QuantiteMatierePremiere = float.Parse(txtQuantiteSucre.Text)
                            });
                            _services.Db.SaveChanges();
                        }
                    }

                    _services.Db.EveProductionStockProduitsFinis.Add(new EveProductionStockProduitsFini
                    {
                        CodeProduction = production.CodeProduction,
                        CodeProduitFini = npf.CodeProduit,
                        QuantiteProduitFini = int.Parse(txtQuantiteProduitProduit.Text)
                    });
                    _services.Db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Veuillez choisir un emballage.");
                return;
            }
        }
        else
        {
            var npsf = _services.Db.ResStockProduitsSemiFinis.FirstOrDefault(n => n.Description == nomProduit);
            if (npsf != null)
            {
                _services.Db.EveProductionProduitsSemiFinis.Add(new EveProductionProduitsSemiFini
                {
                    CodeProduction = production.CodeProduction,
                    CodeProduitSemiFini = npsf.CodeProduitSemiFini,
                    QuantiteProduitSemiFini = int.Parse(txtQuantiteProduitProduit.Text)
                });
                _services.Db.SaveChanges();
            }
        }

        MessageBox.Show("La production a été enregistrée avec succès.");

        lvwListeMatieresP.Items.Clear();
        cbxEmballage.SelectedIndex = -1;
        txtQuantiteProduitProduit.Clear();
        lvwListProduitsSemiFinisUtilises.Items.Clear();

        var nomMatierePrem = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
        txtStockMatierePremiereDispo.Text = _services.Stock.CalculerSoldeStockMatierePremiere(nomMatierePrem, dtpDateProduction.Value.Date).ToString();
    }

    private void UtiliserEmballage(int codeURes, string emballage, int quantite)
    {
        var matP = _services.Db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == emballage);
        if (matP != null)
        {
            _services.Db.EveUtilisationMatieresPremieres.Add(new EveUtilisationMatieresPremiere
            {
                CodeUtilisationRessource = codeURes,
                CodeMatierePremiere = matP.CodeMatierePremiere,
                QuantiteMatierePremiere = quantite
            });
            _services.Db.SaveChanges();
        }
    }

    private void CbxEmballage_SelectedIndexChanged(object sender, EventArgs e)
    {
        var nomMatierePrem = cbxEmballage.GetItemText(cbxEmballage.SelectedItem);
        txtEmballagesDisponibles.Text = _services.Stock.CalculerSoldeStockMatierePremiere(nomMatierePrem, dtpDateProduction.Value.Date).ToString();
    }

    private void CbxEtiquettes_SelectedIndexChanged(object sender, EventArgs e)
    {
        var nomMatierePrem = cbxEtiquettes.GetItemText(cbxEtiquettes.SelectedItem);
        txtEtiquettesDisponibles.Text = _services.Stock.CalculerSoldeStockMatierePremiere(nomMatierePrem, dtpDateProduction.Value.Date).ToString();
    }

    private void CbxUtiliserEtiquette_CheckedChanged(object sender, EventArgs e)
    {
        cbxEtiquettes.Enabled = cbxUtiliserEtiquette.Checked;
    }
}

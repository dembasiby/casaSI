using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_NouvelleVente : UserControl
{
    private readonly ServiceContainer _services;

    public UC_NouvelleVente(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_NouvelleVente_Load(object sender, EventArgs e)
    {
        LoadData();
        txtMontantEncaisse.Text = "0";
    }

    private void LoadData()
    {
        ChargerListeEmployes();

        cbxNomClient.DisplayMember = "NomClient";
        cbxNomClient.ValueMember = "CodeClient";
        cbxNomClient.DataSource = _services.Db.AgeClients
            .OrderBy(c => c.NomClient)
            .ToList();

        cbxNomProduit.DisplayMember = "NomProduit";
        cbxNomProduit.ValueMember = "CodeProduit";
        cbxNomProduit.DataSource = _services.Db.ResStockProduitsFinis
            .OrderBy(p => p.NomProduit)
            .ToList();

        cbxCompte.DisplayMember = "NomCompte";
        cbxCompte.ValueMember = "CodeCompte";
        cbxCompte.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte)
            .ToList();

        MettreAJourStockProduitFini();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = ListeEmployesPresents(dtpDateVente.Value.Date);
        var noms = employesPresents.OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();

        cbxResponsableStockPrdtsFinis.DataSource = new List<string>(noms);
        cbxTres.DataSource = new List<string>(noms);
    }

    private List<AgeEmploye> ListeEmployesPresents(DateTime date)
    {
        return _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == date)
            .Select(pe => pe.AgeEmploye)
            .ToList();
    }

    private void MettreAJourStockProduitFini()
    {
        if (cbxNomProduit.SelectedItem is ResStockProduitsFini produit)
        {
            DateTime date = DateTime.Today.AddDays(1);
            txtSoldeStockProduit.Text = _services.Stock.CalculerSoldeStockProduitFini(produit.NomProduit, date).ToString();
        }
    }

    private void BtnNouveauClient_Click(object sender, EventArgs e)
    {
        string nomClient = txtNomClient.Text;
        string localite = txtLocalite.Text;

        if (string.IsNullOrWhiteSpace(nomClient) || string.IsNullOrWhiteSpace(localite))
        {
            MessageBox.Show("Veuillez renseigner les champs 'Nom Client' et 'Localité'.");
            return;
        }

        bool clientExiste = _services.Db.AgeClients.Any(c => c.NomClient == nomClient && c.Localite == localite);
        if (clientExiste)
        {
            MessageBox.Show("Cette combinaison de nom et de localité existe déjà dans la base de donnée. Si c'est une personne différente, veuillez ajouter un élément différenciateur.");
            return;
        }

        int.TryParse(txtSoldeInitialeCreance.Text, out int soldeInitialeCreance);

        var client = new AgeClient
        {
            NomClient = nomClient,
            Localite = localite,
            SoldeInitialeCreance = soldeInitialeCreance
        };

        _services.Db.AgeClients.Add(client);
        _services.Db.SaveChanges();
        txtNomClient.Clear();
        txtLocalite.Clear();
        txtSoldeInitialeCreance.Text = "00";
        MessageBox.Show("Le nouveau client a été ajouté avec succès");
        LoadData();
    }

    private void BtnAjouterProduitAuPanier_Click(object sender, EventArgs e)
    {
        var valQuantite = _services.Validation.VerifierChampsMontant(txtQuantite.Text);
        var valPrix = _services.Validation.VerifierChampsMontant(cbxPUProduit.Text);

        if (valQuantite.IsValid && valPrix.IsValid)
        {
            var montant = int.Parse(cbxPUProduit.Text) * int.Parse(txtQuantite.Text);

            ListViewItem item = new ListViewItem(cbxNomProduit.Text);
            item.SubItems.Add(txtQuantite.Text);
            item.SubItems.Add(cbxPUProduit.Text);
            item.SubItems.Add(montant.ToString());

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == item.SubItems[0].Text)
                {
                    MessageBox.Show("Ce produit est déjà dans le panier.");
                    return;
                }
            }

            listView1.Items.Add(item);
            lblTotalFacture.Text = TotalFacture().ToString();

            if (cbxNomProduit.SelectedItem is ResStockProduitsFini produit)
            {
                DateTime date = DateTime.Today.AddDays(1);
                txtSoldeStockProduit.Text = (_services.Stock.CalculerSoldeStockProduitFini(produit.NomProduit, date)
                                              - int.Parse(txtQuantite.Text)).ToString();
            }

            txtQuantite.Clear();
        }
    }

    private decimal TotalFacture()
    {
        decimal total = 0;
        for (int i = 0; i < listView1.Items.Count; i++)
        {
            total += int.Parse(listView1.Items[i].SubItems[3].Text);
        }
        return total;
    }

    private void BtnEnregistrerVente_Click(object sender, EventArgs e)
    {
        int codeClient = Convert.ToInt32(cbxNomClient.SelectedValue);
        var client = _services.Db.AgeClients.FirstOrDefault(c => c.CodeClient == codeClient);
        var resStock = _services.Db.AgeEmployes.FirstOrDefault(rs => rs.PrenomNom == cbxResponsableStockPrdtsFinis.Text);
        var tres = _services.Db.AgeEmployes.FirstOrDefault(rv => rv.PrenomNom == cbxTres.Text);
        var cpte = _services.Db.ResComptesTresoreries.FirstOrDefault(cte => cte.NomCompte == cbxCompte.Text);

        if (client == null || resStock == null || tres == null || cpte == null) return;

        try
        {
            var totalFacture = Convert.ToInt32(lblTotalFacture.Text);
            if (totalFacture <= 0) return;

            var vente = new EveVente
            {
                CodeClient = client.CodeClient,
                CodeEmploye = resStock.CodeEmploye,
                DateVente = dtpDateVente.Value.Date
            };

            _services.Db.EveVentes.Add(vente);
            _services.Db.SaveChanges();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string produitNom = listView1.Items[i].SubItems[0].Text;
                int quantite = int.Parse(listView1.Items[i].SubItems[1].Text);
                int montant = int.Parse(listView1.Items[i].SubItems[3].Text);

                if (quantite >= 1 && montant >= 1)
                {
                    var produit = _services.Db.ResStockProduitsFinis.FirstOrDefault(p => p.NomProduit == produitNom);
                    if (produit != null)
                    {
                        var venteProduit = new EveVenteStockProduitsFini
                        {
                            CodeVente = vente.CodeVente,
                            CodeProduitFini = produit.CodeProduit,
                            QuantiteProduitFini = quantite,
                            Montant = montant
                        };
                        _services.Db.EveVenteStockProduitsFinis.Add(venteProduit);
                    }
                }
            }

            _services.Db.SaveChanges();

            int.TryParse(txtMontantEncaisse.Text, out int montantEncaisse);

            if (montantEncaisse > 0)
            {
                var enc = new EveEncaissement
                {
                    CodeEmploye = tres.CodeEmploye,
                    CodeCompte = cpte.CodeCompte,
                };

                _services.Db.EveEncaissements.Add(enc);
                _services.Db.SaveChanges();

                var encV = new EveEncaissementsVente
                {
                    CodeClient = client.CodeClient,
                    CodeEncaissement = enc.CodeEncaissement,
                    CodeVente = vente.CodeVente,
                    MontantEncaisse = montantEncaisse,
                    DateEncaissement = dtpDateVente.Value.Date
                };

                _services.Db.EveEncaissementsVentes.Add(encV);
                _services.Db.SaveChanges();
            }

            listView1.Items.Clear();
            lblTotalFacture.Text = "";
            txtMontantEncaisse.Text = "0";
            MessageBox.Show("La vente a été enregistrée avec succès.");
        }
        catch (Exception)
        {
            MessageBox.Show("La vente n'a pas été enregistrée.");
        }
    }

    private void CbxNomProduit_SelectedIndexChanged(object sender, EventArgs e)
    {
        MettreAJourStockProduitFini();
    }

    private void BtnIncrementQuantite_Click(object sender, EventArgs e)
    {
        try
        {
            var total = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);
            var stock = int.Parse(txtSoldeStockProduit.Text);

            if (stock > 0)
            {
                stock -= 1;
                total += 1;
                listView1.FocusedItem.SubItems[1].Text = total.ToString();
                listView1.FocusedItem.SubItems[3].Text = (total * int.Parse(listView1.FocusedItem.SubItems[2].Text)).ToString();
                txtSoldeStockProduit.Text = stock.ToString();
                lblTotalFacture.Text = TotalFacture().ToString();
            }
            else
            {
                MessageBox.Show("Il n'y a pas assez de produits en stocks.");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Veuillez selectionner un produit dans la liste.");
        }
    }

    private void BtnDecrementQuantite_Click(object sender, EventArgs e)
    {
        try
        {
            var total = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);
            var stock = int.Parse(txtSoldeStockProduit.Text);

            if (total == 0)
            {
                MessageBox.Show("Il doit y avoir au moins un produit dans le panier.");
                listView1.FocusedItem.Remove();
                return;
            }

            stock += 1;
            total -= 1;
            listView1.FocusedItem.SubItems[1].Text = total.ToString();
            listView1.FocusedItem.SubItems[3].Text = (total * int.Parse(listView1.FocusedItem.SubItems[2].Text)).ToString();
            txtSoldeStockProduit.Text = stock.ToString();
            lblTotalFacture.Text = TotalFacture().ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("Veuillez selectionner un produit dans la liste.", "Erreur de choix d'un produit");
        }
    }

    private void BtnRetirer_Click(object sender, EventArgs e)
    {
        try
        {
            var quantite = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);
            var stock = int.Parse(txtSoldeStockProduit.Text);

            listView1.FocusedItem.Remove();

            stock += quantite;
            txtSoldeStockProduit.Text = stock.ToString();
            lblTotalFacture.Text = TotalFacture().ToString("c0");
        }
        catch (Exception)
        {
            MessageBox.Show("Veuillez selectionner un produit dans la liste.");
        }
    }

    private void DtpDateVente_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}

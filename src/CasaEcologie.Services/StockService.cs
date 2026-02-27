using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;
using CasaEcologie.Domain.Models;

namespace CasaEcologie.Services;

public class StockService : IStockService
{
    private readonly CasaDbContext _db;

    public StockService(CasaDbContext db)
    {
        _db = db;
    }

    public float CalculerSoldeStockMatierePremiere(string nomMatiere, DateTime date)
    {
        var stockInitial = _db.ResStockMatieresPremieres
            .Where(mp => mp.NomMatiere == nomMatiere)
            .Select(mp => mp.StockMatiere)
            .FirstOrDefault();

        var entrees = _db.EveReceptionMatieresPremieres
            .Where(rmp => rmp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Where(rmp => rmp.DateReception <= date)
            .Select(rmp => (float?)rmp.Quantite).Sum() ?? 0;

        var dons = _db.EveReceptionDonsMatieresPremieres
            .Where(dmp => dmp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Where(dmp => dmp.DateReception <= date)
            .Select(dmp => (float?)dmp.Quantite).Sum() ?? 0;

        var sorties = (from ur in _db.EveUtilisationMatieresPremieres
                       where ur.ResStockMatieresPremiere.NomMatiere == nomMatiere
                       join p in _db.EveProductions on ur.CodeUtilisationRessource equals p.CodeUtilisationRessources
                       where p.Date <= date
                       select (float?)ur.QuantiteMatierePremiere).Sum() ?? 0;

        var autresSorties = _db.EveSortieDechetsMatieresPremieres
            .Where(s => s.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Where(s => s.DateSortie <= date)
            .Select(s => (float?)s.QuantiteMatierePremiere).Sum() ?? 0;

        return (stockInitial + entrees + dons) - (sorties + autresSorties);
    }

    public int CalculerSoldeStockProduitFini(string produitFini, DateTime date)
    {
        var stockInitial = _db.ResStockProduitsFinis
            .Where(pf => pf.NomProduit == produitFini)
            .Select(pf => pf.StockProduit)
            .FirstOrDefault();

        var entrees = (from pro in _db.EveProductionStockProduitsFinis
                       where pro.ResStockProduitsFini.NomProduit == produitFini
                       where pro.EveProduction.Date <= date.Date
                       select (int?)pro.QuantiteProduitFini).Sum() ?? 0;

        var sorties = (from pf in _db.EveVenteStockProduitsFinis
                       where pf.ResStockProduitsFini.NomProduit == produitFini
                       where pf.EveVente.DateVente <= date.Date
                       select (int?)pf.QuantiteProduitFini).Sum() ?? 0;

        var autresSorties = (from asort in _db.EveSortieDonsOuDechetsProduitsFinis
                             where asort.ResStockProduitsFini.NomProduit == produitFini
                             where asort.DateSortie <= date.Date
                             select (int?)asort.QuantiteProduitFini).Sum() ?? 0;

        return stockInitial + entrees - (sorties + autresSorties);
    }

    public int CalculerSoldeStockProduitSemiFini(string produitSemiFini, DateTime date)
    {
        var stockInitial = _db.ResStockProduitsSemiFinis
            .Where(psf => psf.Description == produitSemiFini)
            .Select(psf => psf.Quantite)
            .FirstOrDefault();

        var entrees = (from pro in _db.EveProductionProduitsSemiFinis
                       where pro.ResStockProduitsSemiFini.Description == produitSemiFini
                       where pro.EveProduction.Date <= date.Date
                       select (int?)pro.QuantiteProduitSemiFini).Sum() ?? 0;

        var sorties = (from upsf in _db.EveUtilisationProduitsSemiFinis
                       join ur in _db.EveUtilisationRessources on upsf.CodeUtilisationRessource equals ur.CodeUtilisationRessources
                       join p in _db.EveProductions on ur.CodeUtilisationRessources equals p.CodeUtilisationRessources
                       where upsf.ResStockProduitsSemiFini.Description == produitSemiFini
                       where p.Date <= date.Date
                       select (int?)upsf.QuantiteProduitSemiFini).Sum() ?? 0;

        return stockInitial + entrees - sorties;
    }

    public float CoutUnitaireParMatierePremiere(string nomMatiere)
    {
        var quantiteAchetee = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Select(amp => (float?)amp.Quantite).Sum() ?? 0f;

        var valeurDesAchats = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Select(amp => (float?)amp.Montant).Sum() ?? 0f;

        var coutTransport = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Select(amp => (float?)amp.TransportMatierePremiere).Sum() ?? 0f;

        if (quantiteAchetee == 0f) return 0f;
        return (valeurDesAchats + coutTransport) / quantiteAchetee;
    }

    public float ValeurAchatsMatierePremiere(string nomMatiere, DateTime debut, DateTime fin)
    {
        var achats = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Where(amp => amp.DateReception >= debut.Date)
            .Where(amp => amp.DateReception <= fin.Date)
            .Select(amp => (float?)amp.Montant).Sum() ?? 0f;

        var quantiteDonsRecu = _db.EveReceptionDonsMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == nomMatiere)
            .Where(amp => amp.DateReception >= debut.Date)
            .Where(amp => amp.DateReception <= fin.Date)
            .Select(amp => (float?)amp.Quantite).Sum() ?? 0f;

        var valeurDons = quantiteDonsRecu * CoutUnitaireParMatierePremiere(nomMatiere);

        return achats + valeurDons;
    }

    public decimal QuantiteMatierePremiereParProduitFini(string nomProduit, string matierePremiere)
    {
        var data = (from pf in _db.ResStockProduitsFinis
                    join ppf in _db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                    join ur in _db.EveUtilisationMatieresPremieres on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                    where ur.ResStockMatieresPremiere.NomMatiere == matierePremiere
                    where pf.NomProduit == nomProduit
                    select new
                    {
                        ur.QuantiteMatierePremiere,
                        ppf.QuantiteProduitFini
                    });

        var quantiteMatP = data.Select(m => (float?)m.QuantiteMatierePremiere).Sum() ?? 0f;
        var quantitePF = data.Select(m => (float?)m.QuantiteProduitFini).Sum() ?? 0f;

        if (quantiteMatP > 0f && quantitePF > 0f)
            return (decimal)quantiteMatP / (decimal)quantitePF;

        return 0m;
    }

    public decimal QuantiteMatierePremiereParProduitSemiFini(string produitSemiFini, string matierePremiere)
    {
        var data = (from psf in _db.ResStockProduitsSemiFinis
                    join ppf in _db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppf.CodeProduitSemiFini
                    join ur in _db.EveUtilisationMatieresPremieres on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                    where ur.ResStockMatieresPremiere.NomMatiere == matierePremiere
                    where psf.Description == produitSemiFini
                    select new
                    {
                        ur.QuantiteMatierePremiere,
                        ppf.QuantiteProduitSemiFini
                    });

        var quantiteMatP = data.Select(m => (float?)m.QuantiteMatierePremiere).Sum() ?? 0f;
        var quantitePSF = data.Select(m => (float?)m.QuantiteProduitSemiFini).Sum() ?? 0f;

        if (quantiteMatP > 0f && quantitePSF > 0f)
            return (decimal)quantiteMatP / (decimal)quantitePSF;

        return 0m;
    }

    public decimal QuantiteProduitSemiFiniParProduitFini(string nomProduit, string produitSemiFini)
    {
        var data = (from pf in _db.ResStockProduitsFinis
                    join ppf in _db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                    join ur in _db.EveUtilisationProduitsSemiFinis on ppf.EveProduction.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                    where ur.ResStockProduitsSemiFini.Description == produitSemiFini
                    where pf.NomProduit == nomProduit
                    select new
                    {
                        ur.QuantiteProduitSemiFini,
                        ppf.QuantiteProduitFini
                    });

        var quantitePSF = data.Select(m => (float?)m.QuantiteProduitSemiFini).Sum() ?? 0f;
        var quantitePF = data.Select(m => (float?)m.QuantiteProduitFini).Sum() ?? 0f;

        if (quantitePSF > 0f && quantitePF > 0f)
            return (decimal)quantitePSF / (decimal)quantitePF;

        return 0m;
    }

    public float CalculerCoutUnitaireMatierePremiere(string matiere)
    {
        var valeurAchats = (from mp in _db.ResStockMatieresPremieres
                            join rmp in _db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                            where rmp.DateReception.Year == DateTime.Now.Year
                            where mp.NomMatiere == matiere
                            select (float?)(rmp.Montant + rmp.TransportMatierePremiere)).Sum() ?? 0f;

        var quantitesAchetees = (from mp in _db.ResStockMatieresPremieres
                                 join rmp in _db.EveReceptionMatieresPremieres on mp.CodeMatierePremiere equals rmp.CodeMatierePremiere
                                 where rmp.DateReception.Year == DateTime.Now.Year
                                 where mp.NomMatiere == matiere
                                 select (float?)rmp.Quantite).Sum() ?? 0f;

        if (quantitesAchetees == 0f) return 0f;
        return valeurAchats / quantitesAchetees;
    }

    public List<StockMovementRow> CalculerSoldeStocksDeFaconProgressive(List<StockMovementRow> rows, float stockInitial)
    {
        for (int i = rows.Count - 1; i >= 0; i--)
        {
            if (i < rows.Count - 1)
            {
                rows[i].Solde = rows[i + 1].Solde + rows[i].Entrees - rows[i].Sorties;
            }
            else
            {
                rows[i].Solde = stockInitial + rows[i].Entrees - rows[i].Sorties;
            }
        }

        return rows;
    }

    public float ValeurTotalDesStocks(DateTime date)
    {
        return ValeurStockProduitsFinis(date)
            + ValeurStockProduitsSemiFinis(date)
            + ValeurStockMatieresPremieres(date);
    }

    private float CoutDAchat(string matiere)
    {
        float coutUnitaire = (float)_db.ResStockMatieresPremieres
            .Where(mp => mp.NomMatiere == matiere)
            .Select(mp => mp.CoutUnitaire)
            .FirstOrDefault();

        float coutMatierePremiere = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == matiere)
            .Select(amp => (float?)amp.Montant).Sum() ?? 0f;

        float coutTransport = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == matiere)
            .Select(amp => (float?)amp.TransportMatierePremiere).Sum() ?? 0f;

        float quantiteAchetee = _db.EveReceptionMatieresPremieres
            .Where(amp => amp.ResStockMatieresPremiere.NomMatiere == matiere)
            .Select(amp => (float?)amp.Quantite).Sum() ?? 0f;

        float coutTotal = coutMatierePremiere + coutTransport;
        if ((int)quantiteAchetee > 0) coutUnitaire = coutTotal / quantiteAchetee;

        return coutUnitaire;
    }

    private float ValeurStockMatieresPremieres(DateTime date)
    {
        float valeur = 0;
        var listeMatieresPremieres = _db.ResStockMatieresPremieres
            .Select(mp => mp.NomMatiere).ToList();

        foreach (var matPrem in listeMatieresPremieres)
        {
            valeur += CalculerSoldeStockMatierePremiere(matPrem, date) * CoutDAchat(matPrem);
        }

        return valeur;
    }

    private float CoutUnitaireProduction(string produitFini)
    {
        var listeMatieres = (from pf in _db.ResStockProduitsFinis
                             join ppf in _db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                             join p in _db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                             join ur in _db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                             where pf.NomProduit == produitFini
                             select ur.ResStockMatieresPremiere.NomMatiere).Distinct().ToList();

        float coutMatieres = 0;
        foreach (var mat in listeMatieres)
        {
            coutMatieres += (float)QuantiteMatierePremiereParProduitFini(produitFini, mat) * CoutDAchat(mat);
        }

        if (coutMatieres == 0)
        {
            coutMatieres = _db.ResStockProduitsFinis
                .Where(pf => pf.NomProduit == produitFini)
                .Select(pf => pf.CoutUnitaire)
                .FirstOrDefault();
        }

        return coutMatieres;
    }

    private float CoutUnitaireProduitSemiFini(string produitSemiFini)
    {
        var listeMatieres = (from psf in _db.ResStockProduitsSemiFinis
                             join ppf in _db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppf.CodeProduitSemiFini
                             join p in _db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                             join ur in _db.EveUtilisationMatieresPremieres on p.CodeUtilisationRessources equals ur.CodeUtilisationRessource
                             where psf.Description == produitSemiFini
                             select ur.ResStockMatieresPremiere.NomMatiere).Distinct().ToList();

        float coutMatieres = 0;
        foreach (var mat in listeMatieres)
        {
            coutMatieres += (float)QuantiteMatierePremiereParProduitSemiFini(produitSemiFini, mat) * CoutDAchat(mat);
        }

        if (coutMatieres == 0)
        {
            coutMatieres = _db.ResStockProduitsSemiFinis
                .Where(psf => psf.Description == produitSemiFini)
                .Select(psf => psf.CoutUnitaire)
                .FirstOrDefault();
        }

        return coutMatieres;
    }

    private float ValeurStockProduitsFinis(DateTime date)
    {
        float valeur = 0;
        var listeProduitsFinis = _db.ResStockProduitsFinis
            .Select(pf => pf.NomProduit).ToList();

        foreach (var produit in listeProduitsFinis)
        {
            valeur += CalculerSoldeStockProduitFini(produit, date) * CoutUnitaireProduction(produit);
        }

        return valeur;
    }

    private float ValeurStockProduitsSemiFinis(DateTime date)
    {
        float valeur = 0;
        var listeProduitsSemiFinis = _db.ResStockProduitsSemiFinis
            .Select(psf => psf.Description).ToList();

        foreach (var produitSF in listeProduitsSemiFinis)
        {
            valeur += CalculerSoldeStockProduitSemiFini(produitSF, date) * CoutUnitaireProduitSemiFini(produitSF);
        }

        return valeur;
    }
}

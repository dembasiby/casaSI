using CasaEcologie.Data;
using CasaEcologie.Domain.Interfaces;

namespace CasaEcologie.Services;

public class CoutService : ICoutService
{
    private readonly CasaDbContext _db;
    private readonly IStockService _stockService;

    public CoutService(CasaDbContext db, IStockService stockService)
    {
        _db = db;
        _stockService = stockService;
    }

    public decimal CoutDAchatMatieresPremieresConsommees(DateTime debut, DateTime fin)
    {
        var listeMatieresPremieres = _db.ResStockMatieresPremieres
            .Select(mp => mp.NomMatiere).ToList();

        decimal total = 0;
        foreach (var matiere in listeMatieresPremieres)
        {
            total += (decimal)CoutDesMatieresConsommees(debut, fin, matiere);
        }

        return total;
    }

    public decimal CoutDeProduction(DateTime debut, DateTime fin)
    {
        var listeProduitsVendus = (from pf in _db.ResStockProduitsFinis
                                   join vpf in _db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                                   join v in _db.EveVentes on vpf.CodeVente equals v.CodeVente
                                   where v.DateVente >= debut && v.DateVente <= fin
                                   select pf.NomProduit).Distinct().ToList();

        decimal cogs = 0;
        foreach (var produit in listeProduitsVendus)
        {
            int quantiteVendue = QuantiteDeProduitsVendus(produit, debut, fin);
            float coutUnitaire = CoutUnitaireProduction(produit);
            cogs += quantiteVendue * (decimal)coutUnitaire;
        }

        return cogs;
    }

    public float ValeurStockMatieresPremieres(DateTime date)
    {
        float valeur = 0;
        var listeMatieresPremieres = _db.ResStockMatieresPremieres
            .Select(mp => mp.NomMatiere).ToList();

        foreach (var matPrem in listeMatieresPremieres)
        {
            valeur += _stockService.CalculerSoldeStockMatierePremiere(matPrem, date) * CoutDAchat(matPrem);
        }

        return valeur;
    }

    public float ValeurStockProduitsFinis(DateTime date)
    {
        float valeur = 0;
        var listeProduitsFinis = _db.ResStockProduitsFinis
            .Select(pf => pf.NomProduit).ToList();

        foreach (var produit in listeProduitsFinis)
        {
            valeur += _stockService.CalculerSoldeStockProduitFini(produit, date) * CoutUnitaireProduction(produit);
        }

        return valeur;
    }

    public float ValeurStockProduitsSemiFinis(DateTime date)
    {
        float valeur = 0;
        var listeProduitsSemiFinis = _db.ResStockProduitsSemiFinis
            .Select(psf => psf.Description).ToList();

        foreach (var produitSF in listeProduitsSemiFinis)
        {
            valeur += _stockService.CalculerSoldeStockProduitSemiFini(produitSF, date) * CoutUnitaireProduitSemiFini(produitSF);
        }

        return valeur;
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

    private float CoutDesMatieresConsommees(DateTime debut, DateTime fin, string matiere)
    {
        float stockInitial = _stockService.CalculerSoldeStockMatierePremiere(matiere, debut);
        float stockFinal = _stockService.CalculerSoldeStockMatierePremiere(matiere, fin);

        float achats = _db.EveReceptionMatieresPremieres
            .Where(rmp => rmp.ResStockMatieresPremiere.NomMatiere == matiere)
            .Where(rmp => rmp.DateReception >= debut)
            .Where(rmp => rmp.DateReception <= fin)
            .Select(rmp => (float?)rmp.Quantite).Sum() ?? 0;

        float dons = _db.EveReceptionDonsMatieresPremieres
            .Where(rdmp => rdmp.ResStockMatieresPremiere.NomMatiere == matiere)
            .Where(rdmp => rdmp.DateReception >= debut)
            .Where(rdmp => rdmp.DateReception <= fin)
            .Select(rdmp => (float?)rdmp.Quantite).Sum() ?? 0;

        float quantiteConsommee = stockInitial + achats + dons - stockFinal;

        float coutUnitaire = CoutDAchat(matiere);
        if (coutUnitaire <= 0)
        {
            coutUnitaire = (float)_db.ResStockMatieresPremieres
                .Where(mp => mp.NomMatiere == matiere)
                .Select(mp => mp.CoutUnitaire)
                .FirstOrDefault();
        }

        return quantiteConsommee * coutUnitaire;
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
            coutMatieres += (float)_stockService.QuantiteMatierePremiereParProduitFini(produitFini, mat) * CoutDAchat(mat);
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
            coutMatieres += (float)_stockService.QuantiteMatierePremiereParProduitSemiFini(produitSemiFini, mat) * CoutDAchat(mat);
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

    private int QuantiteDeProduitsVendus(string produitFini, DateTime debut, DateTime fin)
    {
        int stockInitial = _stockService.CalculerSoldeStockProduitFini(produitFini, debut);
        int stockFinal = _stockService.CalculerSoldeStockProduitFini(produitFini, fin);

        int entrees = (from ppf in _db.EveProductionStockProduitsFinis
                       join pf in _db.ResStockProduitsFinis on ppf.CodeProduitFini equals pf.CodeProduit
                       join p in _db.EveProductions on ppf.CodeProduction equals p.CodeProduction
                       where pf.NomProduit == produitFini
                       where p.Date >= debut && p.Date <= fin
                       select (int?)ppf.QuantiteProduitFini).Sum() ?? 0;

        var autresSorties = (from asort in _db.EveSortieDonsOuDechetsProduitsFinis
                             where asort.ResStockProduitsFini.NomProduit == produitFini
                             where asort.DateSortie >= debut && asort.DateSortie <= fin
                             select (int?)asort.QuantiteProduitFini).Sum() ?? 0;

        return stockInitial + entrees - autresSorties - stockFinal;
    }
}

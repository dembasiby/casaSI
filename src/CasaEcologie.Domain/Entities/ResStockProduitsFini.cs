namespace CasaEcologie.Domain.Entities;

public class ResStockProduitsFini
{
    public int CodeProduit { get; set; }
    public string NomProduit { get; set; } = null!;
    public int StockProduit { get; set; }
    public int PrixDeVenteStandard { get; set; }
    public int? CodeEmballage { get; set; }
    public int CoutUnitaire { get; set; }

    public ResStockMatieresPremiere? ResStockMatieresPremiere { get; set; }
    public List<EveProductionStockProduitsFini> EveProductionStockProduitsFinis { get; set; } = [];
    public List<EveVenteStockProduitsFini> EveVenteStockProduitsFinis { get; set; } = [];
    public List<EveTransvasement> EveTransvasementsInitial { get; set; } = [];
    public List<EveTransvasement> EveTransvasementsFinal { get; set; } = [];
    public List<EveSortieDonsOuDechetsProduitsFini> EveSortieDonsOuDechetsProduitsFinis { get; set; } = [];
}

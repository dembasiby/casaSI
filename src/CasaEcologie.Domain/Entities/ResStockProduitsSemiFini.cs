namespace CasaEcologie.Domain.Entities;

public class ResStockProduitsSemiFini
{
    public int CodeProduitSemiFini { get; set; }
    public int CodeMatierePremiere { get; set; }
    public int Quantite { get; set; }
    public string Description { get; set; } = null!;
    public int CoutUnitaire { get; set; }

    public ResStockMatieresPremiere ResStockMatieresPremiere { get; set; } = null!;
    public List<EveProductionProduitsSemiFini> EveProductionProduitsSemiFinis { get; set; } = [];
    public List<EveUtilisationProduitsSemiFini> EveUtilisationProduitsSemiFinis { get; set; } = [];
}

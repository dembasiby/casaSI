namespace CasaEcologie.Domain.Entities;

public class EveProductionProduitsSemiFini
{
    public int CodeProduction { get; set; }
    public int CodeProduitSemiFini { get; set; }
    public double QuantiteProduitSemiFini { get; set; }

    public EveProduction EveProduction { get; set; } = null!;
    public ResStockProduitsSemiFini ResStockProduitsSemiFini { get; set; } = null!;
}

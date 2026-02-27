namespace CasaEcologie.Domain.Entities;

public class EveProductionStockProduitsFini
{
    public int CodeProduction { get; set; }
    public int CodeProduitFini { get; set; }
    public int QuantiteProduitFini { get; set; }

    public EveProduction EveProduction { get; set; } = null!;
    public ResStockProduitsFini ResStockProduitsFini { get; set; } = null!;
}

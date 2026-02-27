namespace CasaEcologie.Domain.Entities;

public class EveVenteStockProduitsFini
{
    public int CodeVente { get; set; }
    public int CodeProduitFini { get; set; }
    public int QuantiteProduitFini { get; set; }
    public decimal Montant { get; set; }

    public EveVente EveVente { get; set; } = null!;
    public ResStockProduitsFini ResStockProduitsFini { get; set; } = null!;
}

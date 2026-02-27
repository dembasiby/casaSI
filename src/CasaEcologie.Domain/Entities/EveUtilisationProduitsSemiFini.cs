namespace CasaEcologie.Domain.Entities;

public class EveUtilisationProduitsSemiFini
{
    public int CodeUtilisationRessource { get; set; }
    public int CodeProduitSemiFini { get; set; }
    public double QuantiteProduitSemiFini { get; set; }

    public EveUtilisationRessource EveUtilisationRessource { get; set; } = null!;
    public ResStockProduitsSemiFini ResStockProduitsSemiFini { get; set; } = null!;
}

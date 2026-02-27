namespace CasaEcologie.Domain.Entities;

public class EveSortieDonsOuDechetsProduitsFini
{
    public int CodeSortieDonsDechetsPrdtFini { get; set; }
    public DateTime DateSortie { get; set; }
    public string Description { get; set; } = null!;
    public int CodeProduitFini { get; set; }
    public int QuantiteProduitFini { get; set; }
    public int CodeResponsableSortie { get; set; }

    public AgeEmploye AgeEmploye { get; set; } = null!;
    public ResStockProduitsFini ResStockProduitsFini { get; set; } = null!;
}

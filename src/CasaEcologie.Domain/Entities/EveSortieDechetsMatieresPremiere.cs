namespace CasaEcologie.Domain.Entities;

public class EveSortieDechetsMatieresPremiere
{
    public int CodeSortieDechet { get; set; }
    public DateTime DateSortie { get; set; }
    public string Description { get; set; } = null!;
    public int CodeMatierePremiere { get; set; }
    public double QuantiteMatierePremiere { get; set; }
    public int CodeEmployeResponsableStock { get; set; }
    public int CodeEmployeAutreResponsable { get; set; }

    public AgeEmploye AgeEmployeResponsableStock { get; set; } = null!;
    public AgeEmploye AgeEmployeAutreResponsable { get; set; } = null!;
    public ResStockMatieresPremiere ResStockMatieresPremiere { get; set; } = null!;
}

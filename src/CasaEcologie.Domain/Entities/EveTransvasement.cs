namespace CasaEcologie.Domain.Entities;

public class EveTransvasement
{
    public int CodeTransvasage { get; set; }
    public DateTime DateOperation { get; set; }
    public int CodeEmballageInitial { get; set; }
    public double QuantiteATransvaser { get; set; }
    public int CodeEmballageFinal { get; set; }
    public int CodeProduitInitial { get; set; }
    public int CodeProduitFinal { get; set; }

    public ResStockMatieresPremiere ResStockMatieresPremiereInitial { get; set; } = null!;
    public ResStockMatieresPremiere ResStockMatieresPremiereFinal { get; set; } = null!;
    public ResStockProduitsFini ResStockProduitsFiniInitial { get; set; } = null!;
    public ResStockProduitsFini ResStockProduitsFinisFinal { get; set; } = null!;
}

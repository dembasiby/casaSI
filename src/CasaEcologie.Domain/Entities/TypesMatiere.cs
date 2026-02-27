namespace CasaEcologie.Domain.Entities;

public class TypesMatiere
{
    public int CodeTypeMatiere { get; set; }
    public string NomType { get; set; } = null!;

    public List<ResStockMatieresPremiere> ResStockMatieresPremieres { get; set; } = [];
}

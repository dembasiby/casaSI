namespace CasaEcologie.Domain.Entities;

public class EveUtilisationMatieresPremiere
{
    public int CodeUtilisationRessource { get; set; }
    public int CodeMatierePremiere { get; set; }
    public double QuantiteMatierePremiere { get; set; }

    public EveUtilisationRessource EveUtilisationRessource { get; set; } = null!;
    public ResStockMatieresPremiere ResStockMatieresPremiere { get; set; } = null!;
}

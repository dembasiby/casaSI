namespace CasaEcologie.Domain.Entities;

public class ResStockMatieresPremiere
{
    public int CodeMatierePremiere { get; set; }
    public string NomMatiere { get; set; } = null!;
    public float StockMatiere { get; set; }
    public decimal CoutUnitaire { get; set; }
    public int CodeTypeMatiere { get; set; }

    public TypesMatiere TypesMatiere { get; set; } = null!;
    public List<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; } = [];
    public List<EveUtilisationMatieresPremiere> EveUtilisationMatieresPremieres { get; set; } = [];
    public List<ResStockProduitsSemiFini> ResStockProduitsSemiFinis { get; set; } = [];
    public List<EveReceptionDonsMatieresPremiere> EveReceptionDonsMatieresPremieres { get; set; } = [];
    public List<EveSortieDechetsMatieresPremiere> EveSortieDechetsMatieresPremieres { get; set; } = [];
    public List<EveTransvasement> EveTransvasementsInitial { get; set; } = [];
    public List<EveTransvasement> EveTransvasementsFinal { get; set; } = [];
}

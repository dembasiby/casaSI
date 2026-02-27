namespace CasaEcologie.Domain.Entities;

public class EveProduction
{
    public int CodeProduction { get; set; }
    public int CodeUtilisationRessources { get; set; }
    public int? CodeEmployeRespStockProduitsFinis { get; set; }
    public DateTime Date { get; set; }

    public AgeEmploye? AgeEmploye { get; set; }
    public EveUtilisationRessource EveUtilisationRessource { get; set; } = null!;
    public List<EveProductionProduitsSemiFini> EveProductionProduitsSemiFinis { get; set; } = [];
    public List<EveProductionStockProduitsFini> EveProductionStockProduitsFinis { get; set; } = [];
}

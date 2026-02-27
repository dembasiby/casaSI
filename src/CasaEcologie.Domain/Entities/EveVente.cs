namespace CasaEcologie.Domain.Entities;

public class EveVente
{
    public int CodeVente { get; set; }
    public int CodeClient { get; set; }
    public int CodeEmploye { get; set; }
    public DateTime DateVente { get; set; }

    public AgeClient AgeClient { get; set; } = null!;
    public AgeEmploye AgeEmploye { get; set; } = null!;
    public List<EveEncaissementsVente> EveEncaissementsVentes { get; set; } = [];
    public List<EveVenteStockProduitsFini> EveVenteStockProduitsFinis { get; set; } = [];
}

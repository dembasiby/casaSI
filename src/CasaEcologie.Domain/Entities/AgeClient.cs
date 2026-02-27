namespace CasaEcologie.Domain.Entities;

public class AgeClient
{
    public int CodeClient { get; set; }
    public string NomClient { get; set; } = null!;
    public string Localite { get; set; } = null!;
    public decimal SoldeInitialeCreance { get; set; }

    public List<EveVente> EveVentes { get; set; } = [];
    public List<EveEncaissementsVente> EveEncaissementsVentes { get; set; } = [];
    public List<EveEncaissementsCreance> EveEncaissementsCreances { get; set; } = [];
}

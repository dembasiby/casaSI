namespace CasaEcologie.Domain.Entities;

public class EveEncaissementsVente
{
    public int CodeEncaissement { get; set; }
    public int CodeVente { get; set; }
    public decimal MontantEncaisse { get; set; }
    public DateTime DateEncaissement { get; set; }
    public int CodeClient { get; set; }

    public EveEncaissement EveEncaissement { get; set; } = null!;
    public EveVente EveVente { get; set; } = null!;
    public AgeClient AgeClient { get; set; } = null!;
}

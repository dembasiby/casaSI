namespace CasaEcologie.Domain.Entities;

public class EveEncaissementsCreance
{
    public int CodeEncaissementCreance { get; set; }
    public int CodeClient { get; set; }
    public decimal MontantEncaisse { get; set; }
    public DateTime DateEncaissement { get; set; }
    public int CodeEncaissement { get; set; }

    public AgeClient AgeClient { get; set; } = null!;
    public EveEncaissement EveEncaissement { get; set; } = null!;
}

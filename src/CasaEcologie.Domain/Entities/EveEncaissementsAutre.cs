namespace CasaEcologie.Domain.Entities;

public class EveEncaissementsAutre
{
    public int CodeEncaissementAutre { get; set; }
    public int CodeEncaissement { get; set; }
    public DateTime DateEncaissement { get; set; }
    public string Description { get; set; } = null!;
    public decimal MontantEncaisse { get; set; }
    public bool FondsExternes { get; set; }

    public EveEncaissement EveEncaissement { get; set; } = null!;
}

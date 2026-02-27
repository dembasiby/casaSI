namespace CasaEcologie.Domain.Entities;

public class EvePaiementEmploye
{
    public int CodePaiementEmploye { get; set; }
    public int CodeEmployePaye { get; set; }
    public DateTime DeCetteDate { get; set; }
    public DateTime ACetteDate { get; set; }

    public AgeEmploye AgeEmploye { get; set; } = null!;
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
}

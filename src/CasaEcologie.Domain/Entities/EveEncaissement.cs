namespace CasaEcologie.Domain.Entities;

public class EveEncaissement
{
    public int CodeEncaissement { get; set; }
    public int CodeEmploye { get; set; }
    public int CodeCompte { get; set; }

    public AgeEmploye AgeEmploye { get; set; } = null!;
    public ResComptesTresorerie ResComptesTresorerie { get; set; } = null!;
    public List<EveEncaissementsVente> EveEncaissementsVentes { get; set; } = [];
    public List<EveEncaissementsAutre> EveEncaissementsAutres { get; set; } = [];
    public List<EveEncaissementsCreance> EveEncaissementsCreances { get; set; } = [];
}

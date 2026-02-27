namespace CasaEcologie.Domain.Entities;

public class AgeAutreFournisseur
{
    public int CodeAutreFournisseur { get; set; }
    public string NomAutreFournisseur { get; set; } = null!;
    public string? Localite { get; set; }
    public decimal SoldeInitialDetteFournisseur { get; set; }

    public List<EveDecaissement> EveDecaissements { get; set; } = [];
    public List<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; } = [];
}

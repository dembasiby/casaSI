namespace CasaEcologie.Domain.Entities;

public class EveReceptionEquipementsInfrastructure
{
    public int CodeReceptionEquipementInfrastructure { get; set; }
    public int CodeEquipementInfrastructure { get; set; }
    public int CodeEmploye { get; set; }
    public int CodeAutreFournisseur { get; set; }

    public AgeAutreFournisseur AgeAutreFournisseur { get; set; } = null!;
    public AgeEmploye AgeEmploye { get; set; } = null!;
    public ResEquipementsInfrastructure ResEquipementsInfrastructure { get; set; } = null!;
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
}

namespace CasaEcologie.Domain.Entities;

public class ResEquipementsInfrastructure
{
    public int CodeEquipementInfrastructure { get; set; }
    public string Nom { get; set; } = null!;
    public DateTime DateAcquisition { get; set; }
    public int DureeDeVie { get; set; }
    public int Quantite { get; set; }
    public bool MaterielDeProduction { get; set; }
    public decimal Montant { get; set; }

    public List<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; } = [];
    public List<EveUtilisationRessource> EveUtilisationRessources { get; set; } = [];
}

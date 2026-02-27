namespace CasaEcologie.Domain.Entities;

public class EveUtilisationRessource
{
    public int CodeUtilisationRessources { get; set; }
    public int CodeEmployeRespProduction { get; set; }
    public int CodeEmployeRespStockMatierePremiere { get; set; }

    public AgeEmploye AgeEmployeRespProduction { get; set; } = null!;
    public AgeEmploye AgeEmployeRespStock { get; set; } = null!;
    public List<EveProduction> EveProductions { get; set; } = [];
    public List<EveUtilisationMatieresPremiere> EveUtilisationMatieresPremieres { get; set; } = [];
    public List<EveUtilisationProduitsSemiFini> EveUtilisationProduitsSemiFinis { get; set; } = [];
    public List<ResEquipementsInfrastructure> ResEquipementsInfrastructures { get; set; } = [];
    public List<EvePresenceEmploye> EvePresenceEmployes { get; set; } = [];
}

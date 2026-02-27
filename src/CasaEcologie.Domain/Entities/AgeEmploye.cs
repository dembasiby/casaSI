namespace CasaEcologie.Domain.Entities;

public class AgeEmploye
{
    public int CodeEmploye { get; set; }
    public string PrenomNom { get; set; } = null!;
    public string Poste { get; set; } = null!;
    public bool Actif { get; set; }

    public List<EveAcquisitionServicesFourniture> EveAcquisitionServicesFournitures { get; set; } = [];
    public List<EveDecaissement> EveDecaissements { get; set; } = [];
    public List<EveEncaissement> EveEncaissements { get; set; } = [];
    public List<EvePresenceEmploye> EvePresenceEmployes { get; set; } = [];
    public List<EveProduction> EveProductions { get; set; } = [];
    public List<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; } = [];
    public List<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; } = [];
    public List<EveUtilisationRessource> EveUtilisationRessourcesProduction { get; set; } = [];
    public List<EveUtilisationRessource> EveUtilisationRessourcesStock { get; set; } = [];
    public List<EveVente> EveVentes { get; set; } = [];
    public List<EvePaiementEmploye> EvePaiementEmployes { get; set; } = [];
    public List<EveReceptionDonsMatieresPremiere> EveReceptionDonsMatieresPremieres { get; set; } = [];
    public List<EveSortieDechetsMatieresPremiere> EveSortieDechetsMatieresPremiereResponsableStock { get; set; } = [];
    public List<EveSortieDechetsMatieresPremiere> EveSortieDechetsMatieresPremiereAutreResponsable { get; set; } = [];
    public List<EveSortieDonsOuDechetsProduitsFini> EveSortieDonsOuDechetsProduitsFinis { get; set; } = [];
    public Utilisateur? Utilisateur { get; set; }
}

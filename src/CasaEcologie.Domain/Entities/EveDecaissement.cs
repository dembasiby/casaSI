namespace CasaEcologie.Domain.Entities;

public class EveDecaissement
{
    public int CodeDecaissement { get; set; }
    public int? CodeFournisseurMatierePremiere { get; set; }
    public int? CodeFournisseurService { get; set; }
    public int? CodeAutreFournisseur { get; set; }
    public int CodeEmploye { get; set; }
    public int? CodeAcquisitionServiceFourniture { get; set; }
    public int? CodeReceptionEquipementInfrastructure { get; set; }
    public int? CodeReceptionMatierePremiere { get; set; }
    public int? CodeReceptionDonMatierePremiere { get; set; }
    public int? CodePaiementEmploye { get; set; }
    public int CodeCompte { get; set; }
    public string? Description { get; set; }
    public DateTime DateDecaissement { get; set; }
    public decimal Montant { get; set; }
    public bool DecaissementInterne { get; set; }

    public AgeAutreFournisseur? AgeAutreFournisseur { get; set; }
    public AgeEmploye AgeEmploye { get; set; } = null!;
    public AgeFournisseursMatieresPremiere? AgeFournisseursMatieresPremiere { get; set; }
    public AgeFournisseursServicesFourniture? AgeFournisseursServicesFourniture { get; set; }
    public EveAcquisitionServicesFourniture? EveAcquisitionServicesFourniture { get; set; }
    public EveReceptionEquipementsInfrastructure? EveReceptionEquipementsInfrastructure { get; set; }
    public EveReceptionMatieresPremiere? EveReceptionMatieresPremiere { get; set; }
    public ResComptesTresorerie ResComptesTresorerie { get; set; } = null!;
    public EvePaiementEmploye? EvePaiementEmploye { get; set; }
    public EveReceptionDonsMatieresPremiere? EveReceptionDonsMatieresPremiere { get; set; }
}

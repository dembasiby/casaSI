using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.Data;

public class CasaDbContext : DbContext
{
    public CasaDbContext(DbContextOptions<CasaDbContext> options) : base(options) { }

    // Agents
    public DbSet<AgeAutreFournisseur> AgeAutreFournisseurs { get; set; }
    public DbSet<AgeClient> AgeClients { get; set; }
    public DbSet<AgeEmploye> AgeEmployes { get; set; }
    public DbSet<AgeFournisseursMatieresPremiere> AgeFournisseursMatieresPremieres { get; set; }
    public DbSet<AgeFournisseursServicesFourniture> AgeFournisseursServicesFournitures { get; set; }

    // Événements
    public DbSet<EveAcquisitionServicesFourniture> EveAcquisitionServicesFournitures { get; set; }
    public DbSet<EveDecaissement> EveDecaissements { get; set; }
    public DbSet<EveEncaissement> EveEncaissements { get; set; }
    public DbSet<EveEncaissementsAutre> EveEncaissementsAutres { get; set; }
    public DbSet<EveEncaissementsCreance> EveEncaissementsCreances { get; set; }
    public DbSet<EveEncaissementsVente> EveEncaissementsVentes { get; set; }
    public DbSet<EvePaiementEmploye> EvePaiementEmployes { get; set; }
    public DbSet<EvePresenceEmploye> EvePresenceEmployes { get; set; }
    public DbSet<EveProduction> EveProductions { get; set; }
    public DbSet<EveProductionProduitsSemiFini> EveProductionProduitsSemiFinis { get; set; }
    public DbSet<EveProductionStockProduitsFini> EveProductionStockProduitsFinis { get; set; }
    public DbSet<EveReceptionDonsMatieresPremiere> EveReceptionDonsMatieresPremieres { get; set; }
    public DbSet<EveReceptionEquipementsInfrastructure> EveReceptionEquipementsInfrastructures { get; set; }
    public DbSet<EveReceptionMatieresPremiere> EveReceptionMatieresPremieres { get; set; }
    public DbSet<EveSortieDechetsMatieresPremiere> EveSortieDechetsMatieresPremieres { get; set; }
    public DbSet<EveSortieDonsOuDechetsProduitsFini> EveSortieDonsOuDechetsProduitsFinis { get; set; }
    public DbSet<EveTransvasement> EveTransvasements { get; set; }
    public DbSet<EveUtilisationMatieresPremiere> EveUtilisationMatieresPremieres { get; set; }
    public DbSet<EveUtilisationProduitsSemiFini> EveUtilisationProduitsSemiFinis { get; set; }
    public DbSet<EveUtilisationRessource> EveUtilisationRessources { get; set; }
    public DbSet<EveVente> EveVentes { get; set; }
    public DbSet<EveVenteStockProduitsFini> EveVenteStockProduitsFinis { get; set; }

    // Ressources
    public DbSet<ResComptesTresorerie> ResComptesTresoreries { get; set; }
    public DbSet<ResEquipementsInfrastructure> ResEquipementsInfrastructures { get; set; }
    public DbSet<ResServicesFourniture> ResServicesFournitures { get; set; }
    public DbSet<ResStockMatieresPremiere> ResStockMatieresPremieres { get; set; }
    public DbSet<ResStockProduitsFini> ResStockProduitsFinis { get; set; }
    public DbSet<ResStockProduitsSemiFini> ResStockProduitsSemiFinis { get; set; }

    // Autres
    public DbSet<TypesMatiere> TypesMatieres { get; set; }
    public DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CasaDbContext).Assembly);
    }
}

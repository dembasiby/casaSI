using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveUtilisationRessourceConfiguration : IEntityTypeConfiguration<EveUtilisationRessource>
{
    public void Configure(EntityTypeBuilder<EveUtilisationRessource> builder)
    {
        builder.ToTable("EveUtilisationRessources");
        builder.HasKey(e => e.CodeUtilisationRessources);
        builder.Property(e => e.CodeUtilisationRessources).ValueGeneratedOnAdd();
        builder.Property(e => e.CodeEmployeRespProduction)
            .HasColumnName("CodeEmploye(Resp production)");
        builder.Property(e => e.CodeEmployeRespStockMatierePremiere)
            .HasColumnName("CodeEmploye(Resp stock matiere premiere)");

        builder.HasOne(e => e.AgeEmployeRespProduction)
            .WithMany()
            .HasForeignKey(e => e.CodeEmployeRespProduction)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeEmployeRespStock)
            .WithMany()
            .HasForeignKey(e => e.CodeEmployeRespStockMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.ResEquipementsInfrastructures)
            .WithMany(eq => eq.EveUtilisationRessources)
            .UsingEntity("EveUtilisationEquipementInfrastructures",
                l => l.HasOne(typeof(ResEquipementsInfrastructure)).WithMany()
                    .HasForeignKey("CodeEquipementInfrastructure"),
                r => r.HasOne(typeof(EveUtilisationRessource)).WithMany()
                    .HasForeignKey("CodeUtilisationRessource"),
                j =>
                {
                    j.ToTable("EveUtilisationEquipementInfrastructures");
                    j.HasKey("CodeUtilisationRessource", "CodeEquipementInfrastructure");
                });
    }
}

public class EveUtilisationMatieresPremiereConfiguration : IEntityTypeConfiguration<EveUtilisationMatieresPremiere>
{
    public void Configure(EntityTypeBuilder<EveUtilisationMatieresPremiere> builder)
    {
        builder.ToTable("EveUtilisationMatieresPremieres");
        builder.HasKey(e => new { e.CodeUtilisationRessource, e.CodeMatierePremiere });

        builder.HasOne(e => e.EveUtilisationRessource)
            .WithMany(u => u.EveUtilisationMatieresPremieres)
            .HasForeignKey(e => e.CodeUtilisationRessource)
            .HasPrincipalKey(u => u.CodeUtilisationRessources)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockMatieresPremiere)
            .WithMany(m => m.EveUtilisationMatieresPremieres)
            .HasForeignKey(e => e.CodeMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveUtilisationProduitsSemiFiniConfiguration : IEntityTypeConfiguration<EveUtilisationProduitsSemiFini>
{
    public void Configure(EntityTypeBuilder<EveUtilisationProduitsSemiFini> builder)
    {
        builder.ToTable("EveUtilisationProduitsSemiFinis");
        builder.HasKey(e => new { e.CodeUtilisationRessource, e.CodeProduitSemiFini });

        builder.HasOne(e => e.EveUtilisationRessource)
            .WithMany(u => u.EveUtilisationProduitsSemiFinis)
            .HasForeignKey(e => e.CodeUtilisationRessource)
            .HasPrincipalKey(u => u.CodeUtilisationRessources)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsSemiFini)
            .WithMany(s => s.EveUtilisationProduitsSemiFinis)
            .HasForeignKey(e => e.CodeProduitSemiFini)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

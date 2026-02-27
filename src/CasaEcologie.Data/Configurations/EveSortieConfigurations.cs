using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveSortieDechetsMatieresPremiereConfiguration : IEntityTypeConfiguration<EveSortieDechetsMatieresPremiere>
{
    public void Configure(EntityTypeBuilder<EveSortieDechetsMatieresPremiere> builder)
    {
        builder.ToTable("EveSortieDechetsMatieresPremieres");
        builder.HasKey(e => e.CodeSortieDechet);
        builder.Property(e => e.CodeSortieDechet).ValueGeneratedOnAdd();
        builder.Property(e => e.Description).HasMaxLength(250).IsRequired();
        builder.Property(e => e.CodeEmployeResponsableStock)
            .HasColumnName("CodeEmploye(responsable stock)");
        builder.Property(e => e.CodeEmployeAutreResponsable)
            .HasColumnName("CodeEmploye(autre responsable)");

        builder.HasOne(e => e.AgeEmployeResponsableStock)
            .WithMany()
            .HasForeignKey(e => e.CodeEmployeResponsableStock)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeEmployeAutreResponsable)
            .WithMany()
            .HasForeignKey(e => e.CodeEmployeAutreResponsable)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockMatieresPremiere)
            .WithMany(m => m.EveSortieDechetsMatieresPremieres)
            .HasForeignKey(e => e.CodeMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveSortieDonsOuDechetsProduitsFiniConfiguration : IEntityTypeConfiguration<EveSortieDonsOuDechetsProduitsFini>
{
    public void Configure(EntityTypeBuilder<EveSortieDonsOuDechetsProduitsFini> builder)
    {
        builder.ToTable("EveSortieDonsOuDechetsProduitsFinis");
        builder.HasKey(e => e.CodeSortieDonsDechetsPrdtFini);
        builder.Property(e => e.CodeSortieDonsDechetsPrdtFini).ValueGeneratedOnAdd();
        builder.Property(e => e.Description).HasMaxLength(250).IsRequired();

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeResponsableSortie)
            .HasPrincipalKey(emp => emp.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsFini)
            .WithMany(p => p.EveSortieDonsOuDechetsProduitsFinis)
            .HasForeignKey(e => e.CodeProduitFini)
            .HasPrincipalKey(p => p.CodeProduit)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

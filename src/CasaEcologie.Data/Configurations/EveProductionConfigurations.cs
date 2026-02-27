using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveProductionConfiguration : IEntityTypeConfiguration<EveProduction>
{
    public void Configure(EntityTypeBuilder<EveProduction> builder)
    {
        builder.ToTable("EveProductions");
        builder.HasKey(e => e.CodeProduction);
        builder.Property(e => e.CodeProduction).ValueGeneratedOnAdd();
        builder.Property(e => e.CodeEmployeRespStockProduitsFinis)
            .HasColumnName("CodeEmploye(Resp stock produits finis");

        builder.HasOne(e => e.EveUtilisationRessource)
            .WithMany(u => u.EveProductions)
            .HasForeignKey(e => e.CodeUtilisationRessources)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmployeRespStockProduitsFinis)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveProductionProduitsSemiFiniConfiguration : IEntityTypeConfiguration<EveProductionProduitsSemiFini>
{
    public void Configure(EntityTypeBuilder<EveProductionProduitsSemiFini> builder)
    {
        builder.ToTable("EveProductionProduitsSemiFinis");
        builder.HasKey(e => new { e.CodeProduction, e.CodeProduitSemiFini });

        builder.HasOne(e => e.EveProduction)
            .WithMany(p => p.EveProductionProduitsSemiFinis)
            .HasForeignKey(e => e.CodeProduction)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsSemiFini)
            .WithMany(s => s.EveProductionProduitsSemiFinis)
            .HasForeignKey(e => e.CodeProduitSemiFini)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveProductionStockProduitsFiniConfiguration : IEntityTypeConfiguration<EveProductionStockProduitsFini>
{
    public void Configure(EntityTypeBuilder<EveProductionStockProduitsFini> builder)
    {
        builder.ToTable("EveProductionStockProduitsFinis");
        builder.HasKey(e => new { e.CodeProduction, e.CodeProduitFini });

        builder.HasOne(e => e.EveProduction)
            .WithMany(p => p.EveProductionStockProduitsFinis)
            .HasForeignKey(e => e.CodeProduction)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsFini)
            .WithMany(p => p.EveProductionStockProduitsFinis)
            .HasForeignKey(e => e.CodeProduitFini)
            .HasPrincipalKey(p => p.CodeProduit)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

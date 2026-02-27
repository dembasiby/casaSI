using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveVenteConfiguration : IEntityTypeConfiguration<EveVente>
{
    public void Configure(EntityTypeBuilder<EveVente> builder)
    {
        builder.ToTable("EveVentes");
        builder.HasKey(e => e.CodeVente);
        builder.Property(e => e.CodeVente).ValueGeneratedOnAdd();

        builder.HasOne(e => e.AgeClient)
            .WithMany(c => c.EveVentes)
            .HasForeignKey(e => e.CodeClient)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveVenteStockProduitsFiniConfiguration : IEntityTypeConfiguration<EveVenteStockProduitsFini>
{
    public void Configure(EntityTypeBuilder<EveVenteStockProduitsFini> builder)
    {
        builder.ToTable("EveVenteStockProduitsFinis");
        builder.HasKey(e => new { e.CodeVente, e.CodeProduitFini });
        builder.Property(e => e.Montant).HasColumnType("money");

        builder.HasOne(e => e.EveVente)
            .WithMany(v => v.EveVenteStockProduitsFinis)
            .HasForeignKey(e => e.CodeVente)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsFini)
            .WithMany(p => p.EveVenteStockProduitsFinis)
            .HasForeignKey(e => e.CodeProduitFini)
            .HasPrincipalKey(p => p.CodeProduit)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

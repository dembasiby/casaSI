using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveTransvasementConfiguration : IEntityTypeConfiguration<EveTransvasement>
{
    public void Configure(EntityTypeBuilder<EveTransvasement> builder)
    {
        builder.ToTable("EveTransvasements");
        builder.HasKey(e => e.CodeTransvasage);
        builder.Property(e => e.CodeTransvasage).ValueGeneratedOnAdd();

        builder.HasOne(e => e.ResStockMatieresPremiereInitial)
            .WithMany(m => m.EveTransvasementsInitial)
            .HasForeignKey(e => e.CodeEmballageInitial)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockMatieresPremiereFinal)
            .WithMany(m => m.EveTransvasementsFinal)
            .HasForeignKey(e => e.CodeEmballageFinal)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsFiniInitial)
            .WithMany(p => p.EveTransvasementsInitial)
            .HasForeignKey(e => e.CodeProduitInitial)
            .HasPrincipalKey(p => p.CodeProduit)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockProduitsFinisFinal)
            .WithMany(p => p.EveTransvasementsFinal)
            .HasForeignKey(e => e.CodeProduitFinal)
            .HasPrincipalKey(p => p.CodeProduit)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

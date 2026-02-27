using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class ResStockMatieresPremiereConfiguration : IEntityTypeConfiguration<ResStockMatieresPremiere>
{
    public void Configure(EntityTypeBuilder<ResStockMatieresPremiere> builder)
    {
        builder.ToTable("ResStockMatieresPremieres");
        builder.HasKey(e => e.CodeMatierePremiere);
        builder.Property(e => e.CodeMatierePremiere).ValueGeneratedOnAdd();
        builder.Property(e => e.NomMatiere).HasMaxLength(100).IsRequired();
        builder.Property(e => e.CoutUnitaire).HasColumnType("money");

        builder.HasOne(e => e.TypesMatiere)
            .WithMany(t => t.ResStockMatieresPremieres)
            .HasForeignKey(e => e.CodeTypeMatiere)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class ResStockProduitsFiniConfiguration : IEntityTypeConfiguration<ResStockProduitsFini>
{
    public void Configure(EntityTypeBuilder<ResStockProduitsFini> builder)
    {
        builder.ToTable("ResStockProduitsFinis");
        builder.HasKey(e => e.CodeProduit);
        builder.Property(e => e.CodeProduit).ValueGeneratedOnAdd();
        builder.Property(e => e.NomProduit).HasMaxLength(100).IsRequired();

        builder.HasOne(e => e.ResStockMatieresPremiere)
            .WithMany()
            .HasForeignKey(e => e.CodeEmballage)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class ResStockProduitsSemiFiniConfiguration : IEntityTypeConfiguration<ResStockProduitsSemiFini>
{
    public void Configure(EntityTypeBuilder<ResStockProduitsSemiFini> builder)
    {
        builder.ToTable("ResStockProduitsSemiFinis");
        builder.HasKey(e => e.CodeProduitSemiFini);
        builder.Property(e => e.CodeProduitSemiFini).ValueGeneratedOnAdd();
        builder.Property(e => e.Description).HasMaxLength(250).IsRequired();

        builder.HasOne(e => e.ResStockMatieresPremiere)
            .WithMany(m => m.ResStockProduitsSemiFinis)
            .HasForeignKey(e => e.CodeMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class ResComptesTresorerieConfiguration : IEntityTypeConfiguration<ResComptesTresorerie>
{
    public void Configure(EntityTypeBuilder<ResComptesTresorerie> builder)
    {
        builder.ToTable("ResComptesTresorerie");
        builder.HasKey(e => e.CodeCompte);
        builder.Property(e => e.CodeCompte).ValueGeneratedOnAdd();
        builder.Property(e => e.NomCompte).HasMaxLength(50).IsRequired();
        builder.Property(e => e.SoldeCompte).HasColumnType("money");
    }
}

public class ResEquipementsInfrastructureConfiguration : IEntityTypeConfiguration<ResEquipementsInfrastructure>
{
    public void Configure(EntityTypeBuilder<ResEquipementsInfrastructure> builder)
    {
        builder.ToTable("ResEquipementsInfrastructures");
        builder.HasKey(e => e.CodeEquipementInfrastructure);
        builder.Property(e => e.CodeEquipementInfrastructure).ValueGeneratedOnAdd();
        builder.Property(e => e.Nom).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Montant).HasColumnType("money");
    }
}

public class ResServicesFournitureConfiguration : IEntityTypeConfiguration<ResServicesFourniture>
{
    public void Configure(EntityTypeBuilder<ResServicesFourniture> builder)
    {
        builder.ToTable("ResServicesFournitures");
        builder.HasKey(e => e.CodeServiceFourniture);
        builder.Property(e => e.CodeServiceFourniture).ValueGeneratedOnAdd();
        builder.Property(e => e.NomServiceFourniture).HasMaxLength(100).IsRequired();
    }
}

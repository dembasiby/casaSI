using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class AgeClientConfiguration : IEntityTypeConfiguration<AgeClient>
{
    public void Configure(EntityTypeBuilder<AgeClient> builder)
    {
        builder.ToTable("AgeClients");
        builder.HasKey(e => e.CodeClient);
        builder.Property(e => e.CodeClient).ValueGeneratedOnAdd();
        builder.Property(e => e.NomClient).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Localite).HasMaxLength(50).IsRequired();
        builder.Property(e => e.SoldeInitialeCreance).HasColumnType("money").IsRequired();
    }
}

public class AgeEmployeConfiguration : IEntityTypeConfiguration<AgeEmploye>
{
    public void Configure(EntityTypeBuilder<AgeEmploye> builder)
    {
        builder.ToTable("AgeEmployes");
        builder.HasKey(e => e.CodeEmploye);
        builder.Property(e => e.CodeEmploye).ValueGeneratedOnAdd();
        builder.Property(e => e.PrenomNom).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Poste).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Actif).IsRequired();
    }
}

public class AgeFournisseursMatierePremiereConfiguration : IEntityTypeConfiguration<AgeFournisseursMatieresPremiere>
{
    public void Configure(EntityTypeBuilder<AgeFournisseursMatieresPremiere> builder)
    {
        builder.ToTable("AgeFournisseursMatieresPremieres");
        builder.HasKey(e => e.CodeFournisseurMatierePremiere);
        builder.Property(e => e.CodeFournisseurMatierePremiere).ValueGeneratedOnAdd();
        builder.Property(e => e.Nom).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Localite).HasMaxLength(50).IsRequired();
        builder.Property(e => e.SoldeDette).HasColumnType("money").IsRequired();
    }
}

public class AgeFournisseursServicesFournitureConfiguration : IEntityTypeConfiguration<AgeFournisseursServicesFourniture>
{
    public void Configure(EntityTypeBuilder<AgeFournisseursServicesFourniture> builder)
    {
        builder.ToTable("AgeFournisseursServicesFournitures");
        builder.HasKey(e => e.CodeFournisseurServiceFourniture);
        builder.Property(e => e.CodeFournisseurServiceFourniture).ValueGeneratedOnAdd();
        builder.Property(e => e.NomFournisseurServiceFourniture).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Localite).HasMaxLength(50).IsRequired();
        builder.Property(e => e.SoldeDette).HasColumnType("money").IsRequired();
    }
}

public class AgeAutreFournisseurConfiguration : IEntityTypeConfiguration<AgeAutreFournisseur>
{
    public void Configure(EntityTypeBuilder<AgeAutreFournisseur> builder)
    {
        builder.ToTable("AgeAutreFournisseurs");
        builder.HasKey(e => e.CodeAutreFournisseur);
        builder.Property(e => e.CodeAutreFournisseur).ValueGeneratedOnAdd();
        builder.Property(e => e.NomAutreFournisseur).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Localite).HasMaxLength(50);
        builder.Property(e => e.SoldeInitialDetteFournisseur).HasColumnType("money").IsRequired();
    }
}

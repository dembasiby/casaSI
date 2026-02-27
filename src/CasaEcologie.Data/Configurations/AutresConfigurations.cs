using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class TypesMatiereConfiguration : IEntityTypeConfiguration<TypesMatiere>
{
    public void Configure(EntityTypeBuilder<TypesMatiere> builder)
    {
        builder.ToTable("TypesMatieres");
        builder.HasKey(e => e.CodeTypeMatiere);
        builder.Property(e => e.CodeTypeMatiere).ValueGeneratedOnAdd();
        builder.Property(e => e.NomType).HasMaxLength(50).IsRequired();
    }
}

public class UtilisateurConfiguration : IEntityTypeConfiguration<Utilisateur>
{
    public void Configure(EntityTypeBuilder<Utilisateur> builder)
    {
        builder.ToTable("Utilisateurs");
        builder.HasKey(e => e.CodeEmploye);
        builder.Property(e => e.NomUtilisateur).HasMaxLength(50).IsRequired();
        builder.Property(e => e.MotDePasse).HasMaxLength(250).IsRequired();
        builder.Property(e => e.Role).HasMaxLength(50).IsRequired();

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

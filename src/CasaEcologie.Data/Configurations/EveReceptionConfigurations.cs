using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveReceptionMatieresPremiereConfiguration : IEntityTypeConfiguration<EveReceptionMatieresPremiere>
{
    public void Configure(EntityTypeBuilder<EveReceptionMatieresPremiere> builder)
    {
        builder.ToTable("EveReceptionMatieresPremieres");
        builder.HasKey(e => e.CodeReceptionMatierePremiere);
        builder.Property(e => e.CodeReceptionMatierePremiere).ValueGeneratedOnAdd();
        builder.Property(e => e.Montant).HasColumnType("money");
        builder.Property(e => e.TransportMatierePremiere).HasColumnType("money");

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeFournisseursMatieresPremiere)
            .WithMany()
            .HasForeignKey(e => e.CodeFournisseurMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockMatieresPremiere)
            .WithMany(m => m.EveReceptionMatieresPremieres)
            .HasForeignKey(e => e.CodeMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveReceptionDonsMatieresPremiereConfiguration : IEntityTypeConfiguration<EveReceptionDonsMatieresPremiere>
{
    public void Configure(EntityTypeBuilder<EveReceptionDonsMatieresPremiere> builder)
    {
        builder.ToTable("EveReceptionDonsMatieresPremieres");
        builder.HasKey(e => e.CodeReceptionDonMatierePremiere);
        builder.Property(e => e.CodeReceptionDonMatierePremiere).ValueGeneratedOnAdd();

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeFournisseursMatieresPremiere)
            .WithMany()
            .HasForeignKey(e => e.CodeFournisseur)
            .HasPrincipalKey(f => f.CodeFournisseurMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResStockMatieresPremiere)
            .WithMany(m => m.EveReceptionDonsMatieresPremieres)
            .HasForeignKey(e => e.CodeMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveReceptionEquipementsInfrastructureConfiguration : IEntityTypeConfiguration<EveReceptionEquipementsInfrastructure>
{
    public void Configure(EntityTypeBuilder<EveReceptionEquipementsInfrastructure> builder)
    {
        builder.ToTable("EveReceptionEquipementsInfrastructures");
        builder.HasKey(e => e.CodeReceptionEquipementInfrastructure);
        builder.Property(e => e.CodeReceptionEquipementInfrastructure).ValueGeneratedOnAdd();

        builder.HasOne(e => e.AgeAutreFournisseur)
            .WithMany()
            .HasForeignKey(e => e.CodeAutreFournisseur)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResEquipementsInfrastructure)
            .WithMany(eq => eq.EveReceptionEquipementsInfrastructures)
            .HasForeignKey(e => e.CodeEquipementInfrastructure)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

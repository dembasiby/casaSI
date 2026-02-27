using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EvePaiementEmployeConfiguration : IEntityTypeConfiguration<EvePaiementEmploye>
{
    public void Configure(EntityTypeBuilder<EvePaiementEmploye> builder)
    {
        builder.ToTable("EvePaiementEmployes");
        builder.HasKey(e => e.CodePaiementEmploye);
        builder.Property(e => e.CodePaiementEmploye).ValueGeneratedOnAdd();

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmployePaye)
            .HasPrincipalKey(emp => emp.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EvePresenceEmployeConfiguration : IEntityTypeConfiguration<EvePresenceEmploye>
{
    public void Configure(EntityTypeBuilder<EvePresenceEmploye> builder)
    {
        builder.ToTable("EvePresenceEmployes");
        builder.HasKey(e => e.CodePresence);
        builder.Property(e => e.CodePresence).ValueGeneratedOnAdd();

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveUtilisationRessource)
            .WithMany(u => u.EvePresenceEmployes)
            .HasForeignKey(e => e.CodeUtilisationDesRessources)
            .HasPrincipalKey(u => u.CodeUtilisationRessources)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

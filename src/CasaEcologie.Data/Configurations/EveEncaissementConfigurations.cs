using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveEncaissementConfiguration : IEntityTypeConfiguration<EveEncaissement>
{
    public void Configure(EntityTypeBuilder<EveEncaissement> builder)
    {
        builder.ToTable("EveEncaissements");
        builder.HasKey(e => e.CodeEncaissement);
        builder.Property(e => e.CodeEncaissement).ValueGeneratedOnAdd();

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResComptesTresorerie)
            .WithMany(c => c.EveEncaissements)
            .HasForeignKey(e => e.CodeCompte)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveEncaissementsVenteConfiguration : IEntityTypeConfiguration<EveEncaissementsVente>
{
    public void Configure(EntityTypeBuilder<EveEncaissementsVente> builder)
    {
        builder.ToTable("EveEncaissementsVentes");
        builder.HasKey(e => new { e.CodeEncaissement, e.CodeVente });
        builder.Property(e => e.MontantEncaisse).HasColumnType("money");

        builder.HasOne(e => e.EveEncaissement)
            .WithMany(enc => enc.EveEncaissementsVentes)
            .HasForeignKey(e => e.CodeEncaissement)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveVente)
            .WithMany(v => v.EveEncaissementsVentes)
            .HasForeignKey(e => e.CodeVente)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeClient)
            .WithMany()
            .HasForeignKey(e => e.CodeClient)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveEncaissementsCreanceConfiguration : IEntityTypeConfiguration<EveEncaissementsCreance>
{
    public void Configure(EntityTypeBuilder<EveEncaissementsCreance> builder)
    {
        builder.ToTable("EveEncaissementsCreances");
        builder.HasKey(e => e.CodeEncaissementCreance);
        builder.Property(e => e.CodeEncaissementCreance).ValueGeneratedOnAdd();
        builder.Property(e => e.MontantEncaisse).HasColumnType("money");

        builder.HasOne(e => e.AgeClient)
            .WithMany()
            .HasForeignKey(e => e.CodeClient)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveEncaissement)
            .WithMany(enc => enc.EveEncaissementsCreances)
            .HasForeignKey(e => e.CodeEncaissement)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public class EveEncaissementsAutreConfiguration : IEntityTypeConfiguration<EveEncaissementsAutre>
{
    public void Configure(EntityTypeBuilder<EveEncaissementsAutre> builder)
    {
        builder.ToTable("EveEncaissementsAutres");
        builder.HasKey(e => e.CodeEncaissementAutre);
        builder.Property(e => e.CodeEncaissementAutre).ValueGeneratedOnAdd();
        builder.Property(e => e.MontantEncaisse).HasColumnType("money");
        builder.Property(e => e.Description).HasMaxLength(250).IsRequired();

        builder.HasOne(e => e.EveEncaissement)
            .WithMany(enc => enc.EveEncaissementsAutres)
            .HasForeignKey(e => e.CodeEncaissement)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

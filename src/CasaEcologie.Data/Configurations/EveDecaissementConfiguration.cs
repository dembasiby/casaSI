using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveDecaissementConfiguration : IEntityTypeConfiguration<EveDecaissement>
{
    public void Configure(EntityTypeBuilder<EveDecaissement> builder)
    {
        builder.ToTable("EveDecaissements");
        builder.HasKey(e => e.CodeDecaissement);
        builder.Property(e => e.CodeDecaissement).ValueGeneratedOnAdd();
        builder.Property(e => e.Montant).HasColumnType("money");
        builder.Property(e => e.Description).HasMaxLength(250);

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeAutreFournisseur)
            .WithMany()
            .HasForeignKey(e => e.CodeAutreFournisseur)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeFournisseursMatieresPremiere)
            .WithMany()
            .HasForeignKey(e => e.CodeFournisseurMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeFournisseursServicesFourniture)
            .WithMany()
            .HasForeignKey(e => e.CodeFournisseurService)
            .HasPrincipalKey(f => f.CodeFournisseurServiceFourniture)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveAcquisitionServicesFourniture)
            .WithMany(a => a.EveDecaissements)
            .HasForeignKey(e => e.CodeAcquisitionServiceFourniture)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveReceptionEquipementsInfrastructure)
            .WithMany(r => r.EveDecaissements)
            .HasForeignKey(e => e.CodeReceptionEquipementInfrastructure)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveReceptionMatieresPremiere)
            .WithMany(r => r.EveDecaissements)
            .HasForeignKey(e => e.CodeReceptionMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EveReceptionDonsMatieresPremiere)
            .WithMany(r => r.EveDecaissements)
            .HasForeignKey(e => e.CodeReceptionDonMatierePremiere)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.EvePaiementEmploye)
            .WithMany(p => p.EveDecaissements)
            .HasForeignKey(e => e.CodePaiementEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResComptesTresorerie)
            .WithMany(c => c.EveDecaissements)
            .HasForeignKey(e => e.CodeCompte)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

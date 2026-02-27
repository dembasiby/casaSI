using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaEcologie.Data.Configurations;

public class EveAcquisitionServicesFournitureConfiguration : IEntityTypeConfiguration<EveAcquisitionServicesFourniture>
{
    public void Configure(EntityTypeBuilder<EveAcquisitionServicesFourniture> builder)
    {
        builder.ToTable("EveAcquisitionServicesFournitures");
        builder.HasKey(e => e.CodeAcquisitionServiceFourniture);
        builder.Property(e => e.CodeAcquisitionServiceFourniture).ValueGeneratedOnAdd();
        builder.Property(e => e.Montant).HasColumnType("money");
        builder.Property(e => e.TransportServiceFourniture).HasColumnType("money");
        builder.Property(e => e.Description).HasMaxLength(250);

        builder.HasOne(e => e.AgeEmploye)
            .WithMany()
            .HasForeignKey(e => e.CodeEmploye)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.AgeFournisseursServicesFourniture)
            .WithMany()
            .HasForeignKey(e => e.CodeFournisseurServiceFourniture)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ResServicesFourniture)
            .WithMany(s => s.EveAcquisitionServicesFournitures)
            .HasForeignKey(e => e.CodeServiceFourniture)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

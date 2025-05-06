using Blackboard.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blackboard.Data.Migrations.EntityConfigurations;

public class LoadConfiguration: IEntityTypeConfiguration<Load>
{
    public void Configure(EntityTypeBuilder<Load> builder)
    {
        builder
            .ToTable("Loads")
            .HasKey(k => k.Id);

        builder.HasIndex(i => i.Key);
        builder.HasIndex(i => i.DocumentNumber);
        builder.HasIndex(i => i.DocumentType);

        builder.Property(p => p.DocumentNumber).HasMaxLength(50);
        builder.Property(p => p.DocumentType).HasMaxLength(50);
        builder.Property(p => p.Key).HasMaxLength(50);
        builder.Property(p => p.Status).HasMaxLength(50);
        builder.Property(p => p.Channel).HasMaxLength(50);
        builder.Property(p => p.AssociatedVehicleLicensePlate)
            .HasMaxLength(50)
            .IsRequired(false);
        builder.Property(p => p.AssociationStatus)
            .HasMaxLength(50)
            .IsRequired(false);
    }
}
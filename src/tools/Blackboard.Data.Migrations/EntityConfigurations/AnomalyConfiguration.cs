using Blackboard.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blackboard.Data.Migrations.EntityConfigurations;

public class AnomalyConfiguration: IEntityTypeConfiguration<Anomaly>
{
    public void Configure(EntityTypeBuilder<Anomaly> builder)
    {
        builder
            .ToTable("Anomalies")
            .HasKey(k => k.Id);

        builder.HasIndex(i => i.LoadKey);
        builder.HasIndex(i => i.VehicleLicensePlate);

        builder.Property(p => p.AnomalyType)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(p => p.VehicleLicensePlate)
            .IsRequired(false)
            .HasMaxLength(250);
        builder.Property(p => p.LoadKey)
            .IsRequired(false)
            .HasMaxLength(50);
    }
}
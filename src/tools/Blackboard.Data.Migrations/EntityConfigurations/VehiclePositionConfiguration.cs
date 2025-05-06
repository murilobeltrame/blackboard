using Blackboard.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blackboard.Data.Migrations.EntityConfigurations;

public class VehiclePositionConfiguration:IEntityTypeConfiguration<VehiclePosition>
{
    public void Configure(EntityTypeBuilder<VehiclePosition> builder)
    {
        builder
            .ToTable("VehiclePositions")
            .HasKey(k => k.Id);
        
        builder.HasIndex(i => i.LicensePlate);

        builder
            .Property(p => p.LicensePlate)
            .IsRequired()
            .HasMaxLength(250);
        builder
            .Property(p => p.EventName)
            .IsRequired()
            .HasMaxLength(250);
    }
}
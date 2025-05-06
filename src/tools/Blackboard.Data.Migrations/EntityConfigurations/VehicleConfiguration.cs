using Blackboard.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blackboard.Data.Migrations.EntityConfigurations;

public class VehicleConfiguration:IEntityTypeConfiguration<Vehicle>
    
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder
            .ToTable("Vehicles")
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
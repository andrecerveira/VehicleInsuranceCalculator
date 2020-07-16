using VehicleInsuranceCalculator.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace VehicleInsuranceCalculator.Infra.Data.EntityConfig
{
    public class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {
            HasKey(v => v.VehicleId);

            Property(v => v.Brand)
                .IsRequired()
                .HasMaxLength(50);

            Property(v => v.Model)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}

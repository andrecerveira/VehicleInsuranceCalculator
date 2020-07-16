using VehicleInsuranceCalculator.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace VehicleInsuranceCalculator.Infra.Data.EntityConfig
{
    class InsuranceConfiguration : EntityTypeConfiguration<Insurance>
    {
        public InsuranceConfiguration()
        {
            HasKey(i => i.InsuranceId);

            HasRequired(i => i.Assured)
                .WithMany()
                .HasForeignKey(i => i.AssuredId);

            HasRequired(v => v.Vehicle)
                .WithMany()
                .HasForeignKey(v => v.VehicleId);
        }
    }
}

using VehicleInsuranceCalculator.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace VehicleInsuranceCalculator.Infra.Data.EntityConfig
{
    public class AssuredConfiguration : EntityTypeConfiguration<Assured>
    {
        public AssuredConfiguration()
        {
            HasKey(a => a.AssuredId);

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.cpf)
                .IsRequired()
                .HasMaxLength(14);
        }
    }
}

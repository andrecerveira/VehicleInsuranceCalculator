using System.Collections.Generic;

namespace VehicleInsuranceCalculator.Domain.Entities
{
    public class Assured
    {
        public int AssuredId { get; set; }
        public string Name { get; set; }
        public string cpf { get; set; }
        public IEnumerable<Insurance> InsurancePlans { get; set; }
    }
}

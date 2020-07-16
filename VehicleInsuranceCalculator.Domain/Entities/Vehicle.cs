using System.Collections.Generic;

namespace VehicleInsuranceCalculator.Domain.Entities
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public double Value { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public IEnumerable<Insurance> InsurancePlans { get; set; }
    }
}

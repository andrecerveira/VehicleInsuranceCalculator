using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Repositories;

namespace VehicleInsuranceCalculator.Infra.Data.Repositories
{
    public class InsuranceRepository : RepositoryBase<Insurance>, IInsuranceRepository
    {
        public Insurance CalculateInsurance(double vehicleValue)
        {
            throw new System.NotImplementedException();
        }
    }
}

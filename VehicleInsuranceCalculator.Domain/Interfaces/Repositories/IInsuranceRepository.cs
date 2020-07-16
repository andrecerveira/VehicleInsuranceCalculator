using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.Domain.Interfaces.Repositories
{
    public interface IInsuranceRepository : IRepositoryBase<Insurance>
    {
        Insurance CalculateInsurance(double vehicleValue);
    }
}

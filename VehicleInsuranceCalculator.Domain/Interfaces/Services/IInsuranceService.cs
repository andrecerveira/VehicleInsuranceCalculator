using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.Domain.Interfaces.Services
{
    public interface IInsuranceService : IServiceBase<Insurance>
    {
        Insurance CalculateInsurance(double vehicleValue);
    }
}

using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.Application.Interface
{
    public interface IInsuranceAppService : IAppServiceBase<Insurance>
    {
        Insurance CalculateInsurance(double vehicleValue);
    }
}

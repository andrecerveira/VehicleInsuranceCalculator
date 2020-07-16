using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Services;

namespace VehicleInsuranceCalculator.Application
{
    public class VehicleAppService : AppServiceBase<Vehicle>, IVehicleAppService
    {
        private readonly IVehicleService _vehicleService;

        public VehicleAppService(IVehicleService vehicleService)
            :base(vehicleService)
        {
            _vehicleService = vehicleService;
        }

        //public IEnumerable<Assured> GetSpecialClients()
        //{
        //    return _assuredService.GetSpecialClients(_assuredService.GetAll());
        //}
    }
}

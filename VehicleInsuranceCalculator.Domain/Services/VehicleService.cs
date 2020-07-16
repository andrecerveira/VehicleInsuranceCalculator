using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Services;
using VehicleInsuranceCalculator.Domain.Interfaces.Repositories;

namespace VehicleInsuranceCalculator.Domain.Services
{
    public class VehicleService : ServiceBase<Vehicle>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
            : base(vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        //public IEnumerable<Assured> GetSpecialClients(IEnumerable<Assured> clients)
        //{
        //    return clients.Where(c => c.SpecialClient(c));
        //}
    }
}

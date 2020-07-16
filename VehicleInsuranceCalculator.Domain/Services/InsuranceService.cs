using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Services;
using VehicleInsuranceCalculator.Domain.Interfaces.Repositories;

namespace VehicleInsuranceCalculator.Domain.Services
{
    public class InsuranceService : ServiceBase<Insurance>, IInsuranceService
    {
        private readonly IInsuranceRepository _insuranceRepository;

        public InsuranceService(IInsuranceRepository insuranceRepository)
            :base(insuranceRepository)
        {
            _insuranceRepository = insuranceRepository;
        }

        public Insurance CalculateInsurance(double vehicleValue)
        {
            return _insuranceRepository.CalculateInsurance(vehicleValue);
        }

        //public IEnumerable<Insurance> SearchForName(string name)
        //{
        //    return _insuranceRepository.SearchForName(name);
        //}
    }
}

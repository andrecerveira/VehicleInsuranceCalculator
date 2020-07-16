using System.Collections.Generic;
using VehicleInsuranceCalculator.Application.Interface;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Services;

namespace VehicleInsuranceCalculator.Application
{
    public class AssuredAppService : AppServiceBase<Assured>, IAssuredAppService
    {
        private readonly IAssuredService _assuredService;

        public AssuredAppService(IAssuredService assuredService)
            :base(assuredService)
        {
            _assuredService = assuredService;
        }

        public IEnumerable<Assured> GetMockAssured()
        {
            return _assuredService.GetMockAssured();
        }
    }
}

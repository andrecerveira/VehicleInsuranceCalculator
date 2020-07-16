using System.Collections.Generic;
using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.Application.Interface
{
    public interface IAssuredAppService : IAppServiceBase<Assured>
    {
        IEnumerable<Assured> GetMockAssured();
    }
}

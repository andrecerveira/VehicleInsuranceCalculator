using System.Collections.Generic;
using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.Domain.Interfaces.Services
{
    public interface IAssuredService : IServiceBase<Assured>
    {
        IEnumerable<Assured> GetMockAssured();
    }
}

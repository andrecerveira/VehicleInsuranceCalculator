using System.Collections.Generic;
using VehicleInsuranceCalculator.Domain.Entities;

namespace VehicleInsuranceCalculator.Domain.Interfaces.Repositories
{
    public interface IAssuredRepository : IRepositoryBase<Assured>
    {
        IEnumerable<Assured> GetMockAssured();
    }
}

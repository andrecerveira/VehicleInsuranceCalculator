using System.Collections.Generic;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Services;
using VehicleInsuranceCalculator.Domain.Interfaces.Repositories;

namespace VehicleInsuranceCalculator.Domain.Services
{
    public class AssuredService : ServiceBase<Assured>, IAssuredService
    {
        private readonly IAssuredRepository _assuredRepository;

        public AssuredService(IAssuredRepository assuredRepository)
            : base(assuredRepository)
        {
            _assuredRepository = assuredRepository;
        }

        public IEnumerable<Assured> GetMockAssured()
        {
            return _assuredRepository.GetMockAssured();
        }

        //public IEnumerable<Assured> GetSpecialClients(IEnumerable<Assured> clients)
        //{
        //    return clients.Where(c => c.SpecialClient(c));
        //}
    }
}

using System.Collections.Generic;
using VehicleInsuranceCalculator.Domain.Entities;
using VehicleInsuranceCalculator.Domain.Interfaces.Repositories;

namespace VehicleInsuranceCalculator.Infra.Data.Repositories
{
    public class AssuredRepository : RepositoryBase<Assured>, IAssuredRepository
    {

        public IEnumerable<Assured> GetMockAssured()
        {
            return new List<Assured>()
            {
                new Assured() { AssuredId = 1, Name = "Peter", cpf = "11111111111" },
                new Assured() { AssuredId = 2, Name = "John", cpf = "22222222222" },
                new Assured() { AssuredId = 3, Name = "Mary", cpf = "33333333333" },
                new Assured() { AssuredId = 4, Name = "Robert", cpf = "44444444444" },
                new Assured() { AssuredId = 5, Name = "Donna", cpf = "55555555555" },
            };
        }

    }
}

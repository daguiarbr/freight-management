using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class CarrierRepository : RepositoryBase<Carrier>, ICarrierRepository
    {
        public IEnumerable<Carrier> GetByCompanyName(string companyName)
        {
            throw new System.NotImplementedException();
        }
    }
}

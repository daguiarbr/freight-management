using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRatingRepository : IRepositoryBase<Rating>
    {
        IEnumerable<Rating> GetByFilter(string companyName, int? rate);
    }
}

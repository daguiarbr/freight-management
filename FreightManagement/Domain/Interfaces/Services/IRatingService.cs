using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IRatingService : IServiceBase<Rating>
    {
        IEnumerable<Rating> GetByFilter(string companyName, int rate);
    }
}

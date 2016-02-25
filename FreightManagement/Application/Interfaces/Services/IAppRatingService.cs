using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAppRatingService : IAppServiceBase<Rating>
    {
        IEnumerable<Rating> GetByFilter(string companyName, int? rate);
    }
}

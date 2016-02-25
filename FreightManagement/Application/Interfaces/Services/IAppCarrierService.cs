using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAppCarrierService : IAppServiceBase<Carrier>
    {
        IEnumerable<Carrier> GetByFilter(string companyName, string cnpj);

        IEnumerable<Carrier> GetAllWithoutRating(string userId);
    }
}

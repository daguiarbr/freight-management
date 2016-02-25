using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface ICarrierService : IServiceBase<Carrier>
    {
        IEnumerable<Carrier> GetByFilter(string companyName, string cnpj);
    }
}

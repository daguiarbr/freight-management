using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAppCarrierService : IAppServiceBase<Carrier>
    {
        IEnumerable<Carrier> Search(string companyName, string cnpj);
    }
}

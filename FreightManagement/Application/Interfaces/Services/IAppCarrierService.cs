using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAppCarrierService : IAppServiceBase<Carrier>
    {
        IEnumerable<Carrier> GetByCompanyName(string companyName);
    }
}

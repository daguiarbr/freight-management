using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Application.Services
{
    public class AppCarrierService : AppServiceBase<Carrier>, IAppCarrierService
    {
        private readonly ICarrierService _carrierService;

        public AppCarrierService(ICarrierService carrierService)
            : base(carrierService)
        {
            _carrierService = carrierService;
        }

        public IEnumerable<Carrier> GetByFilter(string companyName, string cnpj)
        {
            return _carrierService.GetByFilter(companyName, cnpj);
        }
    }
}

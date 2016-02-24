using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class AppCarrierUserPhoneNumberService : AppServiceBase<CarrierPhoneNumber>, IAppCarrierPhoneNumberService
    {
        private readonly ICarrierPhoneNumberService _carrierPhoneNumberService;

        public AppCarrierUserPhoneNumberService(ICarrierPhoneNumberService carrierPhoneNumberService)
            : base(carrierPhoneNumberService)
        {
            _carrierPhoneNumberService = carrierPhoneNumberService;
        }
    }
}

using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class AppCarrierPhoneNumberService : AppServiceBase<CarrierPhoneNumber>, IAppCarrierPhoneNumberService
    {
        private readonly ICarrierPhoneNumberService _carrierPhoneNumberService;

        public AppCarrierPhoneNumberService(ICarrierPhoneNumberService carrierPhoneNumberService)
            : base(carrierPhoneNumberService)
        {
            _carrierPhoneNumberService = carrierPhoneNumberService;
        }
    }
}

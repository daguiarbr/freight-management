using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CarrierUserPhoneNumberService : ServiceBase<CarrierPhoneNumber>, ICarrierPhoneNumberService
    {
        private readonly ICarrierPhoneNumberRepository _carrierPhoneNumberRepository;

        public CarrierUserPhoneNumberService(ICarrierPhoneNumberRepository carrierPhoneNumberRepository)
            : base(carrierPhoneNumberRepository)
        {
            _carrierPhoneNumberRepository = carrierPhoneNumberRepository;
        }
    }
}

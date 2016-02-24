using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CarrierPhoneNumberService : ServiceBase<CarrierPhoneNumber>, ICarrierPhoneNumberService
    {
        private readonly ICarrierPhoneNumberRepository _carrierPhoneNumberRepository;

        public CarrierPhoneNumberService(ICarrierPhoneNumberRepository carrierPhoneNumberRepository)
            : base(carrierPhoneNumberRepository)
        {
            _carrierPhoneNumberRepository = carrierPhoneNumberRepository;
        }
    }
}

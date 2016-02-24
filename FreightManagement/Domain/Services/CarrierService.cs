﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Domain.Services
{
    public class CarrierService : ServiceBase<Carrier>, ICarrierService
    {
        private readonly ICarrierRepository _carrierRepository;

        public CarrierService(ICarrierRepository carrierRepository)
            : base(carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }

        public IEnumerable<Carrier> GetByCompanyName(string companyName)
        {
            return _carrierRepository.GetByCompanyName(companyName);
        }
    }
}
using AutoMapper;
using Domain.Entities;
using FreightManagement.ViewModels;

namespace FreightManagement.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<CarrierViewModel, Carrier>();
            CreateMap<CarrierPhoneNumberViewModel, CarrierPhoneNumber>();
            CreateMap<RatingViewModel, Rating>();
        }
    }
}
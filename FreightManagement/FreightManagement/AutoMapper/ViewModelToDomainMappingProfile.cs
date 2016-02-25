using AutoMapper;
using Domain.Entities;
using FreightManagement.ViewModels;

namespace FreightManagement.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        protected override void Configure()
        {
            CreateMap<Carrier, CarrierViewModel>();
            CreateMap<CarrierPhoneNumber, CarrierPhoneNumberViewModel>();
            CreateMap<Rating, RatingViewModel>();
            CreateMap<User, UserViewModel>();
        }
    }
}
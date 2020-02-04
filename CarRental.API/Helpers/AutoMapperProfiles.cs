using System.Linq;
using AutoMapper;
using CarRental.API.Dtos;
using CarRental.API.Models;

namespace CarRental.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForRentalDto>();
            CreateMap<User, RentalForListDto>();
            CreateMap<Car, CarForRentalDto>()
            .ForMember(dest => dest.PhotoUrl, opt =>
            opt.MapFrom(scr => scr.Photos.FirstOrDefault(p => p.IsMain).Url));
            CreateMap<Rental, RentalForListDto>();
            CreateMap<Photo, PhotosForRentalDto>();
        }
    }
}
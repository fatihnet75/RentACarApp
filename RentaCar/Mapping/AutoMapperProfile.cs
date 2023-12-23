using AutoMapper;
using RentaCar.Dtos;
using RentaCar.Entities;

namespace RentaCar.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<IDictionary<string, object>, Cars>()
                .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]))
                .ForMember(dest => dest.Renk, opt => opt.MapFrom(src => src["renk"]))
                .ForMember(dest => dest.Fiyat, opt => opt.MapFrom(src => src["fiyat"]))
                .ForMember(dest => dest.Yil, opt => opt.MapFrom(src => src["yıl"]));

            CreateMap<IDictionary<string, object>, CarsWithDetail>()
                .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]))
                .ForMember(dest => dest.Renk, opt => opt.MapFrom(src => src["renk"]))
                .ForMember(dest => dest.Fiyat, opt => opt.MapFrom(src => src["fiyat"]))
                .ForMember(dest => dest.Yil, opt => opt.MapFrom(src => src["yıl"]))
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src["marka"]))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src["model"]));

        }
    }
}

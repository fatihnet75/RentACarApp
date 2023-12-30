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

            CreateMap<IDictionary<string, object>, CarRezervation>()
                .ForMember(dest => dest.Tc, opt => opt.MapFrom(src => src["tc"]))
                .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]))
                .ForMember(dest => dest.FirstYil, opt => opt.MapFrom(src => src["başlamatarihi"]))
                .ForMember(dest => dest.LastYil, opt => opt.MapFrom(src => src["bitiştarihi"]))
                .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]));

            CreateMap<IDictionary<string, object>, CarCustommer>()
                .ForMember(dest => dest.Tc, opt => opt.MapFrom(src => src["tc"]))
                .ForMember(dest => dest.isim, opt => opt.MapFrom(src => src["Ad"]))
                .ForMember(dest => dest.SoyIsim, opt => opt.MapFrom(src => src["Soyad"]))
                .ForMember(dest => dest.Tel, opt => opt.MapFrom(src => src["tel"]))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(src => src["Eposta"]));

            CreateMap<IDictionary<string, object>, CarPayment>()
              .ForMember(dest => dest.Tc, opt => opt.MapFrom(src => src["tc"]))
              .ForMember(dest => dest.Tarih, opt => opt.MapFrom(src => src["Tarih"]))
              .ForMember(dest => dest.miktar, opt => opt.MapFrom(src => src["miktar"]));

            CreateMap<IDictionary<string, object>, CarAdvance>()
                
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src["id"]))
              .ForMember(dest => dest.ToplamPara, opt => opt.MapFrom(src => src["toplampara"]))
              .ForMember(dest => dest.Tarih, opt => opt.MapFrom(src => src["Tarih"]));
             

            CreateMap<IDictionary<string, object>, CarCredit>()
                .ForMember(dest => dest.no, opt => opt.MapFrom(src => src["işlemno"]))
              .ForMember(dest => dest.KartId, opt => opt.MapFrom(src => src["kartid"]))
              .ForMember(dest => dest.Cvv, opt => opt.MapFrom(src => src["cvv"]))
              .ForMember(dest => dest.KartName, opt => opt.MapFrom(src => src["kartisim"]));

            CreateMap<IDictionary<string, object>, CarGasoline>()
              .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]))
              .ForMember(dest => dest.marka, opt => opt.MapFrom(src => src["marka"]))
              .ForMember(dest => dest.model, opt => opt.MapFrom(src => src["model"]));

            CreateMap<IDictionary<string, object>, CarElectiric>()
              .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]))
              .ForMember(dest => dest.marka, opt => opt.MapFrom(src => src["marka"]))
              .ForMember(dest => dest.model, opt => opt.MapFrom(src => src["model"]));

            CreateMap<IDictionary<string, object>, AddCArs>()
               .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]))
               .ForMember(dest => dest.Renk, opt => opt.MapFrom(src => src["renk"]))
               .ForMember(dest => dest.Fiyat, opt => opt.MapFrom(src => src["fiyat"]))
               .ForMember(dest => dest.Yil, opt => opt.MapFrom(src => src["yıl"]));

            CreateMap<IDictionary<string, object>, CarOficcial>()
              .ForMember(dest => dest.Rütbe, opt => opt.MapFrom(src => src["rütbe"]))
              .ForMember(dest => dest.tc, opt => opt.MapFrom(src => src["tc"]))
              .ForMember(dest => dest.pzisyon, opt => opt.MapFrom(src => src["pozisyon"]));
              
            CreateMap<IDictionary<string, object>, CarResponsible>()
              .ForMember(dest => dest.AdSoyad, opt => opt.MapFrom(src => src["plaka"]))
              .ForMember(dest => dest.plaka, opt => opt.MapFrom(src => src["renk"]));

            CreateMap<IDictionary<string, object>, CarEmployee>()
              .ForMember(dest => dest.tc, opt => opt.MapFrom(src => src["tc"]))
              .ForMember(dest => dest.Rutbe, opt => opt.MapFrom(src => src["rütbe"]))
              .ForMember(dest => dest.Telefon, opt => opt.MapFrom(src => src["telefon"]));

            CreateMap<IDictionary<string, object>, CarPerson>()
            .ForMember(dest => dest.tc, opt => opt.MapFrom(src => src["tc"]))
            .ForMember(dest => dest.Plaka, opt => opt.MapFrom(src => src["plaka"]));

            CreateMap<IDictionary<string, object>, CarKasko>()
              .ForMember(dest => dest.CarKaskono, opt => opt.MapFrom(src => src["kaskono"]))
              .ForMember(dest => dest.songecerlilik, opt => opt.MapFrom(src => src["songecerlilik"]))
              .ForMember(dest => dest.plaka, opt => opt.MapFrom(src => src["plaka"]));

            CreateMap<IDictionary<string, object>, CarSigorta>()
              .ForMember(dest => dest.plaka, opt => opt.MapFrom(src => src["plaka"]))
              .ForMember(dest => dest.songecerlilik, opt => opt.MapFrom(src => src["songecerlilik"]))
              .ForMember(dest => dest.Sigortano, opt => opt.MapFrom(src => src["sigortano"]));

            CreateMap<IDictionary<string, object>, CarCheufeer>()
              .ForMember(dest => dest.tc, opt => opt.MapFrom(src => src["tc"]))
              .ForMember(dest => dest.Ad, opt => opt.MapFrom(src => src["ad"]))
              .ForMember(dest => dest.Soyad, opt => opt.MapFrom(src => src["soyad"]))
              .ForMember(dest => dest.tip, opt => opt.MapFrom(src => src["ehliyettipi"]));




        }
    }
}

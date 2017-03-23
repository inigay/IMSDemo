using API.Models.Dto;
using AutoMapper;
using IMSDemo;

namespace API.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CompanyDto, Company>()
                .ForMember(dst => dst.Location, opt => opt.MapFrom(src => new Location
                {
                    Address = src.Address,
                    AddressOpt = src.AddressOpt,
                    City = src.City,
                    Zip = src.Zip,
                    State = src.State
                }))
                .ForMember(dst => dst.Inventory, opt => opt.MapFrom(src => new Inventory()));
                

                cfg.CreateMap<Company, CompanyDto>()
                .ForMember(dst => dst.Address, opt => opt.MapFrom(src => src.Location.Address))
                .ForMember(dst => dst.AddressOpt, opt => opt.MapFrom(src => src.Location.AddressOpt))
                .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Location.City))
                .ForMember(dst => dst.State, opt => opt.MapFrom(src => src.Location.State))
                .ForMember(dst => dst.Zip, opt => opt.MapFrom(src => src.Location.Zip))
                .ForMember(dst => dst.InventoryId, opt => opt.MapFrom(src => src.Inventory.InventoryId));
            });

            
        }
    }
}
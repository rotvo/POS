using AutoMapper;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Application.Mappers
{
    public class ClientsMappingsProfile : Profile
    {
        public ClientsMappingsProfile()
        {
            CreateMap<Client, ClientsResponseDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.NumeroWhatsapp, opt => opt.MapFrom(src => src.NumeroWhatsapp.ToString()))
            .ReverseMap();

            CreateMap<ClientRequestDto, Client>()
            .ReverseMap();

            CreateMap<List<Client>, BaseEntityResponse<ClientsResponseDto>>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(src => src.Count));

            CreateMap<ClientsResponseDto, Client>();

          
        }
    }
}

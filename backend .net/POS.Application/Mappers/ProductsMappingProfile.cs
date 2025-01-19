using AutoMapper;
using POS.Application.Dtos.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using System.Collections.Generic;

namespace POS.Application.Mappers
{
    public class ProductsMappingProfile : Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<ProductosFinal, ProductResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NombreProducto, opt => opt.MapFrom(src => src.NombreProducto))
                .ForMember(dest => dest.Costo, opt => opt.MapFrom(src => src.Costo ?? 0))
                .ForMember(dest => dest.CategoriaId, opt => opt.MapFrom(src => src.CategoriaId ?? 0))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta ?? 0))
                .ForMember(dest => dest.MargenGanancia, opt => opt.MapFrom(src => src.MargenGanancia ?? 0))
                .ReverseMap();

            // Mapeo para la lista y BaseEntityResponse
            CreateMap<List<ProductosFinal>, BaseEntityResponse<ProductResponseDto>>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(src => src.Count));

            // Si necesitas mapear de DTO a entidad (como en el caso de clientes)
            CreateMap<ProductResponseDto, ProductosFinal>();
        }
    }
}
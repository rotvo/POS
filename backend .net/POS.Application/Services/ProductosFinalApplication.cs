using AutoMapper;
using POS.Application.Commons.Base;
using POS.Application.Dtos.Response;
using POS.Application.Interfaces;
using POS.Application.Validators.ProductoFinal;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Utilities.Static;

namespace POS.Application.Services
{
    public class ProductosFinalApplication : IProductFinalApplication
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly ProductoFinalValidator _validationRules;
   
    
    public ProductosFinalApplication(IUnitOfWork unitOfWork, IMapper mapper, ProductoFinalValidator validationRules)
    {
            _unitofWork = unitOfWork;
            _mapper = mapper;
            _validationRules = validationRules;
    }

        public async Task<BaseResponse<BaseEntityResponse<ProductResponseDto>>> ListProducts()
        {
            var response = new BaseResponse<BaseEntityResponse<ProductResponseDto>>();
            Console.WriteLine("Starting ListClients method");

            var products = await _unitofWork.Productos.GetAll();
            Console.WriteLine($"Products retrieved: {products?.Count ?? 0}");

            if (products is not null)
            {
                try
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<BaseEntityResponse<ProductResponseDto>>(products);
                    Console.WriteLine("Mapping completed");
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Mapping error: {ex.Message}");
                    throw;
                }
            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
            }
            return response;
        }
    }
}

using POS.Application.Commons.Base;
using POS.Application.Dtos.Response;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Application.Interfaces
{
    public interface IProductFinalApplication
    {
        Task<BaseResponse<BaseEntityResponse<ProductResponseDto>>> ListProducts();
    }
}

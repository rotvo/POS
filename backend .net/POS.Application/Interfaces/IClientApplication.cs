using POS.Application.Commons.Base;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<BaseResponse<BaseEntityResponse<ClientsResponseDto>>> ListClients();
        Task<BaseResponse<ClientsResponseDto>> ClientById(int clientId);
        Task<BaseResponse<bool>> RegisterClient(ClientRequestDto requestDto);
        Task<BaseResponse<bool>> EditClient(int clientId, ClientRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveClient(int clientId);
    }
}

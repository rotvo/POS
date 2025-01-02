using AutoMapper;
using FluentValidation;
using POS.Application.Commons.Base;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Application.Interfaces;
using POS.Application.Validators.Client;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Utilities.Static;

namespace POS.Application.Services
{
    internal class ClientApplication : IClientApplication
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly ClientValidator _validationRules;

        public ClientApplication(IUnitOfWork unitofWork, IMapper mapper, ClientValidator validationRules)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public async Task<BaseResponse<ClientsResponseDto>> ClientById(int clientId)
        {
            var response = new BaseResponse<ClientsResponseDto>();
            var client = await _unitofWork.Clients.ClientById(clientId);

            if (client is not null)
            {
                response.IsSuccess = true;
                response.Data = _mapper.Map<ClientsResponseDto>(client);
                response.Message = ReplyMessage.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_ERROR;
            }
            return response;
        }
        public async Task<BaseResponse<BaseEntityResponse<ClientsResponseDto>>> ListClients()
        {
            var response = new BaseResponse<BaseEntityResponse<ClientsResponseDto>>();
            Console.WriteLine("Starting ListClients method");

            var clients = await _unitofWork.Clients.GetAll();
            Console.WriteLine($"Clients retrieved: {clients?.Count ?? 0}");

            if (clients is not null)
            {
                try
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<BaseEntityResponse<ClientsResponseDto>>(clients);
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

        public async Task<BaseResponse<bool>> RegisterClient(ClientRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            var validationResult = await _validationRules.ValidateAsync(requestDto);

            if(!validationResult.IsValid)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_VALIDATE;
                response.Errors = validationResult.Errors;
                return response;
            }
            var client = _mapper.Map<Client>(requestDto);
            response.Data = await _unitofWork.Clients.RegisterClient(client);

            if(response.Data)
            {
                response.IsSuccess = true;
                response.Message = ReplyMessage.MESSAGE_CREATE;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_ERROR;
            }
            return response;
            
        }
        public async Task<BaseResponse<bool>> EditClient(int clientId, ClientRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            var clientEdit = await ClientById(clientId);

            if(clientEdit.Data is null )
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
            }
            var client = _mapper.Map<Client>(requestDto);
            client.Id = clientId;
            response.Data = await _unitofWork.Clients.EditClient(client);

            if(response.Data)
            {
                response.IsSuccess = true;
                response.Message = ReplyMessage.MESSAGE_UPDATE;

            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_ERROR;
            }
            return response;
        }

        public async Task<BaseResponse<bool>> RemoveClient(int clientId)
        {
            var response = new BaseResponse<bool>();
            var clientEdit = await ClientById(clientId);

            if (clientEdit.Data is null)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
            }

            response.Data = await _unitofWork.Clients.RemoveClient(clientId);
            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = ReplyMessage.MESSAGE_DELETE;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_ERROR;
            }
            return response;
        }

       
    }
}

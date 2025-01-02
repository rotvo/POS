using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Application.Dtos.Request;
using POS.Application.Interfaces;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Controllers
    
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientApplication _clientApplication;

        public ClientsController(IClientApplication clientApplication)
        {
            _clientApplication = clientApplication;
        }

        // GET: Clientes
        [HttpGet("Select")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientes()
        {
            var response = await _clientApplication.ListClients();
            return Ok(response);
        }

        [HttpGet("{clientId:int}")]
        public async Task<ActionResult> ClientById(int clientId)
        {
            var response = await _clientApplication.ClientById(clientId);
            return Ok(response);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterClient([FromBody] ClientRequestDto requestDto)
        {
            var response = await _clientApplication.RegisterClient(requestDto);
            return Ok(response);
        }

        [HttpPut("Edit/{clientId:int}")]
        public async Task<IActionResult> EditClient(int clientId, [FromBody] ClientRequestDto requestDto)
        {
            var response = await _clientApplication.EditClient(clientId, requestDto);
            return Ok(response);
        }


        [HttpDelete("Remove/{clientId:int}")]
        public async Task<IActionResult> RemoveClient(int clientId)
        {
            var response = await _clientApplication.RemoveClient(clientId);
            return Ok(response);
        }


    }
}

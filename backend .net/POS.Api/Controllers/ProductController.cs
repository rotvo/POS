using Microsoft.AspNetCore.Mvc;
using POS.Application.Interfaces;
using POS.Domain.Entities;

namespace POS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductFinalApplication _product;

        public ProductController(IProductFinalApplication product)
        {
            _product = product;
        }

        // GET: Products
        [HttpGet("Select")]
        public async Task<ActionResult<IEnumerable<ProductosFinal>>> GetProducts()
        {
            var response = await _product.ListProducts();
            return Ok(response);
        }

      


    }
}

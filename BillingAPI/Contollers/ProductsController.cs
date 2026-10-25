using Billing.BillingAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Billing.BillingAPI.Services.Interfaces;

namespace Billing.BillingAPI.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _services;

        public ProductsController(IProductServices services)
        {
            _services = services;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> GetProducts()
        {
            var products = await _services.GetAsync();
            return Ok(products);
        }

        // GET: api/products/{Code}
        [HttpGet("code/{code}")]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> GetProductByCode(string code)
        {
            var products = await _services.GetByCodeAsync(code);
            return Ok(products);
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> CreateProduct(ProductCreateDto dto)
        {
            var products = await _services.CreateAsync(dto);
            return Ok(products);
        }

        // PUT: api/products/{code}
        [HttpPut("code/{code}")]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> UpdateProduct(string code, ProductUpdateDto dto)
        {
            var product = await _services.UpdateAsync(code, dto);
            return Ok(product);
        }

        // DELETE: api/products/{code}
        [HttpDelete("code/{code}")]
        public async Task<bool> DeleteProduct(string code)
        {
            return await _services.DeleteAsync(code);
        }
    }
}

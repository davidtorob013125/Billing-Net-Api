using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Billing.BillingAPI.Infrastructure.Data;
using Billing.BillingAPI.Domain.Entities;
using Billing.BillingAPI.DTOs;

namespace Billing.BillingAPI.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly BillingDbContext _context;

        public ProductsController(BillingDbContext context)
        {
            _context = context;
        }
        // GET: api/products
        // para el menu de compras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> GetProducts()
        {
            var products = await _context.Products
                .Where(p => p.IsActive)
                .Select(p => new ProductResponseDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    UnitPrice = p.UnitPrice,
                    Stock = p.Stock
                }).ToListAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> CreateProduct(ProductCreateDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                UnitPrice = dto.UnitPrice,
                Stock= dto.Stock
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var responseDto = new ProductResponseDto
            {
                Id = product.Id,
                Name = product.Name,
                UnitPrice= product.UnitPrice,
                Stock = product.Stock
            };

            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, responseDto);
        }
    }
}

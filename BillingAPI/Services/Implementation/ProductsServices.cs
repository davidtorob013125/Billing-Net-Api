using Billing.BillingAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using Billing.BillingAPI.Domain.Entities;
using Billing.BillingAPI.Services.Interfaces;
using Billing.BillingAPI.Infrastructure.Data;

namespace Billing.BillingAPI.Services.Implementation
{
    public class ProductsServices : IProductServices
    {
        private readonly BillingDbContext _context;
        public ProductsServices(BillingDbContext context)
        {
            _context = context;
        }

        // Get Products
        public async Task<IEnumerable<ProductResponseDto>> GetAsync()
        {
            return await _context.Products
                .Where(p => p.IsActive)
                .Select(p => MapToResponse(p))
                .ToListAsync();
        }

        // Get Product By Code
        public async Task<ProductResponseDto?> GetByCodeAsync(string code)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Code == code && p.IsActive);
            if (product == null) return null;
            return MapToResponse(product);
        }

        // Create Product
        public async Task<ProductResponseDto> CreateAsync(ProductCreateDto dto)
        {
            var product = new Product
            {
                Code = dto.Code,
                Name = dto.Name,
                UnitPrice = dto.UnitPrice,
                Discount = dto.Discount,
                TaxRate = dto.TaxRate,
                Stock = dto.Stock,
                IsActive = true
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return MapToResponse(product);
        }

        // Update Product
        public async Task<ProductResponseDto?> UpdateAsync(string code, ProductUpdateDto dto)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Code == code);
            if (product == null) return null;

            product.Code = string.IsNullOrEmpty(dto.Code) ? product.Code : dto.Code;
            product.Name = string.IsNullOrEmpty(dto.Name) ? product.Name : dto.Name;
            product.UnitPrice = dto.UnitPrice ?? product.UnitPrice;
            product.Discount = dto.Discount ?? product.Discount;
            product.TaxRate = dto.TaxRate ?? product.TaxRate;
            product.Stock = dto.Stock ?? product.Stock;
            product.IsActive = dto.IsActive ?? product.IsActive;

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return MapToResponse(product);
        }

        // Delete Product
        public async Task<bool> DeleteAsync(string code)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Code == code);
            if (product == null) return false;

            product.IsActive = false;
            await _context.SaveChangesAsync();
            return true;
        }

        //MapToResponse
        private static ProductResponseDto MapToResponse(Product p) => new()
        {
            Code = p.Code,
            Name = p.Name,
            UnitPrice = p.UnitPrice,
            Discount = p.Discount,
            TaxRate = p.TaxRate,
            Stock = p.Stock,
            IsActive = p.IsActive
        };

    }
}

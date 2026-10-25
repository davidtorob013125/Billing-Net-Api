using Billing.BillingAPI.DTOs;

namespace Billing.BillingAPI.Services.Interfaces
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductResponseDto>> GetAsync();
        Task<ProductResponseDto?> GetByCodeAsync(string code);
        Task<ProductResponseDto> CreateAsync(ProductCreateDto dto);
        Task<ProductResponseDto?> UpdateAsync(string code, ProductUpdateDto dto);
        Task<bool> DeleteAsync(string code);
    }
}

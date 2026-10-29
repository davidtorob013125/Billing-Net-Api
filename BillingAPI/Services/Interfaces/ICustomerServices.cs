using Billing.BillingAPI.DTOs;

namespace Billing.BillingAPI.Services.Interfaces
{
    public interface ICustomerServices
    {
        Task<IEnumerable<CustomerResponseDto>> GetAsync();
        Task<CustomerResponseDto?> GetByDocumentNumberAsync(string DocumentNumber);
        Task<CustomerResponseDto> CreateAsync(CustomerCreateDto dto);
        Task<CustomerResponseDto?> UpdateAsync(string DocumentNumber, CustomerUpdateDto dto);
        Task<bool> DeleteAsync(string DocumentNumber);
    }
}

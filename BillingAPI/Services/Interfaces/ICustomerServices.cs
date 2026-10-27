using Billing.BillingAPI.DTOs;

namespace Billing.BillingAPI.Services.Interfaces
{
    public interface ICustomerService
    {
        public Task<IEnumerable<CustomerResponseDto>> GetAsync();
        public Task<CustomerResponseDto?> GetByDocumentNumberAsync(string DocumentNumber);
        public Task<CustomerResponseDto> CreateAsync(CustomerCreateDto dto);
        public Task<CustomerResponseDto?> UpdateAsync(string DocumentNumber, CustomerUpdateDto dto);
        public Task<bool> DeleteAsync(string DocumentNumber);
    }
}

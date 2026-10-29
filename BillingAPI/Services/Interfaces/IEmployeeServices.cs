using Billing.BillingAPI.DTOs;

namespace Billing.BillingAPI.Services.Interfaces
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<EmployeeResponseDto>> GetAll();
        Task<EmployeeResponseDto?> GetByDocumentId(string  documentId);
        Task<EmployeeResponseDto> Create(EmployeeCreateDto dto);
        Task<EmployeeResponseDto?> Update(string documentId, EmployeeUpdateDto dto);
        Task<bool> Delete(string documentId);
    }
}

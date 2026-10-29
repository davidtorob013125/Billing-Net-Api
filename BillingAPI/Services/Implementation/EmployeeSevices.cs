using Billing.BillingAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using Billing.BillingAPI.Domain.Entities;
using Billing.BillingAPI.Services.Interfaces;
using Billing.BillingAPI.Infrastructure.Data;

namespace Billing.BillingAPI.Services.Implementation
{
    public class EmployeeSevices : IEmployeeServices
    {
        private readonly BillingDbContext _context;

        public EmployeeSevices(BillingDbContext context)
        {
            _context = context;
        }

        // Get All If Employee Is Active
        public async Task<IEnumerable<EmployeeResponseDto>> GetAll()
        {
            return await _context.Employee
                .Where(e => e.IsActive)
                .Select(e => MapToResponse(e))
                .ToListAsync();
        }

        // Get With NumberId
        public async Task<EmployeeResponseDto?> GetByDocumentId(string numberId)
        {
            var employee = await _context.Employee
                .FirstOrDefaultAsync(e => e.DocumentNumber == numberId && e.IsActive);
            if (employee == null) return null;
            return MapToResponse(employee);
        }

        // Crate Employee
        public async Task<EmployeeResponseDto> Create(EmployeeCreateDto dto)
        {
            var employee = new Employee
            {
                Name = dto.Name,
                DocumentType = dto.DocumentType,
                DocumentNumber = dto.DocumentNumber,
                Phone = dto.Phone,
                Email = dto.Email,
                Address = dto.Address,
                TypeCountBancary = dto.TypeCountBancary,
                NameCountBancary = dto.NameCountBancary,
                CountBancary = dto.CountBancary
            };

            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();

            return MapToResponse(employee);
        }

        // Update Employee
        public async Task<EmployeeResponseDto?> Update(string documentId, EmployeeUpdateDto dto)
        {
            var employee = await _context.Employee
                .FirstOrDefaultAsync(e => e.DocumentNumber == documentId);
            if(employee == null) return null;

            employee.Name = string.IsNullOrEmpty(dto.Name) ? employee.Name : dto.Name;
            employee.DocumentType = string.IsNullOrEmpty(dto.DocumentType) ? employee.DocumentType : dto.DocumentType;
            employee.DocumentNumber = string.IsNullOrEmpty(dto.DocumentNumber) ? employee.DocumentNumber : dto.DocumentNumber;
            employee.Phone = string.IsNullOrEmpty(dto.Phone) ? employee.Phone : dto.Phone;
            employee.Email = string.IsNullOrEmpty(dto.Email) ? employee.Email : dto.Email;
            employee.Address = string.IsNullOrEmpty(dto.Address) ? employee.Address : dto.Address;
            employee.TypeCountBancary = string.IsNullOrEmpty(dto.TypeCountBancary) ? employee.TypeCountBancary : dto.TypeCountBancary;
            employee.NameCountBancary = string.IsNullOrEmpty(dto.NameCountBancary) ? employee.NameCountBancary : dto.NameCountBancary;
            employee.CountBancary = string.IsNullOrEmpty(dto.CountBancary) ? employee.CountBancary : dto.CountBancary;
            employee.IsActive = dto.IsActive ?? employee.IsActive;

            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return MapToResponse(employee);
        }

        // Delete Employee
        public async Task<bool> Delete(string documentId)
        {
            var employee = await _context.Employee
                .FirstOrDefaultAsync(e => e.DocumentNumber == documentId && e.IsActive);
            if (employee == null) return false;

            employee.IsActive = false;
            await _context.SaveChangesAsync();
            return true;
        }

        //MapToResponse
        private static EmployeeResponseDto MapToResponse(Employee e) => new()
        {
            Name = e.Name,
            DocumentType = e.DocumentType,
            DocumentNumber = e.DocumentNumber,
            Phone = e.Phone,
            Email = e.Email,
            Address = e.Address,
            TypeCountBancary = e.TypeCountBancary,
            NameCountBancary = e.NameCountBancary,
            CountBancary = e.CountBancary,
            IsActive = e.IsActive
        };
    }
}

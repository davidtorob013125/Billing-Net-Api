using Billing.BillingAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using Billing.BillingAPI.Domain.Entities;
using Billing.BillingAPI.Services.Interfaces;
using Billing.BillingAPI.Infrastructure.Data;

namespace Billing.BillingAPI.Services.Implementation
{
    public class CustomerServices : ICustomerServices
    {
        private readonly BillingDbContext _context;

        public CustomerServices(BillingDbContext context)
        {
            _context = context;
        }

        // Get all if is active
        public async Task<IEnumerable<CustomerResponseDto>> GetAsync()
        {
            return await _context.Customers
                .Where(c => c.IsActive)
                .Select(c => MapToResponse(c))
                .ToListAsync();
        }

        // Get By Document-Number 
        public async Task<CustomerResponseDto?> GetByDocumentNumberAsync(string document)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.DocumentNumber == document);
            if (customer == null || !customer.IsActive) return null;
            return MapToResponse(customer);
        }

        // Create Customer
        public async Task<CustomerResponseDto> CreateAsync(CustomerCreateDto dto)
        {
            var customer = new Customer
            {
                Name = dto.Name,
                DocumentType = dto.DocumentType,
                DocumentNumber = dto.DocumentNumber,
                Email = dto.Email,
                Address = dto.Address
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return MapToResponse(customer);
        }

        // Update Customer
        public async Task<CustomerResponseDto?> UpdateAsync(string document, CustomerUpdateDto dto)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.DocumentNumber == document);
            if (customer == null) return null;

            customer.Name = string.IsNullOrEmpty(dto.Name) ? customer.Name : dto.Name;
            customer.DocumentType = string.IsNullOrEmpty(dto.DocumentType) ? customer.DocumentType : dto.DocumentType;
            customer.DocumentNumber = string.IsNullOrEmpty(dto.DocumentNumber) ? customer.DocumentNumber : dto.DocumentNumber;
            customer.Email = string.IsNullOrEmpty(dto.Email) ? customer.Email : dto.Email;
            customer.Address = string.IsNullOrEmpty(dto.Address) ? customer.Address : dto.Address;
            customer.IsActive = dto.IsActive ?? customer.IsActive;

            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return MapToResponse(customer);
        }

        //Delete Customer
        public async Task<bool> DeleteAsync(string document)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.DocumentNumber == document && c.IsActive);
            if (customer == null) return false;

            customer.IsActive = false;
            await _context.SaveChangesAsync();

            return true;
        }

        // MapToReponse
        private static CustomerResponseDto MapToResponse(Customer c) => new()
        {
            Name = c.Name,
            DocumentType = c.DocumentType,
            DocumentNumber = c.DocumentNumber,
            Email = c.Email,
            Address = c.Address,
            IsActive = c.IsActive
        };
    }
}

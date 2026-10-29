using Billing.BillingAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Billing.BillingAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Billing.BillingAPI.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _service;

        public CustomerController(ICustomerServices service)
        {
            _service = service;
        }

        // GET: api/customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerResponseDto>>> GetCustomer()
        {
            var customer = await _service.GetAsync();
            return Ok(customer);
        }

        // GET: api/customer/{document}
        [HttpGet("document/{document}")]
        public async Task<ActionResult<IEnumerable<CustomerResponseDto>>> GetByDocumentNumberCustomer(string document)
        {
            var customer = await _service.GetByDocumentNumberAsync(document);
            return Ok(customer);
        }

        // POST: api/customer
        [HttpPost]
        public async Task<ActionResult<IEnumerable<CustomerResponseDto>>> CreateCustomer(CustomerCreateDto dto)
        {
            var customer = await _service.CreateAsync(dto);
            return Ok(customer);
        }

        // PUT: api/customer/{document}
        [HttpPut("document/{document}")]
        public async Task<ActionResult<IEnumerable<CustomerResponseDto>>> UpdateCustomer(string document, CustomerUpdateDto dto)
        {
            var customer = await _service.UpdateAsync(document, dto);
            return Ok(customer);
        }

        // DELETE: api/customer/{document}
        [HttpDelete("document/{document}")]
        public async Task<bool> DeleteCustomer(string document)
        {
            return await _service.DeleteAsync(document);
        }
    }
}

using Billing.BillingAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Billing.BillingAPI.Services.Interfaces;

namespace Billing.BillingAPI.Contollers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _services;

        public EmployeeController (IEmployeeServices services)
        {
            _services = services;
        }

        // GET: api/employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeResponseDto>>> GetEmployee()
        {
            var employee = await _services.GetAll();
            return Ok(employee);
        }

        // GET: api/employee/{document}
        [HttpGet("document/{document}")]
        public async Task<ActionResult<IEnumerable<EmployeeResponseDto>>> GetByDocumentId(string document)
        {
            var employee = await _services.GetByDocumentId(document);
            return Ok(employee);
        }

        // POST: api/employee
        [HttpPost]
        public async Task<ActionResult<IEnumerable<EmployeeResponseDto>>> CreateEmployee(EmployeeCreateDto dto)
        {
            var employee = await _services.Create(dto);
            return Ok(employee);
        }

        // PUT: api/employee/{document}
        [HttpPut("document/{document}")]
        public async Task<ActionResult<IEnumerable<EmployeeResponseDto>>> UpdateEmployee(string document, EmployeeUpdateDto dto)
        {
            var employee = await _services.Update(document, dto);
            return Ok(employee);
        }

        // DELETE: api/employee/{document}
        [HttpDelete("document/{document}")]
        public async Task<bool> DeleteEmployee(string document)
        {
            return await _services.Delete(document);
        }
    }
}

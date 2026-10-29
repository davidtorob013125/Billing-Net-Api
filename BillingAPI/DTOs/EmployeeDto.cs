namespace Billing.BillingAPI.DTOs
{
    public class EmployeeResponseDto
    {
        public string Name { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TypeCountBancary { get; set; } = string.Empty;
        public string NameCountBancary { get; set; } = string.Empty;
        public string CountBancary { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }

    public class EmployeeCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TypeCountBancary { get; set; } = string.Empty;
        public string NameCountBancary { get; set; } = string.Empty;
        public string CountBancary { get; set; } = string.Empty;
    }

    public class EmployeeUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TypeCountBancary { get; set; } = string.Empty;
        public string NameCountBancary { get; set; } = string.Empty;
        public string CountBancary { get; set; } = string.Empty;
        public bool? IsActive { get; set; }
    }
}

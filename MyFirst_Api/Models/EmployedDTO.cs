namespace MyFirst_Api.Models
{
    public class EmployedDTO
    {
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public required string Email { get; set; }
        public decimal Salary { get; set; }
    }
}

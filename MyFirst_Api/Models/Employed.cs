namespace MyFirst_Api.Models
{
    public class Employed

    {

        public int Id { get; set; }
        public  required string Name { get; set; }
        public string? Phone { get; set; }
        public required string Email { get; set; }
        public decimal Salary { get; set; }
    }
}

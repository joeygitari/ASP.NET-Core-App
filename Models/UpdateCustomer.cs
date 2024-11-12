namespace ASP.NET_Core_App.Models
{
    public class UpdateCustomer
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
    }
}

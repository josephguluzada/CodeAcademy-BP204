namespace Pustok.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? AppUserId { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string? Note { get; set; }
        public double TotalPrice { get; set; }


        public AppUser? AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

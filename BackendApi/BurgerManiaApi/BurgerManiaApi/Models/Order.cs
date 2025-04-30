namespace BurgerManiaApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public DateTime OrderDate { get; set; }
        public string? DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; } // Pending, Completed, Cancelled, etc.
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}

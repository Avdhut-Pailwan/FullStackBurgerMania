namespace BurgerManiaApi.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int BurgerId { get; set; }
        public Burger? Burger { get; set; }
        public int Quantity { get; set; }   
        public decimal Price { get; set; }
    }
}

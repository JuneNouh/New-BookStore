namespace BookStore.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Book book { get; set; }
        public int Quantity { get; set; }
        public string Cartid { get; set; }
    }
}

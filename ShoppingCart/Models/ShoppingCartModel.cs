namespace ShoppingCart.Models
{
    public sealed class ShoppingCartModel
    {
        public string Customer { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

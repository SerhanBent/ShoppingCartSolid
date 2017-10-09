namespace ShoppingCart.Models
{
    public enum CustomerType
    {
        Standard = 0,
        Silver = 2,
        Gold = 3
    }

    public sealed class CustomerModel
    {
        public string Name { get; set; }
        public CustomerType Type { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal TotalSpent { get; set; }
    }
}

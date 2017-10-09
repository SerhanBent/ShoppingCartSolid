using System;

namespace ShoppingCart.Models
{
    public sealed class OrderLineModel
    {
        public Guid OrderId { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

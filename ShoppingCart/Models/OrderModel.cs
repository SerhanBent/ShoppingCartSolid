using System;
using System.Collections.Generic;

namespace ShoppingCart.Models
{
    public sealed class OrderModel
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }

        public List<OrderLineModel> OrderLines { get; set; }
    }
}

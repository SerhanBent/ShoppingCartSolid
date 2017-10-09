using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public sealed class DiscountService
    {
        public int GetDiscount(CustomerType customerType)
        {
            var discount = (int)customerType;

            return discount;
        }
    }
}

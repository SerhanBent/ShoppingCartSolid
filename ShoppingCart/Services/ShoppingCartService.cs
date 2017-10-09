using ShoppingCart.Models;
using System.Collections.Generic;

namespace ShoppingCart.Services
{
    public sealed class ShoppingCartService
    {
        private IList<ShoppingCartModel> _existingCart;

        public ShoppingCartService(IList<ShoppingCartModel> existingCart)
        {
            _existingCart = existingCart;

            if (existingCart == null)
            {
                _existingCart = new List<ShoppingCartModel>();
            }
        }

        public IList<ShoppingCartModel> AddToCart(ShoppingCartModel shoppingCartModel)
        {
            if (shoppingCartModel != null)
            {
                _existingCart.Add(shoppingCartModel);
            }

            return _existingCart;
        }
    }
}

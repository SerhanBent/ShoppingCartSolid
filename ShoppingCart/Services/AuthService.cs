using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public sealed class AuthService
    {
        private const string DEFAULT_USERNAME = "test@gmail.com";
        private const string DEFAULT_PASSWORD = "test";

        public bool Validate(AuthModel authModel)
        {
            var username = authModel.Username;
            var password = authModel.Password;

            var result = (username == DEFAULT_USERNAME) && (password == DEFAULT_PASSWORD);

            return result;
        }
    }
}

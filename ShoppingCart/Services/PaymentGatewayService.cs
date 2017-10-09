namespace ShoppingCart.Services
{
    public sealed class PaymentGatewayService
    {
        private readonly string _customer;
        private readonly decimal _amount;

        public PaymentGatewayService(string customer, decimal amount)
        {
            _customer = customer;
            _amount = amount;
        }

        public bool HasPaymentAuthorised()
        {
            // do the actual check for this particular customer. Just writing dummy function for this example.
            var isAuthorized = IsOdd(_amount);

            return isAuthorized;
        }

        public static bool IsOdd(decimal value)
        {
            var result = value % 2 != 0;

            return result;
        }
    }
}

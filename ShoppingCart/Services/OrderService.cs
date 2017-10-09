using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public sealed class OrderService
    {
        private readonly OrderModel _orderModel;

        public OrderService(OrderModel orderModel)
        {
            _orderModel = orderModel;
        }

        public void ConfirmOrder()
        {
            var validationSucceeded = HasAllValidationsSucceeded();

            if (!validationSucceeded)
            {
                UpdateCustomerRecordToUpdateType();
            }
        }

        private bool HasAllValidationsSucceeded()
        {
            bool hasValidationFailed = false;

            hasValidationFailed = CheckWithPaymentGateway();

            return hasValidationFailed;
        }

        private bool CheckWithPaymentGateway()
        {
            var customer = _orderModel.Customer;
            var amount = _orderModel.Amount;

            var hasPaymentAuthorised = new PaymentGatewayService(customer, amount).HasPaymentAuthorised();

            return hasPaymentAuthorised;
        }

        private void UpdateCustomerRecordToUpdateType()
        {
            var customer = _orderModel.Customer;

            new CustomerService().UpdateCustomerMembershipType(customer);
        }
    }
}

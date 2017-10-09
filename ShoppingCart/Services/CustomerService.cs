using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public sealed class CustomerService
    {
        private const int DEFAULT_ROLLING_MONTHS = 12;
        private const decimal DEFAULT_SILVER_BAND = 500;
        private const decimal DEFAULT_GOLD_BAND = 800;

        public void OrderConfirmation()
        {
        }

        public void UpdateCustomerMembershipType(string customerName)
        {
            var customer = GetCustomerRecord(customerName, DEFAULT_ROLLING_MONTHS);

            if (customer.TotalSpent > DEFAULT_SILVER_BAND)
            {
                UpdateDatabase(customerName, CustomerType.Silver);
            }

            if (customer.TotalSpent > DEFAULT_GOLD_BAND)
            {
                UpdateDatabase(customerName, CustomerType.Gold);
            }
        }

        private void UpdateDatabase(string customerName, CustomerType customerType)
        {
            // send an update statement to the database.

            var customerTypeId = (int)customerType;

            // update @customerTypeId to the database against @customerName.
        }

        private CustomerModel GetCustomerRecord(string customerName, int months)
        {
            var customerModel = new CustomerModel()
            {
                Type = CustomerType.Gold,
                TotalSpent = 700
            };
            // Send the number of @months to the database to get the total spendings for this @customerName. 
            // Am hard-coding for this example.

            return customerModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Customers { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeleteCustomer(PaymentAccount account)
        {
            return Customers.Remove(account);
        }

        public PaymentAccount Find(float debit)
        {
            return Customers.SingleOrDefault(x => x.AllowedDebit == debit);
        }

        public bool Charge(int customerId, float amount)
        {
            var customer = Customers.SingleOrDefault(x => x.Id == customerId);
            if (customer == null)
            {
                return false;
            }

            if (customer.Income - customer.Outcome + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcome += amount;
            return true;
        }

        public void Fund(int customerId, float amount)
        {
            var customer = Customers.Where(x => x.Id == customerId).SingleOrDefault();
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int param1)
        {
            var customer = Customers.Where(x => x.Id == param1).SingleOrDefault();
            return customer?.Income - customer?.Outcome;
        }
    }
}

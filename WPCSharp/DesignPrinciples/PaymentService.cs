using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Customers { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public PaymentAccount FindById(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

        public bool Charge(int customerId, float amount)
        {
            var customer = FindById(customerId);
            if (customer == null)
            {
                return false;
            }

            if (GetBalance(customerId) + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcome += amount;
            return true;
        }

        public void Fund(int customerId, float amount)
        {
            var customer = FindById(customerId);
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var customer = FindById(id);
            return customer?.Income - customer?.Outcome;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }

        public PaymentAccount PaymentAccount { get; set; }
    }
}

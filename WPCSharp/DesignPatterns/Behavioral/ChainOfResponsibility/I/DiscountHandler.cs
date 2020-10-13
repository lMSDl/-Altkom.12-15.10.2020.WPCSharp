using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    class DiscountHandler : BaseHandler, IDiscountHandler
    {
        public float MaxDiscount { get; }

        public float MinPrice { get; }

        public DiscountHandler(float maxDiscount, float minPrice, IDiscountHandler discountHandler) : base(discountHandler)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public DiscountHandler(float maxDiscount, float minPrice) : this(maxDiscount, minPrice, null)
        {
        }

        public bool Discount(float value, float price)
        {
            if(MaxDiscount > value && price >= MinPrice)
            {
                Console.WriteLine($"Rabat przyznany przez {Name}");
                return true;
            }

            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}

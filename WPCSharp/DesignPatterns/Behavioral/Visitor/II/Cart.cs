using System;

namespace DesignPatterns.Behavioral.Visitor.II
{
    public class Cart : Basket
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Produkt w wózku");
        }

        public override void Add(BoxedProduct product)
        {
            Console.WriteLine("Całe opakowanie produktu w wózku");
        }
    }
}

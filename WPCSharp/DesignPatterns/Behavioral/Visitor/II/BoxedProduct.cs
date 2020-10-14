using System;

namespace DesignPatterns.Behavioral.Visitor.II
{
    public class BoxedProduct : Product
    {

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

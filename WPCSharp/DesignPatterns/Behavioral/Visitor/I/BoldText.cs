namespace DesignPatterns.Behavioral.Visitor.I
{
    public class BoldText : IElement
    {
        public string Bold { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

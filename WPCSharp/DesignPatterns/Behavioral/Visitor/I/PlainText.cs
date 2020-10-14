namespace DesignPatterns.Behavioral.Visitor.I
{
    public class PlainText : IElement
    {
        public string Plain { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

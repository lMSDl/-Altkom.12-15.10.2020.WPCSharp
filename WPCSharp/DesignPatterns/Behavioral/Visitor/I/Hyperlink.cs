namespace DesignPatterns.Behavioral.Visitor.I
{
    public class Hyperlink : IElement
    {
        public string Url { get; set; }
        public string Label { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

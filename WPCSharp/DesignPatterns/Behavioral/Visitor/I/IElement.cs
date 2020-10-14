namespace DesignPatterns.Behavioral.Visitor.I
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

namespace DesignPatterns.Behavioral.Visitor.II
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

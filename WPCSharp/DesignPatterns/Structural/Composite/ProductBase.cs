namespace DesignPatterns.Structural.Composite
{
    public abstract class ProductBase : IComponent
    {
        public string Name { get; }

        protected ProductBase(string name)
        {
            Name = name;
        }

        public abstract float GetPrice();
    }
}

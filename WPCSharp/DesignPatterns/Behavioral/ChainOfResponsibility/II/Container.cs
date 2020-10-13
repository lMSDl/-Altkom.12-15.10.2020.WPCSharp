using System.Collections.Generic;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public abstract class Container : Component
    {
        protected ICollection<Component> Content { get; } = new List<Component>();

        public void Add(Component component)
        {
            Content.Add(component);
            component.Parent = this;
        }
    }
}

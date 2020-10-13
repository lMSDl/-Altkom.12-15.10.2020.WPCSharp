using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<Component, bool> Func { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && !Func.Invoke(Parent))
                base.Click(handled);
            else
                base.Click(true);
        }
    }
}

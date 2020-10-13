namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public abstract class Component
    {
        public Component Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        public int ClickCounter { get; private set; }

        protected virtual void Click(bool handled)
        {
            ClickCounter++;
            Parent?.Click(handled);
        }
    }
}

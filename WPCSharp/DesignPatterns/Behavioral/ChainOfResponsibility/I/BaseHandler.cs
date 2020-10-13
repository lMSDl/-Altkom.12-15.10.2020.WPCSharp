namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public abstract class BaseHandler
    {
        protected IDiscountHandler NextHandler { get; }

        protected BaseHandler(IDiscountHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public string Name { get; set; }

    }
}

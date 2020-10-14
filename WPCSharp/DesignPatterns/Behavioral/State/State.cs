namespace DesignPatterns.Behavioral.State
{
    public abstract class State : IState
    {
        private CoffeeMachine coffeeMachine;

        public CoffeeMachine CoffeeMachine
        {
            protected get => coffeeMachine;
            set
            {
                coffeeMachine = value;
                Init();
            }
        }

        protected abstract void Init();
        public abstract void SmallCoffee();
        public abstract void LargeCoffee();

    }
}

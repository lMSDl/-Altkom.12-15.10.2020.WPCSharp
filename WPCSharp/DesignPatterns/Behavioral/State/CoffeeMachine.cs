using System;

namespace DesignPatterns.Behavioral.State
{
    public class CoffeeMachine : IState
    {
        private State _state;

        public CoffeeMachine()
        {
            TransitionTo(new HeatingUpState());
        }

        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }

        public void SmallCoffee()
        {
            _state.SmallCoffee();
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"CoffeeMachine: Transition to {state.GetType().Name}");
            _state = state;
            state.CoffeeMachine = this;
        }


    }
}

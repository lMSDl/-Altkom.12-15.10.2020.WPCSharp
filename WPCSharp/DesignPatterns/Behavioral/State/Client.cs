using System;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class Client
    {
        public static void Execute()
        {
            var coffeeMachine = new CoffeeMachine();

            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith(x => coffeeMachine.LargeCoffee());

            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith(x => coffeeMachine.LargeCoffee());
            Task.Delay(TimeSpan.FromSeconds(9)).ContinueWith(x => coffeeMachine.SmallCoffee());

            Task.Delay(TimeSpan.FromSeconds(12)).ContinueWith(x => coffeeMachine.SmallCoffee());

        }
    }
}

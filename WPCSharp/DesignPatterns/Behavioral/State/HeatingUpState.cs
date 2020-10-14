using System;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class HeatingUpState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: I am heating up!");
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: I am heating up!");
        }

        protected override void Init()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(5));
            task.ContinueWith(x => CoffeeMachine.TransitionTo(new IdleState()));
        }
    }
}

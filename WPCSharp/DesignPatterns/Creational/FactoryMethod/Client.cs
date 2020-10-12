namespace DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();
            var action = "Down";
            elevator.Execute(action, 3);
            elevator.Execute(ElevatorActions.Up.ToString(), 6);
            elevator.Execute(ElevatorActions.GoTo.ToString(), 1);
        }
    }
}

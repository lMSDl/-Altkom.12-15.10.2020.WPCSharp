using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        public readonly Dictionary<string, IElevatorOperation> _operations;

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));
        }

        public void Execute(string action, int floor)
        {
            Execute(CreateOperation(action), floor);
        }

        public void Execute(IElevatorOperation command, int floor)
        {
            command?.Operate(floor);
        }

        public IElevatorOperation CreateOperation(string action)
        {
            return _operations[action];

            return (IElevatorOperation)Activator.CreateInstance(Type.GetType($"{GetType().Namespace}.{nameof(Elevator)}{action}"));

            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    return new ElevatorDown();
                case nameof(ElevatorUp):
                    return new ElevatorUp();
                case nameof(ElevatorGoTo):
                    return new ElevatorGoTo();
            }
            return null;
        }
    }
}

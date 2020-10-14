using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public abstract class Command : ICommand
    {
        protected Garden _garden;
        protected string _plant;

        public Command(Garden garden, string plant)
        {
            _garden = garden;
            _plant = plant;
        }

        public abstract bool Execute();
        public abstract void Undo();
    }
}

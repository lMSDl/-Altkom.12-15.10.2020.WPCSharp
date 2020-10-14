using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(Garden garden, string plant) : base(garden, plant)
        {
        }

        public override bool Execute()
        {
            return _garden.Remove(_plant);
        }

        public override void Undo()
        {
            _garden.Plant(_plant);
        }
    }
}

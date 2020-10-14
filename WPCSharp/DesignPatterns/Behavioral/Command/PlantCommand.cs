using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class PlantCommand : Command
    {
        public PlantCommand(Garden garden, string plant) : base(garden, plant)
        {
        }

        public override bool Execute()
        {
            return _garden.Plant(_plant);
        }

        public override void Undo()
        {
            _garden.Remove(_plant);
        }
    }
}

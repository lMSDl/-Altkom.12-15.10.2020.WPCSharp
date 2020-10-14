using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.NullObject
{
    public class ConsoleOutput : Output
    {
        public override void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}

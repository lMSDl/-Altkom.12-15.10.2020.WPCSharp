using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class SubsciberB : Subsciber
    {
        public override void OnNext(int value)
        {
            if(value > 8 || value < 3)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}

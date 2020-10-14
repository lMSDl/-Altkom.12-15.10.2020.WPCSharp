using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class SubsciberA : Subsciber
    {
        public override void OnNext(int value)
        {
            if(value > 5)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}

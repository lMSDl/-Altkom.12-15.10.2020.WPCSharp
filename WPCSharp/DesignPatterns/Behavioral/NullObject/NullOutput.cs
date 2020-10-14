using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Behavioral.NullObject
{
    public class NullOutput : Output
    {
        public override void Show(string message)
        {
        }
    }
}

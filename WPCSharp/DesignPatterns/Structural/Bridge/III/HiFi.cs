using System;

namespace DesignPatterns.Structural.Bridge.III
{
    public class HiFiRemote
    {
        public void PowerOn()
        {
            Console.WriteLine("HiFi power on");
        }

        public void PowerOff()
        {
            Console.WriteLine("HiFi power off");
        }

        public void VolumeDown()
        {
            Console.WriteLine("HiFi volume up");
        }

        public void VolumeUp()
        {
            Console.WriteLine("HiFi volume down");
        }
    }
}

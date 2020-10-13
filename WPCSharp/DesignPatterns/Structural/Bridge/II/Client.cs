using System;

namespace DesignPatterns.Structural.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            MessageAbstraction message = new ShortMessageAbstraction(new SmsGate());

            message.Send(Console.ReadLine());
        }
    }
}

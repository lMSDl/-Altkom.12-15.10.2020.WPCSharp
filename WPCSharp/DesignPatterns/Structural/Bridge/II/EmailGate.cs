using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge.II
{
    public class EmailGate : IMessageSenderImplementation
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadomość wsyłana przez Email: {message}");
        }
    }
}

using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Notification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Wysłano wewnętrzną notyfikację: " + message);
        }
    }
}

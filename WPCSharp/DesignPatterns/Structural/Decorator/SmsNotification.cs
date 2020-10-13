using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class SmsNotification : BaseDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        public override void ExtraSend(string message)
        {
            Console.WriteLine("Wysłano wiadomość SMS:" + message);
        }
    }
}

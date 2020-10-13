using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Client
    {
        public static void Execute()
        {
            var test = Console.ReadLine();

            var notification = (INotification)new Notification();
            Console.WriteLine("SMS?");
            if (Console.ReadKey().KeyChar == 'y')
                notification = new SmsNotification(notification);
            Console.WriteLine("Email?");
            if (Console.ReadKey().KeyChar == 'y')
                notification = new EmailNotification(notification);


            notification.Send(test);
        }
    }
}

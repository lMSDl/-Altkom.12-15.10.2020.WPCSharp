using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            IDatabase database = new DatabaseProxy(new Database());

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }
        }
    }
}

using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<DatabaseService>
    {
        
        protected override void SaveLog(DatabaseService service, string messageToLog)
        {
            service.Insert(messageToLog);
        }

        protected override DatabaseService ConnectToService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
    }
}

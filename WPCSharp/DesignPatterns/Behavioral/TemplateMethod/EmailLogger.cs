using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<IDisposable>
    {
 
        protected override void SaveLog(IDisposable service, string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        protected override IDisposable ConnectToService()
        {
            return null;
        }
        
    }
}

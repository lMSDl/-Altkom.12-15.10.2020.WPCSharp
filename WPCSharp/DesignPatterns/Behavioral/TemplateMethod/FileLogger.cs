using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : Logger<FileService>
    {
        protected override void OnCloseService()
        {
            Console.WriteLine("FileLogger closed");
        }

        protected override void SaveLog(FileService service, string messageToLog)
        {
            service.Write(messageToLog);
        }

        protected override FileService ConnectToService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
    }
}

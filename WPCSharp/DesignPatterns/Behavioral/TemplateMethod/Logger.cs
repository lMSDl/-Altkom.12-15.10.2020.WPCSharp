using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger<T> where T : IDisposable
    {
        public void Log(string message)
        {
            var messageToLog = Serialize(message);
            using (var service = ConnectToService())
            {
                SaveLog(service, messageToLog);
            }
            OnCloseService();
        }

        protected virtual void OnCloseService() { }

        protected abstract void SaveLog(T service, string messageToLog);

        protected abstract T ConnectToService();

        private string Serialize(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}

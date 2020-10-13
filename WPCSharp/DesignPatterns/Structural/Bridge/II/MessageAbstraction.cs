using System;

namespace DesignPatterns.Structural.Bridge.II
{
    public class MessageAbstraction
    {

        private IMessageSenderImplementation MessageSender { get; }

        public MessageAbstraction(IMessageSenderImplementation messageSender)
        {
            MessageSender = messageSender;
        }

        public virtual void Send(string message)
        {
            MessageSender.SendMessage(message);
        }
    }
}

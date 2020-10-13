using System;

namespace DesignPatterns.Structural.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public ShortMessageAbstraction(IMessageSenderImplementation messageSender) : base(messageSender)
        {
        }

        public override void Send(string message)
        {
            base.Send(message.Substring(0, 10));
        }
    }
}

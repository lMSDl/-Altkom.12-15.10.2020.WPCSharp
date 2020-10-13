using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private INotification Notification { get; }

        protected BaseDecorator(INotification notification)
        {
            Notification = notification;
        }

        public void Send(string message)
        {
            Notification.Send(message);
            ExtraSend(message);
        }

        public abstract void ExtraSend(string message); 
    }
}

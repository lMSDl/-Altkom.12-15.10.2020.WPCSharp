using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class Unsubscribe : IDisposable
    {
        private Action _action;

        public Unsubscribe(Action action)
        {
            _action = action;
        }

        public void Dispose()
        {
            _action();
        }
    }
}

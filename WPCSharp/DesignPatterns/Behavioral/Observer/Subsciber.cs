using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Subsciber : IObserver<int>
    {
        private IDisposable _subscription;

        public void Subscribe(IObservable<int> publisher)
        {
            _subscription = publisher.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: Transmisja zakończona");
            _subscription.Dispose();
            _subscription = null;
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: Error: {error.Message}");
        }

        public abstract void OnNext(int value);
    }
}

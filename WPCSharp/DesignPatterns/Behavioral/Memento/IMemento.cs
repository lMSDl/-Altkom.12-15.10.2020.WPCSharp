using System;

namespace DesignPatterns.Behavioral.Memento
{
    public interface IMemento<T>
    {
        T State { get; }
        DateTime DateTime { get; }
    }
}

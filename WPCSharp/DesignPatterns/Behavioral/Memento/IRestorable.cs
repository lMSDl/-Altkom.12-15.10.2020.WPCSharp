using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Memento
{
    public interface IRestorable<T>
    {
        void Restore(T state);
    }
}

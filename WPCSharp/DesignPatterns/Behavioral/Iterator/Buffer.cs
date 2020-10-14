using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Buffer<T> : IEnumerable<T[]>
    {
        private IEnumerable<T> _eumerable;

        public Buffer(IEnumerable<T> eumerable)
        {
            _eumerable = eumerable;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            return new BufferIterator<T>(_eumerable);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

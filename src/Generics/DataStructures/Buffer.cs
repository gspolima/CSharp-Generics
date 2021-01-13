using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> queue = new Queue<T>();

        public bool IsEmpty => queue.Count == 0;

        public virtual T Read()
        {
            return queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            queue.Enqueue(value);
        }
    }
}

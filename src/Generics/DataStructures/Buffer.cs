using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Buffer<T> : IBuffer<T>
    {
        Queue<T> queue = new Queue<T>();

        public bool IsEmpty => queue.Count == 0;

        public T Read()
        {
            return queue.Dequeue();
        }

        public void Write(T value)
        {
            queue.Enqueue(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class CircularBuffer<T> : Buffer<T>
    {
        protected int capacity;

        public bool IsFull => queue.Count == this.capacity;

        public CircularBuffer(int capacity = 0)
        {
            this.capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (queue.Count > capacity)
            {
                queue.Dequeue();
            }
        }
    }
}

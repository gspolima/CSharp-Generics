using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class CircularBuffer<T>
    {
        private T[] buffer;
        private int start;
        private int end;

        public CircularBuffer() : this(capacity: 10)
        {
        }

        public CircularBuffer(int capacity)
        {
            this.buffer = new T[capacity + 1];
            this.start = 0;
            this.end = 0;
        }
        public void Write(T value)
        {
            buffer[end] = value;
            end = (end + 1) % buffer.Length;
            if (end == start)
            {
                start = (start + 1) % buffer.Length;
            }
        }

        public T Read()
        {
            var result = buffer[start];
            start = (start + 1) % buffer.Length;
            return result;
        }

        public int Capacity
        {
            get { return buffer.Length; }
        }

        public bool IsEmpty
        {
            get { return end == start; }
        }

        public bool IsFull
        {
            get { return (end + 1) % buffer.Length == start; }
        }
    }
}

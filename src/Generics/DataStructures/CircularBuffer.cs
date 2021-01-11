using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class CircularBuffer
    {
        private double[] _buffer;
        private int _start;
        private int _end;

        public CircularBuffer() : this(capacity: 10)
        {
        }

        public CircularBuffer(int capacity)
        {
            this._buffer = new double[capacity + 1];
            this._start = 0;
            this._end = 0;
        }
    }
}

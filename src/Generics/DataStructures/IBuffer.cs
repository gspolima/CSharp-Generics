using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }

        void Write(T value);

        IEnumerable<TOutput> AsEnumerableOf<TOutput>();

        T Read();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in queue)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<TOutput> AsEnumerableOf<TOutput>()
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in queue)
            {
                var result = converter.ConvertTo(item, typeof(TOutput));
                yield return (TOutput)result;
            }
        }
    }
}
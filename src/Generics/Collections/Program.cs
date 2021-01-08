using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            list.AddFirst(18);
            list.AddLast(21);

            var first = list.First;
            var last = list.Last;
            list.AddAfter(first, 19);
            list.AddBefore(last, 20);

            var node = list.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var listCapacity = -1;

            // don't hit Crtl F5
            while (true)
            {
                if (numbers.Capacity != listCapacity)
                {
                    listCapacity = numbers.Capacity;
                    Console.WriteLine(listCapacity);
                }
                numbers.Add(1);
            }
        }
    }
}

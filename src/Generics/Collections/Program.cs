using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<Employee>();
            queue.Enqueue(new Employee() { Name = "Ash" });
            queue.Enqueue(new Employee() { Name = "Judy" });
            queue.Enqueue(new Employee() { Name = "Joe" });

            while(queue.Count > 0 )
            {
                var employee = queue.Dequeue();
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine("----------");

            var stack = new Stack<Employee>();
            stack.Push(new Employee() { Name = "Ash" });
            stack.Push(new Employee() { Name = "Judy" });
            stack.Push(new Employee() { Name = "Joe" });

            while (stack.Count > 0)
            {
                var employee = stack.Pop();
                Console.WriteLine(employee.Name);
            }
        }
    }
}

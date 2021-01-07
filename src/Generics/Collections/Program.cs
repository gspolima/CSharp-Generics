using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueSetValueType = new HashSet<int>();
            uniqueSetValueType.Add(5);
            uniqueSetValueType.Add(12);
            uniqueSetValueType.Add(5);

            foreach (var item in uniqueSetValueType)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            var uniqueSet = new HashSet<Employee>();
            var employee = new Employee() { Name = "Mary Jane" };
            uniqueSet.Add(new Employee(){Name = "Gustavo"});
            uniqueSet.Add(employee);
            uniqueSet.Add(employee);

            foreach (var item in uniqueSet)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

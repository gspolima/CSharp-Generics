using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new DepartmentCollection();

            employeesByDepartment.Add("Software", new Employee() { Name = "Gustavo" })
                                 .Add("Software", new Employee() { Name = "Pedro" })
                                 .Add("Software", new Employee() { Name = "Antonio" });

            employeesByDepartment.Add("Legal", new Employee() { Name = "Mary" })
                                 .Add("Legal", new Employee() { Name = "Pedro" })
                                 .Add("Legal", new Employee() { Name = "Pedro" });

            foreach (var item in employeesByDepartment)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"{item.Key} department");
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"\t{employee.Name}");   
                }
            }
        }
    }
}
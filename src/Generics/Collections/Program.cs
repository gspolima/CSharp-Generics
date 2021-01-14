using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new SortedDictionary<string, SortedSet<Employee>>();

            employeesByDepartment.Add("Software", 
                new SortedSet<Employee>(new EmployeeComparer()) { 
                    new Employee() { DepartmentId = 2, Name = "Gustavo" } });

            employeesByDepartment["Software"].Add(
                new Employee() { DepartmentId = 2, Name = "Pedro" });

            employeesByDepartment["Software"].Add(
                new Employee() { DepartmentId = 2, Name = "Antonio" });

            employeesByDepartment.Add("Legal",
                new SortedSet<Employee>(new EmployeeComparer()) {
                    new Employee() { DepartmentId = 2, Name = "Mary" } });

            employeesByDepartment["Legal"].Add(
                new Employee() { DepartmentId = 2, Name = "Pedro" });

            employeesByDepartment["Legal"].Add(
                new Employee() { DepartmentId = 2, Name = "Pedro" });

            foreach (var item in employeesByDepartment)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"{item.Key} department");
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"\t{employee.Name}");   
                }
            }
        }
    }
}
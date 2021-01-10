using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = new Dictionary<string, List<Employee>>();

            employeesByDepartment.Add("Software", 
                new List<Employee>() { 
                    new Employee() { DepartmentId = 2, Name = "Gustavo" } });

            employeesByDepartment["Software"].Add(
                new Employee() { DepartmentId = 2, Name = "Pedro" });

            employeesByDepartment["Software"].Add(
                new Employee() { DepartmentId = 2, Name = "Antonio" });

            employeesByDepartment.Add("Legal",
                new List<Employee>() {
                    new Employee() { DepartmentId = 2, Name = "Mary" } });

            foreach (var item in employeesByDepartment)
            {
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(
                        $"Department : {item.Key}" +
                        $"{Environment.NewLine}{"Employee", -10} : {employee.Name}" +
                        $"{Environment.NewLine}-----------------------");
                }
            }
        }
    }
}
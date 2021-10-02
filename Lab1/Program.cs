using Lab1.Extensions;
using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Architect architect = new Architect();
            List<Employee> employeeList = new List<Employee>();
            employeeList.AddRange(new Employee[] { manager, architect });
            foreach(Employee employee in employeeList)
            {
                Console.WriteLine(employee.Salutation());
                Console.WriteLine(employee.Salutation().WordCount());
            }
        }
    }
}

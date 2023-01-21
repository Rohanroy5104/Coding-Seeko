﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploDelegate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            emplist.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            Employee.PromoteEmployee(emplist);
        }
    }
}
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + "Promoted");
                Console.ReadLine();
                }
            }
        }
    }
  

        
    
        
    


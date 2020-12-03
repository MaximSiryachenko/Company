using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public abstract class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }

        public decimal Experience { get; set; }

        public Employee(string surname, string name, string middleName, decimal experience)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Experience = experience;
        }

        public abstract void Work();

        public static List<Employee> operator +(List<Employee> listEmployees, Employee employee)
        {
            listEmployees.Add(employee);
            return listEmployees;
        }

        public static List<Employee> operator -(List<Employee> listEmployees, Employee employee)
        {
            listEmployees.Remove(employee);
            return listEmployees;
        }
    }
}

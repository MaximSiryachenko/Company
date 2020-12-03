using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    /// <summary>
    /// The class represents general information about employees, common to all types
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Auto property for employee surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Auto property for employee name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Auto property for employee middle name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Auto property for employee experience
        /// </summary>
        public decimal Experience { get; set; }

        public Employee(string surname, string name, string middleName, decimal experience)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Experience = experience;
        }

        /// <summary>
        /// This method does specific work for each employee type and must be override in child classes
        /// </summary>
        public abstract void Work();

        /// <summary>
        /// The method overloads the + operator to add employees to the list
        /// </summary>
        public static List<Employee> operator +(List<Employee> listEmployees, Employee employee)
        {
            listEmployees.Add(employee);
            return listEmployees;
        }

        /// <summary>
        /// The method overloads the operator - to remove employees from the list
        /// </summary>
        public static List<Employee> operator -(List<Employee> listEmployees, Employee employee)
        {
            listEmployees.Remove(employee);
            return listEmployees;
        }
    }
}

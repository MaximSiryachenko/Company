using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Company
{
    /// <summary>
    /// The class represents a firm and contains information about her employees
    /// </summary>
    public class Firm
    {
        /// <summary>
        /// List of company employees of all types
        /// </summary>
        public List<Employee> Employees = new List<Employee>();
    }

    /// <summary>
    /// The class extends the functionality of the Firm class using LINQ
    /// </summary>
    public static class FirmExtension
    {
        /// <summary>
        ///  This method checks if the employee is on the list
        /// </summary>
        public static bool CheckEmployee(Firm firm, Employee employee)
        {
            return firm.Employees.Contains(employee);
        }

        /// <summary>
        /// This method returns a list of employees of a specific type
        /// </summary>
        public static List<Employee> GetEmployees<T>(this Firm firm)
        {
            List<Employee> emps = firm.Employees.Where(e => e.GetType() == typeof(T)).ToList();
            return emps;
        }

        /// <summary>
        /// This method returns the number of employees of a specific type
        /// </summary>
        public static int GetCountEmployees<T>(Firm firm)
        {
            return firm.Employees.Count(e => e.GetType() == typeof(T));
        }

        /// <summary>
        /// This method outputs to the console of a certain type of employees
        /// </summary>
        public static void PrintEmployees<T>(this Firm firm)
        {
            var employees = firm.GetEmployees<T>();

            foreach (var i in employees) 
            {
                Console.WriteLine(i.Surname + " " + i.Name + " " + i.MiddleName);
                Console.WriteLine("Experience: " + i.Experience);
            }
        }
    }
}

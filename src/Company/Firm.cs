using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Company
{

    public class Firm
    {
        public List<Employee> Employees = new List<Employee>();
    }

    public static class FirmExtencion
    {
        public static bool CheckEmployee(this Firm firm, Employee employee)
        {
            return firm.Employees.Contains(employee);
        }

        public static List<Employee> GetEmployees<T>(this Firm firm)
        {
            var emp = firm.Employees.Where(e => e.GetType() == typeof(T));
            List<Employee> emps = new List<Employee>();
            foreach (var e in emp)
                emps.Add(e);
            return emps;
        }
        public static int GetCountEmployees<T>(this Firm firm)
        {
            return firm.Employees.Count(e => e.GetType() == typeof(T));
        }

        public static void PrintEmployees<T>(this Firm firm)
        {
            var employees = GetEmployees<T>(firm);

            foreach (var i in employees) 
            {
                Console.WriteLine(i.Surname + " " + i.Name + " " + i.MiddleName);
                Console.WriteLine("Experience: " + i.Experience);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Employees
{
    /// <summary>
    /// A class representing information about a foreman. Inherited from Employee
    /// </summary>
    public class Foreman : Employee
    {
        public Foreman(string surname, string name, string middleName, decimal experience)
            : base(surname, name, middleName, experience)
        {
        }

        /// <summary>
        /// Overridden method for employee doing work
        /// </summary>
        public override void Work()
        {
            Console.WriteLine("Materials purchased");
        }

        /// <summary>
        /// A method that checks employees by a foreman
        /// </summary>
        public void CheckWorkers()
        {
            Console.WriteLine("Workers check completed");
        }


    }
}

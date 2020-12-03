using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Employees
{
    /// <summary>
    /// A class representing information about a worker. Inherited from Employee
    /// </summary>
    public class Worker : Employee
    {
        public Worker(string surname, string name, string middleName, decimal experience) 
            :base(surname, name, middleName, experience)
        {
        }

        /// <summary>
        /// Overridden method for employee doing work
        /// </summary>
        public override void Work()
        {
            Console.WriteLine("A batch of products released");
        }
    }
}

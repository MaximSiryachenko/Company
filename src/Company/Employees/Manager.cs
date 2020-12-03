using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Employees
{
    /// <summary>
    /// A class representing information about a manager. Inherited from Employee
    /// </summary>
    public class Manager : Employee
    {
        public Manager(string surname, string name, string middleName, decimal experience)
            : base(surname, name, middleName, experience)
        {
        }

        /// <summary>
        /// Overridden method for employee doing work
        /// </summary>
        public override void Work()
        {
            Console.WriteLine("Order collected");
        }

        /// <summary>
        /// Method that allows the manager to issue a task
        /// </summary>
        public void IssueTask()
        {
            Console.WriteLine("The task has been issued");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Employees
{
    public class Manager : Employee
    {
        public Manager(string surname, string name, string middleName, decimal experience)
            : base(surname, name, middleName, experience)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Order collected");
        }

        public void IssueTask()
        {
            Console.WriteLine("The task has been issued");
        }

    }
}

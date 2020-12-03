using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Employees
{
    public class Foreman : Employee
    {
        public Foreman(string surname, string name, string middleName, decimal experience)
            : base(surname, name, middleName, experience)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Materials purchased");
        }

        public void CheckWorkers()
        {
            Console.WriteLine("Workers check completed");
        }


    }
}

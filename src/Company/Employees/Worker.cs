using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Employees
{
    public class Worker : Employee
    {
        //private string Surname;
        //private string Name;
        //private string MiddleName;

        //private decimal Experience;

        //public override string Surname
        //{
        //    get { return surname; }
        //    set { surname = value;  }
        //}

        //public override string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //public override string MiddleName
        //{
        //    get { return middleName; }
        //    set { middleName = value; }
        //}

        //public override decimal Experience
        //{
        //    get { return experience; }
        //    set { experience = value; }
        //}

        public Worker(string surname, string name, string middleName, decimal experience) 
            :base(surname, name, middleName, experience)
        {
        }

        public override void Work()
        {
            Console.WriteLine("A batch of products released");
        }
    }
}

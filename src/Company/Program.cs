using Company.Employees;
using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm firm = new Firm();

            firm.Employees += new Worker("Loboda", "Anatoly", "Sergiovich", 2);
            firm.Employees += new Worker("Petrov", "Petr", "Petrovich", 3);
            firm.Employees += new Manager("Muravlov", "Roman", "Oleksiovich", 8);
            firm.Employees += new Foreman("Sergienko", "Sergei", "Sergeevich", 5);
            firm.Employees -= firm.Employees[1];
            firm.Employees += new Foreman("Stadnik", "Mihailo", "Nikolaevich", 4);

            Console.WriteLine("PrintEmployees Check: \n\nForeman:");
            FirmExtension.PrintEmployees<Foreman>(firm);
            Console.WriteLine("\nWorker:");
            FirmExtension.PrintEmployees<Worker>(firm);
            Console.WriteLine("\n\nCheckEmployee Check (True, False):");
            Console.WriteLine(FirmExtension.CheckEmployee(firm, firm.Employees[2]));
            Console.WriteLine(FirmExtension.CheckEmployee(firm, new Worker("Petrov", "Petr", "Petrovich", 3)));
            Console.WriteLine("\nGetCountEmployees<Foreman> Check (2):");
            Console.WriteLine(FirmExtension.GetCountEmployees<Foreman>(firm));

        }
    }
}

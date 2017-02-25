using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.AskUserForPerson1NameAndAge();
            p1.CreateSpouse();

            Person p2 = new Person();
            p2.AskUserForPerson2NameAndAge();
            p2.CreateSpouse();

            System.Console.WriteLine(" ");
            System.Console.WriteLine("THE TWO COUPLES:");
            System.Console.WriteLine("Couple 1:");
            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            System.Console.WriteLine("Couple 2:");
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}

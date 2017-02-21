using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2inprogress
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.AskUserForNameAndAgeP1();
            P1.CreateSpouseIfMarried();

            Person P2 = new Person();
            P2.AskUserForNameAndAgeP2();
            P2.CreateSpouseIfMarried();

            P1.PrintNameAndAge();
            P1.Spouse.PrintNameAndAge();
            P2.PrintNameAndAge();
            P2.Spouse.PrintNameAndAge();
            System.Console.WriteLine(" Average Age: " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}

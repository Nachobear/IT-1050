using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static int Count;
        public static int SumOfAllAges;

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.Count;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }

        public void AskUserForPerson1NameAndAge()
        {
            System.Console.Write("What is person 1's first name?");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("What is person 1's last name?");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("What is person 1's age?");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += this.Age;
        }

        public void AskUserForPerson2NameAndAge()
        {
            System.Console.Write("What is person 2's first name?");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("What is person 2's last name?");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("What is person 2's age?");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += this.Age;
        }

        public void AskUserForSpouseNameAndAge()
        {
            System.Console.Write("What is their spouse's first name?");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("What is their spouse's age?");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += this.Age;
        }

        public void CreateSpouse()
        {
            this.Spouse = new Person();
            this.Spouse.AskUserForSpouseNameAndAge();
            this.Spouse.Spouse = this;
            this.Spouse.LastName = this.LastName;
        }
    }
}

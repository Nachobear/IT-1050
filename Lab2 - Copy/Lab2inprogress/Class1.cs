using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2inprogress
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static int Count;

        public static double SumOfAllAges;
        public static double AverageAge()
        {
            return (double)SumOfAllAges / (double)Person.Count;
        }

        public string GetFullName()
        {
            string fullname = " " + FirstName + " " + LastName;
            return fullname;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(" " + FirstName + " " + LastName + " is " + Age + " years old.");
        }

        public void AskUserForNameAndAgeP1()
        {
            System.Console.WriteLine("What is person1's first name?");
            FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is person1's last name?");
            LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is person1's age?");
            Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += Age;
        }

        public void AskUserForNameAndAgeP2()
        {
            System.Console.WriteLine("What is person2's first name?");
            FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is person2's last name?");
            LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is person2's age?");
            Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += Age;
        }

        public void AskUserForNameAndAgeSpouse()
        {
            System.Console.WriteLine("What is their spouse's first name?");
            FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is their spouse's last name?");
            LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is their spouse's age?");
            Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += Age;
        }

        public void CreateSpouseIfMarried()
        {
            System.Console.WriteLine("Are they married? (y/n)");
            if(System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                Spouse = new Person();
                Spouse.AskUserForNameAndAgeSpouse();
                Spouse.Spouse = this;
            }
        }
    }
}

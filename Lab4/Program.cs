using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("the movie is playing during evening hours? (6pm-2am) (answer true/false)");
            bool isEveningShowing = bool.Parse(System.Console.ReadLine());

            System.Console.WriteLine("how many child tickets will you buy? (12 or under is considered child)");
            int numberOfChildTickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("how many adult tickets will you buy? (13-54 is considered adult)");
            int numberOfAdultTickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("how many senior tickets will you buy? (55 or over is considered senior)");
            int numberOfSeniorTickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("sodas come in two sizes: large and small");
            System.Console.WriteLine("how many small sodas will you buy? ($3.50)");
            int numberOfSSodas = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how many large sodas will you buy? ($5.99)");
            int numberOfLSodas = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how many hotdogs will you buy? ($3.99)");
            int numberOfHotdogs = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how many popcorns will you buy? ($4.50)");
            int numberOfPopcorns = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how many candies will you buy? ($1.99)");
            int numberOfCandies = int.Parse(System.Console.ReadLine());

            double ticketTotal = 0;

            if (isEveningShowing == false)
            {
                ticketTotal += (numberOfChildTickets * 3.99 + numberOfAdultTickets * 5.99 + numberOfSeniorTickets * 4.50);
            }
            else if (isEveningShowing == true)
            {
                ticketTotal += (numberOfChildTickets * 6.99 + numberOfAdultTickets * 10.99 + numberOfSeniorTickets * 8.50);
            }
            else
            {
                System.Console.WriteLine("invalid input");
            }
            
            double concessionsTotal = (numberOfSSodas * 3.50 + numberOfLSodas * 5.99 + numberOfHotdogs * 3.99 + numberOfPopcorns * 4.50 + numberOfCandies * 1.99);
            
            double totalPrice = (ticketTotal + concessionsTotal);
            
            /////////////////DISCOUNTS/////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            if ((numberOfPopcorns >= 1) && (numberOfLSodas >= 1) && ((numberOfChildTickets + numberOfAdultTickets + numberOfSeniorTickets) >= 1))
            {
                totalPrice -= 2.00;
            }

            if ((numberOfPopcorns >= 1) && ((numberOfChildTickets + numberOfAdultTickets + numberOfSeniorTickets) >= 3) && (isEveningShowing == true))
            {
                totalPrice -= 4.50;
            }

            int numberOfCandyDiscounts = numberOfCandies / 4;
            totalPrice -= (numberOfCandyDiscounts * 1.99);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            System.Console.WriteLine("The total price for the evening is $" + totalPrice);

            System.Console.ReadKey();

            
        }
    }
}

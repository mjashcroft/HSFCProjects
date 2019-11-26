using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = "";

            Console.WriteLine("What is the month you have chosen?: ");
            month = (Console.ReadLine());

            if (month == "February")
            Console.WriteLine("28 days");

            if (month == "September" | month == "April" | month == "June" | month == "November")
            Console.WriteLine("30 days");

            if (month == "January" | month == "March" | month == "May" | month == "July" | month == "August" | month == "October" | month == "December")
            Console.WriteLine("31 days");

            Console.ReadLine();
        }
    }
}

using System;

namespace monthNumToName2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 0;

            Console.WriteLine("What is the number of the month, between 1 and 12: ");
            month = Convert.ToInt32 (Console.ReadLine());

            if (month == 1)
            Console.WriteLine("January");
            Console.ReadLine();

            if (month == 2)
            Console.WriteLine("February");
            Console.ReadLine();

            if (month == 3)
            Console.WriteLine("March");
            Console.ReadLine();

            if (month == 4)
            Console.WriteLine("April");
            Console.ReadLine();

            if (month == 5)
            Console.WriteLine("May");
            Console.ReadLine();

            if (month == 6)
            Console.WriteLine("June");
            Console.ReadLine();

            if (month == 7)
            Console.WriteLine("July");
            Console.ReadLine();

            if (month == 8)
            Console.WriteLine("August");
            Console.ReadLine();

            if (month == 9)
            Console.WriteLine("September");
            Console.ReadLine();

            if (month == 10)
            Console.WriteLine("October");
            Console.ReadLine();

            if (month == 11)
            Console.WriteLine("November");
            Console.ReadLine();

            if (month == 12)
            Console.WriteLine("December");
            Console.ReadLine();

            if (month != 1 | month != 2 | month != 3 | month != 4 | month != 5 | month != 6 | month != 7 | month != 8 | month != 9 | month != 10 | month != 11 | month != 12);
            Console.WriteLine("Please enter a number between 1 and 12");
        }
    }
}

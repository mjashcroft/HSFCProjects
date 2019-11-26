using System;

namespace personProject
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();

            p1.GetName(Console.ReadLine());

            p1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(p1.GetName() + " is aged " + p1.GetAge());
        }
    }
}

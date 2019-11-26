using System;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ListProject myList = new ListProject();

            Console.WriteLine("Enter five names, one per line");
            for (int i = 0; i < 5; i++)
            {
                myList.AddNameToList(Console.ReadLine());
            }
            Console.WriteLine("Results are " + myList.GetListAsString());
            Console.ReadLine();
        }
    }
}

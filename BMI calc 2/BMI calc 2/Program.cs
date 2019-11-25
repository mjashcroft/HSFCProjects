using System;

namespace BMI_calc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double height = 0;
            double weight = 0;
            double BMI = 0;

            Console.WriteLine("What is your name ? :");
            name = (Console.ReadLine());

            Console.WriteLine("Please enter your height in metres: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());

            BMI = Convert.ToDouble(weight / (height * height));

            Console.WriteLine(name + " your BMI is " + BMI);
            Console.ReadLine();

        }
    }
}

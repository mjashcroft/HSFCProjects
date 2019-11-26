using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int intCounter = 0;
            int intGuess;
            int intNumber;
            intNumber = rnd.Next(0, 11);

            do
            {
                Console.WriteLine("Enter your guess between 1 and 10 ");
                intGuess = Convert.ToInt32(Console.ReadLine());

                intCounter = intCounter + 1;

                if (intGuess > intNumber)
                {
                    Console.WriteLine("Too high");
                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("Too low");
                }
                if (intGuess == intNumber)
                {
                    Console.WriteLine("You got it in " + intCounter + " guesses!");
                }
            } while (intGuess != intNumber);
            Console.ReadLine();
        }
    }
}

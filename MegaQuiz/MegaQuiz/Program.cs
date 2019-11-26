using System;

namespace MegaQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string name = "";
            int score = 0;
            int Q_one_A = rnd.Next(0, 101);
            int Q_one_B = rnd.Next(0, 101);
            int Q_one_Ans = (Q_one_A + Q_one_B);
            int Q_one;

            int Q_two_A = rnd.Next(2, 11);
            int Q_two_B = rnd.Next(2, 11);
            int Q_two_Ans = (Q_two_A * Q_two_B);
            int Q_two;

            int Q_three_A = rnd.Next(2, 11);
            int Q_three_B = rnd.Next(2, 11);
            int Q_three_Ans = (Q_three_A - Q_three_B);
            int Q_three;

            int Q_four_A = rnd.Next(1, 51);
            int Q_four_B = rnd.Next(1, 11);
            int Q_four_Ans = (Q_four_A / Q_four_B);
            int Q_four;

            int Q_five_A = rnd.Next(1, 51);
            int Q_five_B = rnd.Next(1, 11);
            int Q_five_Ans = (Q_five_A % Q_five_B);
            int Q_five;

            int choice;

            void one() //addition
            {
                Console.WriteLine("Question 1");
                Console.WriteLine("What is " + Q_one_A + " + " + Q_one_B + "?");
                Q_one = Convert.ToInt32(Console.ReadLine());

                if (Q_one == Q_one_Ans)
                    Console.WriteLine("Correct");
                if (Q_one == Q_one_Ans)
                    score = (score = +1);

                else Console.WriteLine("Incorrect");
            }

            void two() //multiplication
            {
                Console.WriteLine("Question 2");
                Console.WriteLine("What is " + Q_two_A + " x " + Q_two_B + "?");
                Q_two = Convert.ToInt32(Console.ReadLine());


                if (Q_two == Q_two_Ans)
                    Console.WriteLine("Correct");
                if (Q_two == Q_two_Ans)
                    score = (score + 1);

                else Console.WriteLine("Incorrect");
            }

            void three() //subtraction
            {
                Console.WriteLine("Question 3");
                Console.WriteLine("What is " + Q_three_A + " - " + Q_three_B + "?");
                Q_three = Convert.ToInt32(Console.ReadLine());

                if (Q_three == Q_three_Ans)
                    Console.WriteLine("Correct");
                if (Q_three == Q_three_Ans)
                    score = (score + 1);

                else Console.WriteLine("Incorrect");
            }
            void four() //DIV
            {
                Console.WriteLine("Question 4");
                Console.WriteLine("What is " + Q_four_A + " / (DIV) " + Q_four_B + "?");
                Q_four = Convert.ToInt32(Console.ReadLine());

                if (Q_four == Q_four_Ans)
                    Console.WriteLine("Correct");
                if (Q_four == Q_four_Ans)
                    score = (score + 1);

                else Console.WriteLine("Incorrect");
            }

            void five() //MOD
            {
                Console.WriteLine("Question 5");
                Console.WriteLine("What is " + Q_five_A + " % (MOD) " + Q_five_B + "?");
                Q_five = Convert.ToInt32(Console.ReadLine());

                if (Q_five == Q_five_Ans)
                    Console.WriteLine("Correct");
                if (Q_five == Q_five_Ans)
                    score = (score + 1);

                else Console.WriteLine("Incorrect");
            }

            // main program starts here

            Console.WriteLine("What is your name? :");
            name = (Console.ReadLine());

            Console.WriteLine("Hello " + name + ", and welcome to the maths mega quiz");

            Console.WriteLine("What would you like to do now? ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Subtraction");
            Console.WriteLine("4. DIV");
            Console.WriteLine("5. MOD");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) 
            {
                one();
            }

            else if (choice == 2) 
            {
                two();
            }

            else if (choice == 3) 
            {
                three();
            }

            else if (choice == 4) 
            {
                four();
            }

            else if (choice == 5) 
            {
                five();
            }

           
            Console.WriteLine("Your score is " + score + " out of 5");
            Console.ReadLine();
        
        }
    }
}
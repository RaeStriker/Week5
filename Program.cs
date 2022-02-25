using System;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemThree();
            ProblemFive();
        }

        static void ProblemOne()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i / 3) == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        static void ProblemThree()
        {
            int UI = 0;
            int total = 1;

            Console.WriteLine("Enter a number: ");
            UI = Int32.Parse(Console.ReadLine());

            for (int c = UI; c >= 1; c--)
            {
                total = total * c;
            }

            Console.WriteLine(UI + "! = " + total);
        }

        static void ProblemFive()
        {
            string userInput;
            int highest = 0;

            Console.WriteLine("Enter a series of numbers seperated by commas: ");
            userInput = Console.ReadLine();

            for (int c = 0; c < userInput.Length; c++)
            {
                int number = 0;
                if (int.TryParse(userInput.Substring(c,1), out number) )
                {
                    if (Int32.Parse(userInput.Substring(c, 1)) > highest)
                        highest = Int32.Parse(userInput.Substring(c, 1));
                }
            }

            Console.WriteLine("The highest number is: " + highest);
        }
    }
}

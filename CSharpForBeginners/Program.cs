using System;
using System.Linq;

namespace CSharpFundamentals
{

    class Program
    {


        public static int GetMax(int firstNumber, int secondNumber) 
        {
           if (firstNumber > secondNumber)
            {
                return firstNumber;
            } else if (secondNumber > firstNumber)
            {
                return secondNumber;
            }
            else
            {
                throw new Exception("Not a number!");
            }
        }

        public static int GetDimensions(string landscape, int portrait)
        {
            string ladnscapeValue = "You have chosen landscape.";
            string portraitValue = "You have chosen portrait.";

            if (string.Equals(portrait, landscape))
            {
                return int.Parse(ladnscapeValue);
            }
            else if (portrait > landscape)
            {
                return int.Parse(portraitValue);
            }
            else
            {
                throw new Exception("That is not a number");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 - 10.");
            var userInput = Int32.Parse(Console.ReadLine());
            if (userInput > 1 && userInput < 10)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.WriteLine("Please enter your first number.");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The greatest of your two numbers are: " + GetMax(firstNumber, secondNumber));

            Console.WriteLine("Please enter a width.");
            var landscape = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a height");
            var portrait = int.Parse(Console.ReadLine());

            Console.WriteLine("The dimensions you have chosen are "  + GetDimensions(landscape, portrait));
        }
    }
}
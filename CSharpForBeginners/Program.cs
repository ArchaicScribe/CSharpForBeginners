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

       /* public static string GetDimensions(int landscape, int portrait)
        {
            if (string.Equals(portrait, landscape))
            {
                Console.WriteLine($"{landscape} is greater than {portrait} you have chosen landscape.");
            }
            else
            {
                Console.WriteLine($"{portrait} is greater than {landscape} you have chosen portrait.");
            } else
            {
                return ("Please enter a new number");
            }
        */
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number between 1 - 10.");
            //var userInput = Int32.Parse(Console.ReadLine());
            //if (userInput > 1 && userInput < 10)
            //{
            //    Console.WriteLine("Valid!");
            //}
            //else
            //{
            //    Console.WriteLine("Not Valid");
            //}
            //Console.WriteLine("Please enter your first number.");
            //var firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter your second number.");
            //var secondNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("The greatest of your two numbers are: " + GetMax(firstNumber, secondNumber));

            //Console.WriteLine("Please enter a width.");
            //var landscape = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter a height");
            //var portrait = int.Parse(Console.ReadLine());

            //var name = "John Smith";
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //Console.WriteLine("The dimensions you have chosen are "  + GetDimensions(landscape, portrait));


            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach(var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //var i = 0;
            //while(i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}
            while (true)
            {
                Console.Write("Type your name: ");
                var userinput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userinput))
                {
                    Console.WriteLine("@Echo: " + userinput);
                    continue; 
                }
                break;
            }

        }
    }
}
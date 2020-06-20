using CSharpForBeginners;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpFundamentals
{

    class UsersInput
    {


        public static void Main(string[] args)
        {

        }

        public static void UserInput(int a, int b)
        {
            Console.WriteLine("Please enter a number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            var largerNumber = Math.Max(a, b);
            Console.WriteLine("Your largest number is: " + largerNumber);
        }
        public static void NumberChecker()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

    }
}


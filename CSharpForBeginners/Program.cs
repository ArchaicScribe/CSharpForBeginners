using CSharpForBeginners;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{

    class Program
    {


        public static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Please enter a number (or 'Quit' to exit): ");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(userInput));
            }
            
            Console.WriteLine("Unique numbers:");
            foreach(var number in RetrieveUniqueNums(numbers))
            {
                Console.WriteLine(number);
            }
        }
        public static List<int> RetrieveUniqueNums(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            return uniques;
        }
        
    }
}


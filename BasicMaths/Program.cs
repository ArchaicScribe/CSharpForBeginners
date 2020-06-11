using System;

namespace BasicMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter(63);
            
            
            SecondCounter(97);
            
        }

        public static void Counter(int number)
        {
           
            var remainder = number % 4;
            Console.WriteLine(remainder);
        }

        public static void SecondCounter(int number)
        {
           
            var secondResult = number % 4;
            Console.WriteLine(secondResult);

        }
    }
}

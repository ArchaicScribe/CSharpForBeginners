using CSharpForBeginners;
using System;
using System.Text;

namespace CSharpFundamentals
{

    class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            var userName = Console.ReadLine();

            var nameArray = new char[userName.Length];
            for(var i = userName.Length; i > 0; i--)
            {
                nameArray[userName.Length - 1] = userName[i - 1];
            }
            var reversedName = new string(nameArray);
            Console.WriteLine("Your name reversed is: " + reversedName);
        }
        
    }
}


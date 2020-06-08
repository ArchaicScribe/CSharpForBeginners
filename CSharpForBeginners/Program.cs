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
            var reversedName = NameReversed(userName);
            Console.WriteLine("Your name reversed is: " + reversedName);
        }

        public static string NameReversed(string userName)
        {
            var nameArray = new char[userName.Length];
            for (var i = userName.Length; i > 0; i--)
            {
                nameArray[userName.Length - 1] = userName[i - 1];
            }
           return new string(nameArray);
        }
        
    }
}


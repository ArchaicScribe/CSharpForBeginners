using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace CSharpFundamentals
{

    class Program
    {


        public static void Main(string[] args)
        {
            var fullName = "Alex Rauenzahn  ";
            Console.WriteLine("Trim: '{0}'" , fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'" , fullName.ToUpper().Trim());

            var indexFN = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, indexFN);
            var lastName = fullName.Substring(indexFN + 1);
            Console.WriteLine("First name is: " + firstName);
            Console.WriteLine("Last name is: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name is: " + names[0]);
            Console.WriteLine("Last name is: " + names[1]);


            Console.WriteLine( fullName.Replace("Alex", "Alexander"));
            fullName.Replace('e', 'E');
            fullName.Replace(' ', 'E');

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }


            var userAge = "25";
            var age = Convert.ToByte(userAge);
            Console.WriteLine(age);

            float price = 29.95f;
            var fullprice = price.ToString("C0");
            Console.WriteLine(fullprice);
        }
    }
}


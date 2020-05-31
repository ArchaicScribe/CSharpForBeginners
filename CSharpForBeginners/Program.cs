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
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.Add(1);
            numbers.AddRange(new int[8] {4536425,45556, 1231547,3, 54122, 52, 1, 1245});

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("The Index of 3 is: " + numbers.IndexOf(3));
            Console.WriteLine("The Last Index of 3 is: " + numbers.LastIndexOf(3));

            Console.WriteLine("Count: " + numbers.Count);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);


            for (int i = 0; i < numbers.Count; i++){
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
           


            numbers.Remove(3);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Removes ranges, starting at Index [3]. This is the result.");
            numbers.RemoveRange(3, 4);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //int a = default(int);
            //Console.WriteLine("The value of a is: " + a);

            //var numbers = new [] { 3, 7, 9, 2, 14, 6 };

            ////Length
            //Console.WriteLine("Length of the array is: " + numbers.Length);

            ////IndexOF
            //var index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("The index of 9 is: " + index);

            ////Clear Method
            //Array.Clear(numbers, 0, 2);
            //Console.WriteLine("This is the effect of the Clear()");
            //foreach(var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            ////Copy()
            //int[] otherArray = new int[3];
            //Array.Copy(numbers, otherArray, 3);

            //Console.WriteLine("The effect of Copy()");
            //foreach (var n  in otherArray)
            //{
            //    Console.WriteLine(n);
            //}

            ////Sort()
            //Array.Sort(numbers);

            //Console.WriteLine("This is an example of the Sort()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            ////Reverse
            //Array.Reverse(numbers);

            //Console.WriteLine("This is an example of the Reverse()");
            //foreach(var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

        }
        //public static bool DivByThree(int a, int b)
        //{
        //    int[] numbersArray = Enumerable.Range(1, 100).ToArray();
        //    for (int i = 0; i < 100 / 3; i++)
        //    {
        //        if (i / 3 == 0)
        //        {
        //            Console.WriteLine(i);
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}


//var random = new Random();
//const int passwordLength = 10;
//var buffer = new char[passwordLength];
//for(var i = 0; i < passwordLength; i++)
//{
//    buffer[i]  = (char)('a' + random.Next(0, 26));

//    var password = new string(buffer);
//    Console.WriteLine(password);
//}


//public static int GetMax(int firstNumber, int secondNumber) 
//{
//   if (firstNumber > secondNumber)
//    {
//        return firstNumber;
//    } else if (secondNumber > firstNumber)
//    {
//        return secondNumber;
//    }
//    else
//    {
//        throw new Exception("Not a number!");
//    }
//}

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
//while (true)
//{
//    Console.Write("Type your name: ");
//    var userinput = Console.ReadLine();

//    if (!String.IsNullOrWhiteSpace(userinput))
//    {
//        Console.WriteLine("@Echo: " + userinput);
//        continue; 
//    }
//    break;
//}


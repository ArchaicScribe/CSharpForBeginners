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
            //Creating timeSpan obejcts
            var timeSpan = new TimeSpan(1, 2, 6);


            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(3);
            var duration = start - end;
            Console.WriteLine("Duration: " +  duration);


            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add     
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(10)));


            //Subrtract 
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromHours(1)));

            //ToString
            Console.WriteLine("ToString " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:34"));
        
        }
    }
}


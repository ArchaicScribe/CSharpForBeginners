using CSharpForBeginners;
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
            var sentence = "This is going to be a really really really really really really really long text";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);

                }
        
    }
}


using CSharpForBeginners;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpFundamentals
{

    class Program
    {


        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\te4mp\folder1");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}


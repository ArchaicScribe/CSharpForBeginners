using System;
using System.Linq;

namespace CrackingTheCI
{
    class Program
    {

        static void Main(string[] args)
        {
            int chiffrebase = 32;
            int[] test123 = new int[] { 12, 32, 33, 64, 75, 46, 42, 32 };
            int occurrences = test123.Count(i => i == chiffrebase);
            Console.WriteLine(occurrences);
           

        }
        public int nbOccurrences(int[] base1, int n)
        {
            int count = 0;
            foreach (int i in base1)
            {
                if (n == 32)
                {
                    count++;
                }
            }
            return count;
        }
        public int Sum(int n)
        {
            if(n <= 0){
                return 0;
            }
            else
            {
                return n + Sum(n - 1);
            }
        }
        public int pairSumSequences(int n)
        {
            int sum = 0;
            for(int i =0; i < n; i++)
            {
                sum += pairSum(i, i + 1);
            }
            return sum;
        }
        int pairSum(int a, int b)
        {
            return a + b;
        }
    }
}

using System;


namespace BasicMaths
{
    class Program
    {
        public static void Main(string[] args)
        {
            var setValue = 63;
            Random random = new Random();
            int randomValue = random.Next(1,100);
            var players = 4;
            var offset = 1;
            
            

            Console.WriteLine("The set value is " + setValue);
            Console.WriteLine("The starting player is: " + SelectStartingPlayer(setValue, players, offset) + " Congrats.");
            Console.WriteLine("The next player, selected at random is: " + randomValue);
            Console.WriteLine("That player is player: " + SelectStartingPlayer(setValue, players, offset) + " Congrats.");
            Console.WriteLine(ExponentialPower(2, 24));
            Console.WriteLine(ExponentialPower(2.5, 2));
            Console.WriteLine(ExponentialPower(3.5, 2));
        }
        private static int SelectStartingPlayer(int setValue, int players, int offset)
        {
            return (setValue % players) + offset;
        }

        public static double ExponentialPower(double baseNumber, double exponent)
        {
            double result = Math.Pow(baseNumber, exponent);

            return result;


        }


    }
}

using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int goldValue = 10;
            int silverValue = 5;
            int bronzeValue = 1 ; 
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string totalAsString = Console.ReadLine();
            
            if (double.TryParse(totalAsString, out double amount))
            {
                int goldCoins = (int)(amount / goldValue);
                double remainingAmount = (int)(amount % goldValue);
                double silverCoins = Math.Floor(remainingAmount / silverValue);
                double bronzeCoins = (int)((remainingAmount-silverCoins*5) / bronzeValue);

                Console.WriteLine($"{amount} cents is equal to:");
                Console.WriteLine($"{goldCoins} gold coins");
                Console.WriteLine($"{silverCoins} silver coins");
                Console.WriteLine($"{bronzeCoins} Bronze coins");

            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}

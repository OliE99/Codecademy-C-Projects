using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      // Ask user to enter an amount to convert
      Console.WriteLine("Enter an amount to convert to coins:");
      string amount = Console.ReadLine();
      double userAmount = Convert.ToDouble(amount);
      Console.WriteLine($"{amount} is equal to...");

      // Coin values
      int goldValue = 10;
      int silverValue = 5;

      // Calculate the change
      double goldCoins = Math.Floor(userAmount / goldValue);
      double remainder = userAmount % goldValue;

      double silverCoins = Math.Floor(remainder / silverValue);
      remainder = remainder % silverValue;

      // Print out coins
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}


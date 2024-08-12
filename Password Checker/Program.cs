using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 10;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&*-_+";

      int score = 0;

      Console.WriteLine("Please enter a password: ");

      string password = Console.ReadLine();

      if (password.Length >= minLength) {
        score++;
      } 
      if (Tools.Contains(password, uppercase)) {
        score++;
      } 
      if (Tools.Contains(password, lowercase)) {
        score++;
      } 
      if (Tools.Contains(password, digits)) {
        score++;
      } 
      if (Tools.Contains(password, specialChars)) {
        score++;
      }

      Console.WriteLine(score);

      switch (score) {
        case 5:
        case 4:
          Console.WriteLine("the password is extremely strong.");
          break;
        case 3:
          Console.WriteLine("the password is strong.");
          break;
        case 2: 
          Console.WriteLine("the password is medium.");
          break;
        case 1:
          Console.WriteLine("the password is weak.");
          break;
        default:
          Console.WriteLine("the password did not meet any of the standards.");
          break;
      }

    }
  }
}

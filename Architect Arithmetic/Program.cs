using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Which monument would you like to calculate?");
      Console.Write("Choose (1) Teotihuacan, (2) Taj Mahal or (3) Great Mosque of Mecca: ");
      string monument = Console.ReadLine();

      double totalArea;

      switch(monument) {
        case "1":
          totalArea = Rect(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);
          break;
        case "2":
          totalArea = Rect(90.5, 90.5) - 2 * Rect (24, 24);
          break;
        case "3":
          totalArea = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
          break;
        default:
          totalArea = 0;
          break;
      }

      double totalCost = totalArea * 180;
      
      Console.WriteLine($"My plan costs: {Math.Round(totalCost, 2)} pesos.");
    }
    static double Rect(double length, double width)
    {
      double area = length * width;
      return area;
    }
    static double Circle(double radius)
    {
      double area = Math.PI * Math.Pow(radius, 2);
      return area;
    }
    static double Triangle(double bottom, double height)
    {
      double area = 0.5 * bottom * height;
      return area;
    }
  }
}

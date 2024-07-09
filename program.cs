using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      DATA TYPES: int, double, char, string, bool
      VARIABLES: datatype variableName = value;
      COMMON ERRORS: wrong type, wrong value, no semicolon
      DATA TYPE CONVERSION: implicit, explicit, methods

      Good luck! */

      // Convert a bool to a string
      bool isTrue = true;
      bool isFalse = false;

      // Using ToString() method
      string trueString = isTrue.ToString();
      string falseString = isFalse.ToString();

      // Displaying the results
      Console.WriteLine("True as String: " + trueString);
      Console.WriteLine("False as String: " + falseString);

      // Convert string to char array
      string sentence = "Oliver Elliott";
      char[] charArr = sentence.ToCharArray();
      foreach (char ch in charArr)
      {

          Console.WriteLine(ch);
      }

      // Convert char array to string
      char[] chars = new char[10];
      chars[0] = 'O';
      chars[1] = 'l';
      chars[2] = 'i';
      chars[3] = 'v';
      chars[4] = 'e';
      chars[5] = 'r';
      string charsStr = new string(chars);
      string charsStr2 = new string(new char[]
      {'T','h','i','s',' ','i','s',' ','a',' ','s','t','r','i','n','g'});
      Console.WriteLine("Chars to string: {0}", charsStr);
      Console.WriteLine("Chars to string: {0}", charsStr2);


    }
  }
}

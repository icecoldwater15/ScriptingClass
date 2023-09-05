using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Elias";
      Console.WriteLine(name); 
      int number = 15;
      number = 67; // number is now 67
      Console.WriteLine(number);
      int myNum = 25;
      string myName = "Eli";
      char myCharacter = 'E';
      bool myBool = true;
      double myDouble = 25.99D;
      Console.WriteLine(myBool);
      Console.WriteLine(myName);
      Console.WriteLine(myCharacter);
      Console.WriteLine(myDouble);
      Console.WriteLine(myNum);
      Console.WriteLine(5 * 3);
      int newNumber = myNum + number;
      Console.WriteLine(newNumber);
     }
  }
}
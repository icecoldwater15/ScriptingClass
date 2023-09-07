using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
  int x = 15;
  int y = 15;
  Console.WriteLine("If x = " + x + " and y = " + y);
  Console.WriteLine("Then what is z in: x + y = z?");
  int z = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Your answer is: " + z);
  bool answer = z == x + y;
  if (answer)
  {
      Console.WriteLine("Correct!");
  }
  else
  {
      Console.WriteLine("Incorrect, please try again.");
  }
    }
}
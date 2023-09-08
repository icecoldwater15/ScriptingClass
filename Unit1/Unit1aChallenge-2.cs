using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     string name = "Elias";
     Console.WriteLine("Hi my name is " + name);
     int x = 15;
     Console.WriteLine("x = " + x);
     bool result = x > 30;
     Console.WriteLine("Is x > 30? " + result);
     double y = 13.545D;
     Console.WriteLine("y = " + y);
     double product = x * y;
     Console.WriteLine("What is the x multplied by y? " + product);
     int z = 25;
     Console.WriteLine("z = " + z);
     int sum = z + x;
     Console.WriteLine("What is the sum of x and z? " + sum);
     double quotient = z / y;
     Console.WriteLine("What is the quotient of z and y? " + quotient);
     double difference = z - x - y;
     Console.WriteLine("Solve this problem: z - x - y. " + difference);
     }
  }
}
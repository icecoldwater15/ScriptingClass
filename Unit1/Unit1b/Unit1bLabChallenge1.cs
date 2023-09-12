using System;

public class Unit1b
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("What is the temperature in celsius right now?");
        int temperature = Convert.ToInt32(Console.ReadLine());
        if (temperature > 30)
        {
            Console.WriteLine ("Wow, " + temperature + " degrees is pretty hot, make sure you stay hydrated today!");
        }
        else
        {
            Console.WriteLine ("Only " + temperature + " degrees? Enjoy the pleasent weather today!");
        }
    }
}
using System;

public class Unit1b
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("What is the temperature in celsius right now?");
        int temperature = Convert.ToInt32(Console.ReadLine());
       if (temperature >= 30)
       {
        Console.WriteLine ("Pretty hot outside, I would suggest light clothing and staying well hydrated today.");
       }
       else if (temperature >= 20)
       {
        Console.WriteLine ("Not too bad outside but still a little chilly. Perfect for a sweatshirt.");
       }
       else if (temperature >= 10)
       {
        Console.WriteLine ("Seems pretty cold out right now, Make sure to wear a jacket.");
       }
       else if (temperature >= 0)
       {
        Console.WriteLine ("Seems very cold outside right now, I recommend staying inside and keeping warm.");
       }
    }
}
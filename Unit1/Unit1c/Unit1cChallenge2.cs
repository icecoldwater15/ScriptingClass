using System;

public class Unit1c
{
    public static void Main(string[] args)
    {
        string food1;
        string food2;
        string food3;

        Console.WriteLine("Enter your three favorite foods!");

        Console.Write("Food number 1: ");
        food1 = Console.ReadLine();
        Console.Write("Food number 2: ");
        food2 = Console.ReadLine();
        Console.Write("Food number 3: ");
        food3 = Console.ReadLine();

        string[] foods = {food1, food2, food3};

        for (int i = 0; i < foods.length; i++) 
        {
            if (i == 0) 
            {
                Console.WriteLine("I love " + foods[i]);
            } 
            else if (i == 1) 
            {
                Console.WriteLine("I devour " + foods[i]);
            } 
            else if (i == 2) 
            {
                Console.WriteLine("I munch on  " + foods[i]);
            }
        }
    }
}
    
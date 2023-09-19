using System;

    public class Unit1c
    {    
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's create a number pyramid!" + "\n" + "Enter any positive number between 1 and 10.");
            int input = Convert.ToInt32(Console.ReadLine());
            int digits = 1;

            if (input > 9 || input <= 0) 
            {
                Console.WriteLine("Not a valid input, Try again.");
            } 
            else 
            {
                Console.WriteLine("GENERATING PYRAMID... \n");

                for (int i = 0; i < input; i++)
                {
                    for (int x = 0; x < digits; x++) 
                    {
                        Console.Write(i + 1);
                    }

                    Console.WriteLine();
                    digits++;
                }
            }
        }
    }
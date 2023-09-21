using System;

    public class Unit1c
    {
        public static void Main(string[] args)
        {
            int attempts = 0;
            Random random = new Random();
            int answer = random.Next(1,11);
            Console.WriteLine ("Let's play a game! " + "\n" + "Im thinking of a number that is between 1 and 10, can you guess it?");
            bool isDonePlaying = false;
            
            while (true)
            {
                if (isDonePlaying == true) 
                {
                    break;
                }

                int input = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (input > 10 || input < 1 )
                {
                    Console.WriteLine ("Please enter a valid number");
                }
                else if (input == answer)
                {
                    Console.WriteLine ("Wow, I can't believe you figured it out. Good job!");
                    Console.WriteLine("Number of attempts: " + attempts);
                    while (true)
                    {
                        System.Console.WriteLine("Do you want to play again? type Yes or No.");
                        string playAgain = Console.ReadLine();
                        if (playAgain == "Yes" || playAgain == "yes")
                        {
                            System.Console.WriteLine("Great! Guess again!");
                            answer = random.Next(1,11);
                            attempts = 0;
                            break;
                        }
                        else if (playAgain == "No" || playAgain == "no")
                        {
                            System.Console.WriteLine("Thanks for playing!");
                            isDonePlaying = true;
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Please type Yes or No");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Wrong! Try again");
                    if (input > answer)    
                    {
                        Console.WriteLine("Try guessing lower.");   
                    } 
                    else 
                    {
                        Console.WriteLine("Try guessing higher.");
                    }
                }
            }
        }
    }
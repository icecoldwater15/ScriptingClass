using System;

public class Unit1b
{
     public static void Main(string[] args)
    {
        int score = 0;
        string grade = "your grade is ";
        while (true)
        {
            Console.WriteLine ("-------------------" + "\n" + "What subject would like to submit a grade for?");

            string subject = Console.ReadLine();
        
            switch (subject)
            {
                case "Science":
                    Console.WriteLine ("What was your score, as a percent?");
                    score = Convert.ToInt32(Console.ReadLine());
                    if (score >= 90)
                    {
                        Console.WriteLine (grade + 'A');
                        Console.WriteLine ("Nice job, keep up the good work! You should look into doing fun experiments!");
                    }
                    else if (score >= 80)
                    {
                        Console.WriteLine (grade + 'B');
                        Console.WriteLine ("Great job, keep up the studying and you should have no issues with the tests!");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine (grade + 'C');
                        Console.WriteLine ("Good work! It seems like you understand the basics of our science concepts");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine (grade + 'D');
                        Console.WriteLine ("You're really close to understanding the material! Make sure to keep studying the basics!");
                    }
                    else if (score < 60)
                    {
                        Console.WriteLine (grade + 'F');
                        Console.WriteLine ("Not the best work, but you can always do better next time! Make sure you remember to study hard!");
                    }
                    break;
                case "History":
                    Console.WriteLine ("What was your score, as a percent?");
                    score = Convert.ToInt32(Console.ReadLine());
                    if (score >= 90)
                    {
                        Console.WriteLine (grade + 'A');
                        Console.WriteLine ("Nice job, keep up the good work! you should look into studying our past more!");
                    }
                    else if (score >= 80)
                    {
                        Console.WriteLine (grade + 'B');
                        Console.WriteLine ("Great job, keep studying and History will be come so much easier!");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine (grade + 'C');
                        Console.WriteLine ("Good work! Looks like you understand our History chapter very well.");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine (grade + 'D');
                        Console.WriteLine ("Looks like you're really close to understanding this History chapter! Make sure to memorize all the little things.");
                    }
                    else if (score < 60)
                    {
                        Console.WriteLine (grade + 'F');
                        Console.WriteLine ("Don't give up! Even Washington failed at some point!");
                    }
                    break;
                case "Math":
                    Console.WriteLine ("What was your score, as a percent?");
                    score = Convert.ToInt32(Console.ReadLine());
                    if (score >= 90)
                    {
                        Console.WriteLine (grade + 'A');
                        Console.WriteLine ("Nice job, keep up the good work! You should look into exploring mathematics more!");
                    }
                    else if (score >= 80)
                    {
                        Console.WriteLine (grade + 'B');
                        Console.WriteLine ("Great job, keep studying and you will become a math pro in no time!");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine (grade + 'C');
                        Console.WriteLine ("Good work! Seems like you understand the basics our Math chapter.");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine (grade + 'D');
                        Console.WriteLine ("You're really close to understanding the material! Keep studying and you will understand the basics!");
                    }
                    else if (score < 60)
                    {
                        Console.WriteLine (grade + 'F');
                        Console.WriteLine ("Keep studying and working hard and you will understand the material!");
                    }
                    break;
                default:
                    Console.WriteLine ("Make sure you type the subject correctly!");
                    break;
            }
        }
    }
}
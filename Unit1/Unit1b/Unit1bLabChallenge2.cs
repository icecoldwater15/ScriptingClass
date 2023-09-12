using System;

public class Unit1b
{
     public static void Main(string[] args)
     {
        Console.WriteLine ("What was your score, as a percent?");
        int score = Convert.ToInt32(Console.ReadLine());
        string grade = "your grade is ";
        if (score >= 90)
        {
            Console.WriteLine (grade + 'A');
        }
        else if (score >= 80)
        {
            Console.WriteLine (grade + 'B');
        }
        else if (score >= 70)
        {
            Console.WriteLine (grade + 'C');
        }
        else if (score >= 60)
        {
            Console.WriteLine (grade + 'D');
        }
        else if (score < 60)
        {
            Console.WriteLine (grade + 'F');
        }
     }
}
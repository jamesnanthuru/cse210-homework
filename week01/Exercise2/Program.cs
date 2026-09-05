using System;
//Author: James Nanthuru
//Course: CSE210
//Description: Second lesson for week one of C# language

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your CSE210 curent grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Need extra help? Consult a tutor from your student portal!");
        }
    }
}
using System;
//Author: James Nanthuru
//Course: CSE210
//Description: First lesson for week one of C# language

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your surname? ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {firstname} {surname}."); //cool repeat name like James Bond
    }
}
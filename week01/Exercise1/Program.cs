using System;

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
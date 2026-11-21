using System;
using System.Collections.Generic;

// To exceed the core requirements, I did two things:
// 1. I created a library of three scriptures and the program randomly picks one at startup.
// 2. I implemented the stretch challenge so that HideRandomWords only selects from words that are still visible.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths."),
            new Scripture(new Reference("Mosiah", 2, 17), "And behold I tell you these things that ye may learn wisdom that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.")
        };

        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();
            
            if (currentScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                currentScripture.HideRandomWords(3);
            }
        }
    }
}
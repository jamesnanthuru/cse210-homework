using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Program
{
    private static Timer reminderTimer;
    private static bool remindUser = true;

    static void Main(string[] args)
    {
        int userInput = -1;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        // Set up a timer to remind the user to write in their journal
        int reminderIntervalMinutes = 60; // Adjust the interval as needed
        reminderTimer = new Timer(ReminderCallback, null, TimeSpan.Zero, TimeSpan.FromMinutes(reminderIntervalMinutes));

        while (true)
        {
            const string MENU = "Please, select one of the following choices:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Set Reminder\n6. Quit";
            Console.WriteLine(MENU);

            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                switch (userInput)
                {
                    case 1: // WRITE
                        journal.WriteNewEntry(prompt);
                        break;

                    case 2: // DISPLAY
                        journal.DisplayJournal();
                        break;

                    case 3: // SAVE
                        Console.Write("Enter filename to save journal: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveJournalToFile(saveFilename);
                        break;

                    case 4: // LOAD
                        Console.Write("Enter filename to load journal: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadJournalFromFile(loadFilename);
                        break;

                    case 5: // SET REMINDER
                        SetReminder();
                        break;

                    case 6: // QUIT
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private static void ReminderCallback(object state)
    {
        if (remindUser)
        {
            Console.WriteLine("Don't forget to write in your journal today!");
        }
    }

    private static void SetReminder()
    {
        Console.Write("Set a reminder (in minutes) for writing in your journal: ");
        if (int.TryParse(Console.ReadLine(), out int reminderMinutes) && reminderMinutes > 0)
        {
            reminderTimer.Change(TimeSpan.FromMinutes(reminderMinutes), TimeSpan.FromMinutes(reminderMinutes));
            Console.WriteLine($"Reminder set for every {reminderMinutes} minutes.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number of minutes.");
        }
    }
}
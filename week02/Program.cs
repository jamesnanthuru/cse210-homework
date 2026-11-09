// Exceeding Requirements: 
// 1. Added an automated file management system that detects existing journal files, 
//    lists them for easy selection, and automatically remembers the active filename 
//    for subsequent saves without repeatedly prompting the user.
// 2. Implemented CSV file formatting so journal entries can be opened and viewed cleanly in Excel.

using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myjournal = new Journal();
        string currentFilename = "";

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

           choice = Console.ReadLine() ;  
           if (choice == "1")
            {
                Write(myjournal, promptGenerator);
            }

           else if (choice == "2")
            {
                myjournal.DisplayAll();
            }

           else if (choice == "3")
            {
                Save(myjournal, ref currentFilename);
            }

            else if (choice == "4")
            {
                Load( myjournal,  ref currentFilename);
            }

            else
            {
                 Console.WriteLine("Invalid option");
            }
        }
        Console.WriteLine("Goodbye!");

        // entry write function
        static void Write(Journal myjournal, PromptGenerator promptGenerator)
        {
            string randomPrompt = promptGenerator.GetRandomPrompt();


            Console.WriteLine(randomprompt);
            Console.Write("> ");
            string response = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;
            string currentDate = theCurrentTime.ToString("yyyy-MM-dd HH:mm:ss");
            Entry newEntry = new Entry(currentDate, randomprompt, response);
            myjournal.AddEntry(newEntry);
            //myjournal.DisplayAll();
        }

        static void Save(Journal myjournal, ref string currentFilename)  // use ref to remember the filenamefor the next time 
        {
            string filename = "";

            // Check if it the first time 
            if (string.IsNullOrEmpty(currentFilename))
            {
                Console.Write("Name the file: ");
                currentFilename = Console.ReadLine() + ".csv";
                filename = currentFilename;
            }
            else
            {
                // Atomatically use the existing journal file
                filename = currentFilename;
            }
            // Save the journal to the selected file
            myjournal.SaveToFile(filename);
        }

        static void Load(Journal myjournal, ref string currentFilename)
{
    // Look for all .csv files in the current directory
    string[] files = Directory.GetFiles(".", "*.csv");

    if (files.Length == 0)
    {
        Console.WriteLine("No journal files found. Please save a journal first.");
        return;
    }

    Console.WriteLine("\nAvailable Journals:");
    for (int i = 0; i < files.Length; i++)
    {
        // Print just the file name, not the full path
        Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
    }

    Console.Write("Enter the name of the file to load (e.g., myjournal.csv): ");
    currentFilename = Console.ReadLine();

    if (!File.Exists(currentFilename))
    {
        Console.WriteLine("File does not exist. Returning to menu.");
        return;
    }

    List<Entry> savedEntries = myjournal.ReadFromFile(currentFilename);
    foreach (Entry entry in savedEntries)
    {
        entry.Display();
    }
}
    }
        
}
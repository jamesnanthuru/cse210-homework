public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void WriteNewEntry(PromptGenerator promptGenerator)
    {
        Entry newEntry = new Entry();

        newEntry.Date = DateTime.Today.ToString("MM/dd/yyyy");
        newEntry.Prompt = promptGenerator.GetPrompt();
        Console.WriteLine($"{newEntry.Prompt}");
        newEntry.Text = Console.ReadLine();
        Entries.Add(newEntry);

        Console.WriteLine("Entry saved successfully.");
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"{entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Text}\n");
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"Date: {entry.Date}|{entry.Prompt}|{entry.Text}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadJournalFromFile(string filename)
    {
        Entries.Clear(); // Clear entries.

        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue; // Skip empty lines
                    }

                    string[] parts = line.Split('|');
                    
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry
                        {
                            Date = parts[0].Trim(),
                            Prompt = parts[1].Trim(),
                            Text = parts[2].Trim()
                        };
                        Entries.Add(entry);
                    }

            }
            Console.WriteLine($"Journal loaded from {filename} successfully.");

            
        }
        else
        {
            Console.WriteLine($"File {filename} not found.");
        }
        
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}");
        }
    }
}

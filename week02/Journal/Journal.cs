using System.Collections.Generic;
using System.IO;
public class Journal
{
    List<Entry> _entries; //declaring a variable named _entry exists is going to hold a List of custom Entry objec,But no memory allocated yet
    public Journal()
    {
       _entries = new List<Entry>();  // when we initalize like we did we have give the list of entry a memory to save
    }

   public void AddEntry(Entry newEntry)
   {
      _entries.Add(newEntry);  // This methods add the new Entry object into the _entries list, newEntry is the name of the parameter
   }

   public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
           entry.Display();
        }
    }

    public void SaveToFile(string filename)
    { 
        Console.WriteLine("Saving file.......");
       // Open the file for writing
       using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // visit each Entry object on the list
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetAsString());
            }
            //Console.WriteLine($"File saved at: {Path.GetFullPath(filename )}");
        }

    }

public void ReadFromFile(string filename)
{
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach(string line in lines)
    {
        string[] parts = line.Split(',');
        Entry e = new Entry(parts[0], parts[1], parts[2]);
        _entries.Add(e); // Add to the actual journal
    }
}

}
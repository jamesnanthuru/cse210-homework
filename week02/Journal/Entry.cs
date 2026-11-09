using System.Data;
public class Entry
{
    public string _date ;
    public string _prompt;
    public string _response;

    public Entry(string date, string prompt, String response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} -Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("");
    }

    public string GetAsString()
    {
        return _date + "," + _prompt + "," + _response;
    }
}
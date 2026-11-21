public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {_commenterName}: {_text}");
    }
}
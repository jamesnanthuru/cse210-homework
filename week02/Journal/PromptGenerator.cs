public class PromptGenerator
{
    List<string> _prompts = new List<string>();
    Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day? ");
        _prompts.Add("What did I learn today? ");
        _prompts.Add("What am i grateful for? ? ");
        _prompts.Add("What made me happy today? ");
        _prompts.Add("Who am i no longer willing to be? ");
        _prompts.Add("How do I want to be remembered? ");
        _prompts.Add("What drains my energy? ");
        _prompts.Add("What is something that i am tolerating that i do not want to be? ");
        _prompts.Add("What do i love most about life right now? ");
        _prompts.Add("When Last did i seek to pray? ");

    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    
}
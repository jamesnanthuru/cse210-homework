public class PromptGenerator
{
    private string[] prompts = {
    "What's something new you learned today?",
    "Describe a place you'd like to visit and why.",
    "Write about a act of kindness you witnessed or did today.",
    "Share your favorite quote and explain why it resonates with you.",
    "If you could have dinner with anyone, who would it be and why?",
    "Write about a challenge you overcame recently.",
    "What are you grateful for today?",
    "Describe a memorable dream you had recently.",
    "Share a childhood memory that still brings a smile to your face."
};

    private Random random = new Random();

    public string GetPrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}


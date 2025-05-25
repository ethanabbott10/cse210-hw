using System.Diagnostics.Contracts;

public class Prompt
{
    public List<string> _prompts = new List<string>
    {"What's something I learned about myself recently?", "What am I grateful for today and why?", "Describe a challenge I overcame and what it taught me.", "How do I feel right now, and what's contributing to that feeling?", "What does my ideal day look like and how can I move closer to it?"
    };

    public string GeneratePrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
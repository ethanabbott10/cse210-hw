using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Entry
{
    public List <string> _prompts = new List<string>
    {"What's something I learned about myself recently?", "What am I grateful for today and why?", "Describe a challenge I overcame and what it taught me.", "How do I feel right now, and what's contributing to that feeling?", "What does my ideal day look like and how can I move closer to it?"
    };

    public DateTime _date = DateTime.Today;
    public string _prompt = "";
    public string _response = "";
    public string _compiled = "";

    public void CompileEntry()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        _prompt = _prompts[index];
        Console.WriteLine(_prompts[index]);
        _response = Console.ReadLine();
        _dateString = _date.ToString();
        _compiled = $"{_dateString}\n{_prompt}:\n{_response}";
    }


}
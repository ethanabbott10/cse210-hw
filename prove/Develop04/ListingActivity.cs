using System.Security.Principal;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private List<string> _responses = new List<string>();

    public ListingActivity()
    {
        _type = "listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void RunListingActivity()
    {
        Console.WriteLine(_prompts[GetRandomIndex(_prompts)]);
        DisplayCountdown(7);
        SetActivityStartandEndTimes();
        Console.WriteLine("Begin making your list");
        while (DateTime.Now < _endTime)
        {
            _responses.Add(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"Way to go, you listed {_responses.Count} items!");
    }
}
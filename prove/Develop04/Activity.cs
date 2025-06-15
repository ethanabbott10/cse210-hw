using System.Collections;
using System.Dynamic;

public class Activity
{
    protected string _type = "";
    protected string _description = "";
    protected int _duration = 0;
    protected string _endingMessage = "";
    protected DateTime _startTime;
    protected DateTime _endTime;

    public Activity() { }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_type} activity.");
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void SetDuration()
    {
        Console.WriteLine($"How many seconds long would you like the {_type} activity to be?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayActivityBeginning()
    {
        Console.WriteLine();
        Console.WriteLine($"Get ready to begin the {_type} activity.");
        Console.WriteLine();
    }

    public void DisplayAnimation(int duration)
    {
        int i = 0;
        List<string> icons = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = SetSpinnerDuration(duration);
        while (DateTime.Now < endTime)
        {
            string icon = icons[i];
            Console.Write(icon);
            Thread.Sleep(1000);
            Console.Write("\b");
            i++;
            if (i >= icons.Count)
            {
                i = 0;
            }
        }
        Console.Write("\r    \r");
    }

    public void DisplayCountdown(int length)
    {
        int value = length;
        while (value > 0)
        {
            Console.Write(value);
            Thread.Sleep(1000);
            Console.Write("\b");
            value--;
        }
        Console.Write("\r    \r");
        
    }

    public void SetActivityStartandEndTimes()
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
    }

    public DateTime SetSpinnerDuration(int duration)
    {
        DateTime startTime = DateTime.Now;
        return startTime.AddSeconds(duration);
    }

    public int GetRandomIndex(List<string> list)
    {
        Random random = new Random();
        return random.Next(list.Count);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done. You completed a {_duration} second long {_type} actvity.");
        Thread.Sleep(10000);
    }
}
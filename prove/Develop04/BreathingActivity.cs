public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _type = "breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingActivity()
    {
        SetActivityStartandEndTimes();
        
        while (DateTime.Now < _endTime)
        {
            Console.WriteLine("Inhale...   ");
            DisplayCountdown(5);
            Console.WriteLine("Exhale...   ");
            DisplayCountdown(5);
            Console.WriteLine();
        }
    }

}
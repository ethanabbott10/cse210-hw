public class RunningActivity : Activity
{
    public RunningActivity() : base() { }
    public override void SetInfo()
    {
        Console.Clear();
        Console.Write("Date of run (mm/dd/yyyy): ");
        _date = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How many minutes did you run? ");
        _duration = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How many kilometers did you run? ");
        _distance = double.Parse(Console.ReadLine());
        _speed = _distance / _duration * 60;
        _pace = _duration / _distance;
        _summary = $"{_date} Running ({_duration} min)\nDistance: {_distance} km\nSpeed: {_speed} km/h\nPace: {_pace} min per km";
    }
}
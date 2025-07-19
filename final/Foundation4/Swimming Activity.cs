public class SwimmingActivity : Activity
{
    public SwimmingActivity() : base() { }

    public override void SetInfo()
    {
        Console.Clear();
        Console.Write("Date of swim (mm/dd/yyyy): ");
        _date = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How many minutes did you swim? ");
        _duration = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How many laps did you swim? ");
        _distance = double.Parse(Console.ReadLine()) * 50 / 1000;
        _speed = _distance / _duration * 60;
        _pace = 60 / _speed;
        _summary = $"{_date} Swimming ({_duration} min)\nDistance: {_distance} km\nSpeed: {_speed} km/h\nPace: {_pace} min per km";
    }
}
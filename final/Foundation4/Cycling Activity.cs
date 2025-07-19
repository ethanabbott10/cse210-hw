public class CyclingActivity : Activity
{
    public CyclingActivity() : base() { }

    public override void SetInfo()
    {
        Console.Clear();
        Console.Write("Date of ride (mm/dd/yyyy): ");
        _date = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How many minutes did you ride? ");
        _duration = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How fast did you ride? (km/h) ");
        _speed = double.Parse(Console.ReadLine());
        _distance = _speed * _duration / 60;
        _pace = 60 / _speed;
        _summary = $"{_date} Cycling ({_duration} min)\nDistance: {_distance} km\nSpeed: {_speed} km/h\nPace: {_pace} min per km";
    }
}
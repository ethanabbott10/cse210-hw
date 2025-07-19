using System.Dynamic;

public abstract class Activity
{
    protected DateOnly _date;
    protected double _duration;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _summary;

    public Activity() { }

    abstract public void SetInfo();

    public void DisplaySummary()
    {
        Console.WriteLine(_summary);
    }

    public DateOnly GetDate()
    {
        return _date;
    }

}
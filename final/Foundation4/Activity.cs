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

    virtual public void SetInfo()
    {
        
    }
}
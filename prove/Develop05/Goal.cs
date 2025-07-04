using System.Runtime.InteropServices;

public abstract class Goal
{
    protected string _goalId;
    protected string _goal;
    protected string _description;
    protected int _pointValue;
    protected int _pointsEarned;
    protected bool _completed;
    protected char _checkmark;
    protected string _storageString;

    public Goal() { }

    public abstract void SetGoal();

    public virtual void SetStorageString()
    {
        _storageString = _storageString = $"simplegoal~{_goal}~{_description}~{_pointsEarned}~{_pointValue}~{_completed}";
    }

    public string GetStorageString()
    {
        return _storageString;
    }

    public bool GetCompleted()
    {
        return _completed;
    }

    public int GetEarnedPoints()
    {
        return _pointsEarned;
    }

    public virtual void DisplayGoal()
    {
        Console.Write($"[{_checkmark}] {_goal} ({_description})");
    }

    public abstract void Complete(); 

}
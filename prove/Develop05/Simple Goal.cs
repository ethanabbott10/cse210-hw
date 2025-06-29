public class SimpleGoal : Goal
{
    public SimpleGoal() : base() { }
    public SimpleGoal(string goal, string description, int pointValue, bool completed, char checkmark)
    {
        _goal = goal;
        _description = description;
        _pointValue = pointValue;
        _completed = completed;
        _checkmark = checkmark;
    }
}
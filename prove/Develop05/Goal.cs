public class Goal
{
    protected string _goal;
    protected string _description;
    protected int _pointValue;
    protected bool _completed;
    protected char _checkmark;

    public Goal() { }

    public void SetGoal()
    {
        Console.WriteLine("What is your goal?");
        _goal = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal:");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        _pointValue = int.Parse(Console.ReadLine());
        _completed = false;
        _checkmark = ' ';
    }

}
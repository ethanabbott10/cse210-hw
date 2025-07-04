public class SimpleGoal : Goal
{
    public SimpleGoal() : base() { }
    public SimpleGoal(string goal, string description, string pointsEarned, string pointValue, string completed)
    {
        _goal = goal;
        _description = description;
        _pointValue = int.Parse(pointValue);
        _pointsEarned = int.Parse(pointsEarned);
        _completed = bool.Parse(completed);
        if (_completed)
        {
            _checkmark = '✔';
        }
        SetStorageString();
    }

    public override void SetGoal()
    {
        Console.WriteLine("What is your goal?");
        _goal = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Give a short description of your goal:");
        _description = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("How many points is this goal worth?");
        _pointValue = int.Parse(Console.ReadLine());
        _pointsEarned = 0;
        _completed = false;
        _checkmark = ' ';
        SetStorageString();
    }

    public override void Complete()
    {
        if (_completed == false)
        {
            _completed = true;
            _checkmark = '✔';
            _pointsEarned += _pointValue;
            SetStorageString();
            if (_pointValue == 1)
            {
                Console.WriteLine($"Well done! You have earned {_pointValue} point.");
            }

            else
            {
                Console.WriteLine($"Well done! You have earned {_pointValue} points.");
            }
            Console.ReadKey();
            
        }

        else
        {
            Console.WriteLine("This goal has already been completed.");
            Console.ReadKey();
        }
    }
}
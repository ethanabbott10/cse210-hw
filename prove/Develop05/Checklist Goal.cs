using System.Data;

public class ChecklistGoal : Goal
{
    private int _checkpointPoints;
    private int _totalIterations;
    private int _completedIterations;

    public ChecklistGoal() : base() { }

    public ChecklistGoal(string goal, string description, string pointsEarned, string pointValue, string checkpointPoints, string totalIterations, string completedIterations, string completed)
    {
        _goal = goal;
        _description = description;
        _pointValue = int.Parse(pointValue);
        _checkpointPoints = int.Parse(checkpointPoints);
        _pointsEarned = int.Parse(pointsEarned);
        _totalIterations = int.Parse(totalIterations);
        _completedIterations = int.Parse(completedIterations);
        _completed = bool.Parse(completed);
        if (_completed)
        {

            _checkmark = '✔';
        }
        _storageString = $"checklistgoal~{_goal}~{_description}~{_pointsEarned}~{_pointValue}~{_checkpointPoints}~{_totalIterations}~{_completedIterations}~{_completed}";
    }

    public override void SetGoal()
    {
        Console.WriteLine("What is your goal?");
        _goal = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Give a short description of your goal:");
        _description = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("How many times do you want to complete this goal?");
        _totalIterations = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("How many points do you earn each time you complete this goal?");
        _checkpointPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("How many points do you earn for completing the entire goal?");
        _pointValue = int.Parse(Console.ReadLine());
        _completedIterations = 0;
        _completed = false;
        _checkmark = ' ';
        SetStorageString();
    }

    public override void SetStorageString()
    {
        _storageString = $"simplegoal~{_goal}~{_description}~{_pointsEarned}~{_pointValue}~{_checkpointPoints}~{_totalIterations}~{_completedIterations}~{_completed}";
    }

    public override void DisplayGoal()
    {
        Console.Write($"[{_checkmark}] {_goal} ({_description}) - Completed {_completedIterations}/{_totalIterations}");
    }

    public override void Complete()
    {
        if (_completed)
        {
            Console.WriteLine($"This goal is already complete.");
            Console.ReadKey();
        }

        else
        {
            _completedIterations++;

            if (_completedIterations == _totalIterations)
            {
                _pointsEarned += _checkpointPoints;
                _pointsEarned += _pointValue;
                _checkmark = '✔';
                _completed = true;
                SetStorageString();
                if (_pointValue == 1 && _checkpointPoints == 1)
                {
                    Console.WriteLine($"Well done! You earned {_checkpointPoints} point for completing the task and {_pointValue} point for completing the whole goal.");
                }

                else if (_checkpointPoints == 1)
                {
                    Console.WriteLine($"Well done! You earned {_checkpointPoints} point for completing the task and {_pointValue} points for completing the whole goal.");
                }

                else if (_pointValue == 1)
                {
                    Console.WriteLine($"Well done! You earned {_checkpointPoints} points for completing the task and {_pointValue} point for completing the whole goal.");
                }

                else
                {
                    Console.WriteLine($"Well done! You earned {_checkpointPoints} points for completing the task and {_pointValue} points for completing the whole goal.");
                }

                Console.ReadKey();
            }

            else
            {
                _pointsEarned += _checkpointPoints;
                SetStorageString();
                if (_checkpointPoints == 1)
                {
                    Console.WriteLine($"Well done! You have earned {_checkpointPoints} point.");
                }

                else
                {
                    Console.WriteLine($"Well done! You have earned {_checkpointPoints} points.");
                }
                Console.ReadKey();
            }
        }
    }
}
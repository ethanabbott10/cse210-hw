public class Log
{
    private int _totalPoints;
    private List<Goal> _goals = new List<Goal>();

    private List<Goal> _completedGoals = new List<Goal>();
    private string _fileName;

    public Log() { }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void AddCompletedGoal(Goal goal)
    {
        _completedGoals.Add(goal);
    }

    public void MoveToCompletedGoals(int goalIndex)
    {
        _completedGoals.Add(_goals[goalIndex]);
        _goals.RemoveAt(goalIndex);
    }

    public Goal GetGoal(int index)
    {
        return _goals[index];
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            int _label = i + 1;
            Console.WriteLine();
            Console.Write($"{_label}. ");
            _goals[i].DisplayGoal();
            Console.WriteLine();
        }
    }

    public void DisplayCompletedGoals()
    {
        for (int i = 0; i < _completedGoals.Count; i++)
        {
            int _label = i + 1;
            Console.WriteLine();
            Console.Write($"{_label}. ");
            _completedGoals[i].DisplayGoal();
            Console.WriteLine();
        }
    }

    public int GetTotalPoints()
    {
        int _pointsSum = SumPointsEarned();
        return _pointsSum;
    }
    public int SumPointsEarned()
    {
        _totalPoints = 0;
        foreach (Goal goal in _goals)
        {
            _totalPoints += goal.GetEarnedPoints();
        }

        foreach (Goal goal in _completedGoals)
        {
            _totalPoints += goal.GetEarnedPoints();
        }

        return _totalPoints;
    }

    public void SaveFile()
    {
        Console.WriteLine("Name the file:");
        _fileName = Console.ReadLine();
        using (StreamWriter s = new StreamWriter(_fileName))
        {
            foreach (Goal goal in _goals)
            {
                s.WriteLine(goal.GetStorageString());
            }

            foreach (Goal goal in _completedGoals)
            {
                s.WriteLine(goal.GetStorageString());
            }
        }
    }

    public void LoadFile()
    {
        _goals.Clear();
        Console.WriteLine("What is the name of the file?");
        _fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            if (parts[0] == "simplegoal")
            {
                SimpleGoal simplegoal = new SimpleGoal(parts[1], parts[2], parts[3], parts[4], parts[5]);
                if (parts[5] == "True")
                {
                    AddCompletedGoal(simplegoal);
                }

                else
                {
                    AddGoal(simplegoal);
                }

            }

            else if (parts[0] == "eternalgoal")
            {
                EternalGoal eternalgoal = new EternalGoal(parts[1], parts[2], parts[3], parts[4], parts[5]);
                if (parts[5] == "True")
                {
                    AddCompletedGoal(eternalgoal);
                }

                else
                {
                    AddGoal(eternalgoal);
                }
            }

            else if (parts[0] == "checklistgoal")
            {
                ChecklistGoal checklistgoal = new ChecklistGoal(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8]);
                if (parts[7] == "True")
                {
                    AddCompletedGoal(checklistgoal);
                }

                else
                {
                    AddGoal(checklistgoal);
                }
            }
        }
    }

    public void RemoveGoal()
    {
        int _goalIndex = 0;
        bool _validInput = false;

        if (GetGoalsListLength() == 0)
        {
            Console.WriteLine("You have no goals to remove.");
            Console.ReadKey();
        }

        else
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Here are your goals:");
                DisplayGoals();
                Console.Write("Which goal would you like to remove? ");
                string _input = Console.ReadLine();

                if (int.TryParse(_input, out _goalIndex))
                {
                    _goalIndex -= 1;

                    if (_goalIndex >= 0 && _goalIndex < GetGoalsListLength())
                    {
                        _validInput = true;
                        _goals.RemoveAt(_goalIndex);
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please make a valid selection");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection");
                    Console.ReadKey();
                }
            } while (_validInput == false);
        }
    }
    

    public int GetGoalsListLength()
    {
        return _goals.Count;
    }
}



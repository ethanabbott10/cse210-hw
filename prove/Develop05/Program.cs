using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Log log = new Log();
        int _userInput = 0;
        while (_userInput != 6)
        {
            Console.WriteLine("Welcome to the your goal manager");
            Console.WriteLine();
            Console.WriteLine($"You have {log.GetTotalPoints()} points");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1). Create a New Goal");
            Console.WriteLine("2). List Goals");
            Console.WriteLine("3). Save Goals");
            Console.WriteLine("4). Load Goals");
            Console.WriteLine("5). Record Event");
            Console.WriteLine("6). Quit");
            Console.Write("Which action would you like to perform? ");
            _userInput = int.Parse(Console.ReadLine());
        }

        if (_userInput == 1)
        {
            int _goalChoice = 0;
            Console.WriteLine("Goal options:");
            Console.WriteLine("1). Simple Goal");
            Console.WriteLine("2). Eternal Goal");
            Console.WriteLine("3). Checklist Goal");
            Console.Write("Which goal would you like to create? ");
            _goalChoice = int.Parse(Console.ReadLine());

            if (_goalChoice == 1)
            {
                SimpleGoal goal = new SimpleGoal();
                goal.SetGoal();
                log.AddGoal(goal);
            }

            else if (_goalChoice == 2)
            {
                EternalGoal goal = new EternalGoal();
                goal.SetGoal();
                log.AddGoal(goal);
            }

            else
            {
                ChecklistGoal goal = new ChecklistGoal();
                goal.SetGoal();
                log.AddGoal(goal);
            }
        }

        if (_userInput == 2)
        {
            log.DisplayGoals();
        }

        if (_userInput == 3)
        {
            log.SaveFile();
        }

        if (_userInput == 4)
        {
            log.LoadFile();
        }

        if (_userInput == 5)
        {
            int _goalIndex = 0;
            Console.WriteLine("Here are your goals:");
            log.DisplayGoals();
            Console.Write("For which goal would you like to record an event? ");
            _goalIndex = int.Parse(Console.ReadLine()) - 1;
            log.GetGoal(_goalIndex).Complete();
        }

        else
        {}
    }

}
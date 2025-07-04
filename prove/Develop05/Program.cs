using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Log log = new Log();
        int _userInput = 0;
        while (_userInput != 8)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your goal manager");
            Console.WriteLine();
            if (log.GetTotalPoints() == 1)
            {
                Console.WriteLine($"You have {log.GetTotalPoints()} point");
            }
            else
            {
                Console.WriteLine($"You have {log.GetTotalPoints()} points");
            }
            Console.WriteLine();
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1). Create a New Goal");
            Console.WriteLine("2). Record Event");
            Console.WriteLine("3). List Incomplete Goals");
            Console.WriteLine("4). List Completed Goals");
            Console.WriteLine("5). Delete Goal");
            Console.WriteLine("6). Save Goals");
            Console.WriteLine("7). Load Goals");
            Console.WriteLine("8). Quit");
            Console.Write("Which action would you like to perform? ");
            string _input = Console.ReadLine();

            if (!int.TryParse(_input, out _userInput))
            {
                Console.Clear();
                Console.WriteLine("Please make a valid selection.");
                _userInput = 0;
                Console.ReadKey();
                continue;
                
            }

            switch (_userInput)
            {
                case 1:
                    int _goalChoice = 0;
                    bool _validInput = false;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Goal options:");
                        Console.WriteLine("1). Simple Goal");
                        Console.WriteLine("2). Eternal Goal");
                        Console.WriteLine("3). Checklist Goal");
                        Console.Write("Which goal would you like to create? ");
                        string _secondinput = Console.ReadLine();
                        Console.WriteLine();

                        // used ChatGPT for this syntax
                        if (int.TryParse(_secondinput, out _goalChoice))
                        {
                            switch (_goalChoice)
                            {
                                case 1:
                                    _validInput = true;
                                    SimpleGoal simplegoal = new SimpleGoal();
                                    simplegoal.SetGoal();
                                    log.AddGoal(simplegoal);
                                    break;

                                case 2:
                                    _validInput = true;
                                    EternalGoal eternalgoal = new EternalGoal();
                                    eternalgoal.SetGoal();
                                    log.AddGoal(eternalgoal);
                                    break;

                                case 3:
                                    _validInput = true;
                                    ChecklistGoal checklistgoal = new ChecklistGoal();
                                    checklistgoal.SetGoal();
                                    log.AddGoal(checklistgoal);
                                    break;

                                default:
                                    Console.WriteLine("Please make a valid selection");
                                    Console.ReadKey();
                                    break;
                            }
                        }

                        else
                        {
                            Console.WriteLine("Please make a valid selection");
                            Console.ReadKey();
                        }

                    } while (_validInput == false);

                    break;

                case 2:
                    if (log.GetGoalsListLength() == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You have no incomplete goals.");
                        Console.ReadKey();
                    }

                    else
                    {
                        int _goalIndex = 0;
                        bool _secondValidInput = false;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Here are your goals:");
                            log.DisplayGoals();
                            Console.Write("For which goal would you like to record an event? ");
                            string _thirdInput = Console.ReadLine();

                            if (int.TryParse(_thirdInput, out _goalIndex))
                            {
                                _goalIndex -= 1;


                                if (_goalIndex <= log.GetGoalsListLength() && _goalIndex >= 0)
                                {
                                    _secondValidInput = true;
                                    log.GetGoal(_goalIndex).Complete();
                                    if (log.GetGoal(_goalIndex).GetCompleted())
                                    {
                                        log.MoveToCompletedGoals(_goalIndex);
                                    }
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
                        } while (_secondValidInput == false);
                    }
                    break;

                case 3:
                    Console.Clear();
                    log.DisplayGoals();
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    log.DisplayCompletedGoals();
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Clear();
                    log.RemoveGoal();
                    break;

                case 6:
                    Console.Clear();
                    log.SaveFile();
                    break;

                case 7:
                    Console.Clear();
                    log.LoadFile();
                    break;
            }
        }
    }

}
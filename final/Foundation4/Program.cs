using System;

class Program
{
    static void Main(string[] args)
    {
        Log log = new Log();
        string _userInput = "0";

        while (_userInput != "3")
        {
            Console.Clear();
            Console.WriteLine("Welcome to your fitness tracking app!");
            Console.WriteLine();
            Console.WriteLine("1). Log activity");
            Console.WriteLine("2). Display activities");
            Console.WriteLine("3). Exit");
            Console.WriteLine();
            Console.Write("Please select the number of the action you would like to take: ");
            _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                bool _validResponse = false;
                
                while (_validResponse == false)
                {
                    string _response;
                    Console.Clear();
                    Console.WriteLine("1). Running");
                    Console.WriteLine("2). Cycling");
                    Console.WriteLine("3). Swimming");
                    Console.WriteLine();
                    Console.Write("Please select the number of the activity you would like to log: ");
                    _response = Console.ReadLine();

                    if (_response == "1")
                    {
                        _validResponse = true;
                        RunningActivity runningActivity = new RunningActivity();
                        runningActivity.SetInfo();
                        log.LogActivity(runningActivity);
                    }

                    else if (_response == "2")
                    {
                        _validResponse = true;
                        CyclingActivity cyclingActivity = new CyclingActivity();
                        cyclingActivity.SetInfo();
                        log.LogActivity(cyclingActivity);
                    }

                    else if (_response == "3")
                    {
                        _validResponse = true;
                        SwimmingActivity swimmingActivity = new SwimmingActivity();
                        swimmingActivity.SetInfo();
                        log.LogActivity(swimmingActivity);
                    }

                    else
                    {
                        _validResponse = false;
                    }
                }
            }

            else if (_userInput == "2")
            {
                log.DisplayLog();
                Console.ReadKey();
            }

            else if (_userInput == "3")
            {

            }

            else
            {
                _userInput = "0";
            }
        }
    }
}
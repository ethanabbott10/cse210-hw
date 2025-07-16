using System;

class Program
{
    static void Main(string[] args)
    {
        Planner planner = new Planner();
        string _userInput = "0";
        while (_userInput != "3")
        {
            Console.Clear();
            Console.WriteLine("Event Manager");
            Console.WriteLine();
            Console.WriteLine("Actions:");
            Console.WriteLine();
            Console.WriteLine("1). Add event to planner");
            Console.WriteLine("2). Get marketing message");
            Console.WriteLine("3). Exit");
            Console.WriteLine();
            Console.Write("Select the number of the action you would like to take: ");
            _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                string _eventSelection;
                bool _validSelection = false;

                while (_validSelection == false)
                {
                    Console.Clear();
                    Console.WriteLine("Event Options:");
                    Console.WriteLine();
                    Console.WriteLine("1). Lecture");
                    Console.WriteLine("2). Reception");
                    Console.WriteLine("3). Outdoor Gathering");
                    Console.WriteLine();
                    Console.Write("Select the number of the event you would like to add: ");
                    _eventSelection = Console.ReadLine();

                    if (_eventSelection == "1")
                    {
                        Console.Clear();
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date (mm/dd/yyyy): ");
                        DateOnly date = DateOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Time (xx:xx PM): ");
                        TimeOnly time = TimeOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Address of Event: ");
                        string address = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Who will be speaking? ");
                        string speaker = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("How many people can attend? ");
                        int capacity = int.Parse(Console.ReadLine());
                        Address dirección = new Address(address);
                        Lecture lecture = new Lecture(title, description, date, time, dirección, speaker, capacity, "Lecture");
                        planner.AddEvent(lecture);
                        _validSelection = true;
                    }

                    else if (_eventSelection == "2")
                    {
                        Console.Clear();
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date (mm/dd/yyyy): ");
                        DateOnly date = DateOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Time (xx:xx PM): ");
                        TimeOnly time = TimeOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Address of Event: ");
                        string address = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("RSVP Email: ");
                        string email = Console.ReadLine();
                        Address dirección = new Address(address);
                        Reception reception = new Reception(title, description, date, time, dirección, email, "Reception");
                        planner.AddEvent(reception);
                        _validSelection = true;
                    }

                    else if (_eventSelection == "3")
                    {
                        Console.Clear();
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Description: ");
                        string description = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Date (mm/dd/yyyy): ");
                        DateOnly date = DateOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Time (xx:xx PM): ");
                        TimeOnly time = TimeOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Address of Event: ");
                        string address = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Weather Forecast: ");
                        string weather = Console.ReadLine();
                        Address dirección = new Address(address);
                        OutdoorGathering outdoorGathering = new OutdoorGathering(title, description, date, time, dirección, weather, "Outdoor Gathering");
                        planner.AddEvent(outdoorGathering);
                        _validSelection = true;
                    }

                    else
                    {
                        _validSelection = false;
                    }
                }
            }

            else if (_userInput == "2")
            {
                bool _selecciónVálida = false;
                int index;

                while (_selecciónVálida == false)
                {
                    Console.Clear();
                    planner.DisplayEventsList();
                    Console.Write("Select the number of the event you wish to generate information for: ");
                    string inputstring = Console.ReadLine();

                    if (!int.TryParse(inputstring, out index))
                    {
                        _selecciónVálida = false;
                    }

                    else
                    {
                        index = int.Parse(inputstring) - 1;
                        if (index < planner.GetEventsListLength())
                        {
                            _selecciónVálida = true;
                            bool _otherValidSelection = false;

                            while (_otherValidSelection == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Messages:");
                                Console.WriteLine("1). Standard Details");
                                Console.WriteLine("2). Full Details");
                                Console.WriteLine("3). Short description");
                                Console.WriteLine();
                                Console.Write("Select the number of the message you would like to generate: ");
                                string otherInput = Console.ReadLine();

                                if (otherInput == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine(planner.GetEvent(index).GetStandardDetails());
                                    _otherValidSelection = true;
                                    Console.ReadKey();
                                }

                                else if (otherInput == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine(planner.GetEvent(index).GetFullDetails());
                                    _otherValidSelection = true;
                                    Console.ReadKey();
                                }

                                else if (otherInput == "3")
                                {
                                    Console.Clear();
                                    Console.WriteLine(planner.GetEvent(index).GetFullDetails());
                                    _otherValidSelection = true;
                                    Console.ReadKey();
                                }

                                else
                                {
                                    _otherValidSelection = false;
                                }
                            }
                        }

                        else
                        {
                            _selecciónVálida = false;
                        }
                    }
                }


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
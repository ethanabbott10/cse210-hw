using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int _response = 0;
        Journal journal = new Journal();

        do
        {
            _response = Display();
            PerformAction(journal, _response);

        } while (_response != 5);
    }  
    public static int Display()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        string _responseString = Console.ReadLine();
        return int.Parse(_responseString);
    }
    public static void PerformAction(Journal journal, int _response)
    {
        if (_response == 1)
        {
            Entry entry = new Entry();
            entry.GetPrompt();
            entry.DisplayPrompt();
            entry.GetResponse();
            journal.AddEntry(entry);
        }

        else if (_response == 2)
        {
            journal.DisplayEntries();
        }

        else if (_response == 3)
        {
            journal.LoadFile();
        }

        else if (_response == 4)
        {
            journal.SaveFile();
        }
    }
}
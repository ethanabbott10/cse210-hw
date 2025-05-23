using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public int _response = 0;

    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        string _responseString = Console.ReadLine();
        int _response = int.Parse(_responseString);
    }

    public void PerformAction(int _response)
    {
        if (_response == 1)
        {
        }

        else if (_response == 2)
        {

        }

        else if (_response == 3)
        {

        }

        else if (_response == 4)
        {

        }

        else
        {

        }
    }

}
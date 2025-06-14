using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int _index = 0;

        do
        {
            DisplayMenu();
            _index = int.Parse(Console.ReadLine()) - 1;
            Activity activity = new Activity(_index);
            }
        }

    }

    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program.");
        Console.WriteLine("Please select one of the following activities:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Selection: ");
    }
}
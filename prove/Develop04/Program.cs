using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int _input = 0;

         while (_input != 4)
        {
            DisplayMenu();
            _input = int.Parse(Console.ReadLine());


            if (_input == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.DisplayDescription();
                breathingActivity.SetDuration();
                breathingActivity.DisplayActivityBeginning();
                breathingActivity.DisplayAnimation(5);
                breathingActivity.RunBreathingActivity();
                breathingActivity.DisplayEndingMessage();
            }

            else if (_input == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.DisplayDescription();
                reflectionActivity.SetDuration();
                reflectionActivity.DisplayActivityBeginning();
                reflectionActivity.DisplayAnimation(5);
                reflectionActivity.RunReflectionActivity();
                reflectionActivity.DisplayEndingMessage();
            }

            else if (_input == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.DisplayDescription();
                listingActivity.SetDuration();
                listingActivity.DisplayActivityBeginning();
                listingActivity.RunListingActivity();
                listingActivity.DisplayEndingMessage();
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
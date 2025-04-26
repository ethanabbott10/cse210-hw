using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
    

        if (grade >= 70)
        {
            Console.WriteLine($"Your letter grade: {letter}");
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine($"Your letter grade: {letter}");
            Console.WriteLine("We are sorry, you did not pass the class. Hope you can learn from your mistakes.");
        }


    }
}
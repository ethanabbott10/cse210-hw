using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        DisplayWelcome();

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        string name = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        int number = PromptUserNumber();

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        int square = SquareNumber(number);

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the  square of your number is {square}");
        }

        DisplayResult(name, square);
    }
}
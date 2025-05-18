using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        do
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1,100);

            Console.Write("What is your guess? ");
            string input2 = Console.ReadLine();
            int guess = int.Parse(input2);

            int guesses = 1;

            do
            {
                if(magic > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

                guesses = guesses + 1;

                Console.Write("What is your guess? ");
                input2 = Console.ReadLine();
                guess = int.Parse(input2);
            } while (guess != magic);

            Console.WriteLine($"You guessed it in {guesses} guesses!");
            Console.WriteLine("Would you like to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}
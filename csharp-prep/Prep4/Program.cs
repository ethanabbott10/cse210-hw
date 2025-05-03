using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        int sum = 0;
        int max = 0;

        List<int> numbers = new List<int>();
        List<int> positive = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
            if (number == 0)
            {
                numbers.Remove(0);
            }
            if (number > 0)
            {
                positive.Add(number);
            }
            numbers.Sort();
            positive.Sort();
        }

        max = numbers[numbers.Count - 1];
        int smallest = positive[0];

        foreach (int numero in numbers)
        {   
            sum = sum + numero;
        }

        float average = ((float)sum)/numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number: {smallest}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}
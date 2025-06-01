using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string _response = "";

        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer program! Please enter the following");
        Reference reference = SetReference();
        Scripture scripture = SetScripture(reference);
        bool continuar = true;
        do
        {
            DisplayReferenceAndScripture(reference, scripture);
            continuar = scripture.Hide();
            Console.WriteLine("\n\nPress enter to hide a word or type quit to stop.");
            _response = Console.ReadLine();
        } while (_response == "" && continuar);
    }
    public static Reference SetReference()
    {
        Console.WriteLine("Scripture Reference (should follow conventional reference format):");
        string referencia = Console.ReadLine();
        int colon = referencia.IndexOf(':');
        string verses = referencia.Substring(colon + 1, referencia.Length-colon-1);
        string bookAndChapter = referencia.Substring(0, colon);
        int gap = bookAndChapter.LastIndexOf(' ');
        string book = bookAndChapter.Substring(0, gap);
        string chapter = bookAndChapter.Substring(gap + 1, bookAndChapter.Length-gap -1);
        Reference reference = new Reference(book, chapter, verses);
        return reference;
    }

    public static Scripture SetScripture(Reference reference)
    {
        List<string> numbers = reference.ReturnNumbers();
        Console.WriteLine("Verse: ");
        string escritura = Console.ReadLine();
        Scripture scripture = new Scripture(escritura, numbers);
        return scripture;
    }

    public static void DisplayReferenceAndScripture(Reference reference, Scripture scripture)
    {
        Console.Clear();
        reference.DisplayReference();
        scripture.DisplayScripture();
    }
}

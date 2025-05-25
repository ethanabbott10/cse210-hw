using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Entry
{
    public string _date = DateTime.Today.ToShortDateString();
    public string _prompt = "";
    public string _response = "";
    public string _entry = "";

    public void GetPrompt()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.GeneratePrompt();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        _response = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        _entry = $"{_date}\n{_prompt}\n\n{_response}";
        Console.WriteLine(_entry);
    }


}
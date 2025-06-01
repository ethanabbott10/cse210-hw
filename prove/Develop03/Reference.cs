using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security;

public class Reference
{
    private string _book = "";
    private string _chapter = "";
    private List<string> _numbers = new List<string>(); 
    private string _reference = "";

    public Reference(string book, string chapter, string verses)
    {
        List<int> numeros = new List<int>();
        _book = book;
        _chapter = chapter;
        _reference = $"{book} {chapter}:{verses}";

        if (verses.Contains(","))
        {
            string[] parts = verses.Split(", ");
            foreach (string part in parts)
            {
                _numbers.Add(part);
            }
        }

        else if (verses.Contains("-"))
        {
            string[] versiculos = verses.Split('-');
            foreach (string versiculo in versiculos)
            {
                int numero = int.Parse(versiculo);
                numeros.Add(numero);
            }

            for (int i = numeros[0]; i <= numeros[1]; i += 1)
            {
                _numbers.Add(i.ToString());
            }

            
        }

        else
        {
            _numbers.Add(verses);
        }

    }


    public List<string> ReturnNumbers()
    {
        return _numbers;
    }
    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }

}
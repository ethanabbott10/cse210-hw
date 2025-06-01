using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

public class Word
{
    private string _word = "";

    private bool _hidden = false;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string MakeString()
    {
        return _word;
    }

    public bool Hidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
        string underscores = new string('_', _word.Length);
        _word = underscores;
    }

    
}
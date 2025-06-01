using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.Marshalling;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _scripture = "";
    private List<int> _indecies = [];
    private List<int> _numberIndecies = new List<int>();

    public Scripture(string scripture, List<string> numbers)
    {
        List<string> punctuation = new List<string>(){ ".", ",", "!", "?", ";", ":", "'", "\"", "-", "(", ")", "[", "]", "{", "}", "...", "—", "–", "/" };
        foreach (string punct in punctuation)
        {
            scripture = scripture.Replace(punct, punct + " ");
        }
        scripture = scripture.Replace("  ", " ");
        string[] palabras = scripture.Split(" ");
        foreach (string palabra in palabras)
        {
            Word word = new Word(palabra);
            _words.Add(word);
        }

        SetIndecies(_words);

        List<int> otherIndecies = new List<int>(_indecies);

        foreach (int index in otherIndecies)
        {
            if (numbers.Contains(_words[index].MakeString()))
            {
                _numberIndecies.Add(index);
                _indecies.Remove(index);
            }
        }

        ShuffleIndecies(_indecies);


    }

    public void MergeScripture()
    {
        _scripture = "";
        foreach (Word word in _words)
        {

            _scripture += word.MakeString() + " ";
        }
    }

    public void SetIndecies(List<Word> words)
    {
        for (int i = 0; i < words.Count; i++)
        {
            _indecies.Add(i);
        }
    }

    public void ShuffleIndecies(List<int> indecies)
    {
        Random random = new Random();
        int n = indecies.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            (indecies[n], indecies[k]) = (indecies[k], indecies[n]);
        }
    }

    public bool Hide()
    {
        if (_indecies.Count == 0 || AllHidden()) return false;
        int remaining = 3;
        if (_indecies.Count < remaining)
        {
            remaining = _indecies.Count;
        }
        for (int i = 0; i < remaining; i++)
            {
                int index = _indecies[0];
                Word word = _words[index];
                word.Hide();
                _indecies.RemoveAt(0);
            }
        return true;
    }

    public bool AllHidden()
    {
        List<Word> actualWords = new List<Word>(_words);

        foreach (int index in _numberIndecies)
        {
            actualWords.RemoveAt(index);
        }
        return actualWords.All(word => word.Hidden());
    }

    public void DisplayScripture()
    {
        MergeScripture();
        Console.Write(_scripture);
    }
}
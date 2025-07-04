public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";

    public override string ToString()

    {
        return base.ToString();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine();
            _entries[i].DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("Name the file:");
        _fileName = Console.ReadLine();
        using (StreamWriter s = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date}~{entry._prompt}~{entry._response}";
                s.WriteLine(line);
            }
        }
    }

    public void LoadFile()
    {
        _entries.Clear();
        Console.WriteLine("What is the name of the file?");
        _fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            AddEntry(entry);
        }
    }

}
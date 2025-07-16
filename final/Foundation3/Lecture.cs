using System.Text.RegularExpressions;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity, string type) : base()
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
        _capacity = capacity;
        _speaker = speaker;
        _standardDetails = $"{_title}\n{_description}\n{_date}, {_time}\n{_address.GetAddress()}";
        _shortDescription = $"{_type}\n{_title}\n{_date}";
        SetFullDetails();
    }

    override public void SetFullDetails()
    {
        _fullDetails = $"{_type}\n{_speaker}\n{_standardDetails}\nCapacity: {_capacity}";
    }
}
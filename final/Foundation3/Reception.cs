public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string email, string type) : base()
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
        _email = email;
        _standardDetails = $"{_title}\n{_description}\n{_date}, {_time}\n{_address.GetAddress()}";
        _shortDescription = $"{_type}\n{_title}\n{_date}";
        SetFullDetails();
    }

    public override void SetFullDetails()
    {
        _fullDetails = $"{_type}\n{_standardDetails}\nRSVP: {_email}";
    }
}
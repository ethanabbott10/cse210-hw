abstract public class Event
{
    protected string _title;
    protected string _description;
    protected DateOnly _date;
    protected TimeOnly _time;
    protected Address _address;
    protected string _standardDetails;
    protected string _fullDetails;
    protected string _shortDescription;
    protected string _type;

    public Event() { }


    public string GetStandardDetails()
    {
        return _standardDetails;
    }

    public string GetFullDetails()
    {
        return _fullDetails;
    }

    public string GetShortDescription()
    {
        return _shortDescription;
    }

    abstract public void SetFullDetails();
}
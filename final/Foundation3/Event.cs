abstract public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected Address _address;
    protected string _standardDetails;
    protected string _fullDetails;
    protected string _shortDescription;
    protected string _type;

    public Event() {}   


    public void DisplayStandardDetails()
    {
        Console.WriteLine(_standardDetails);
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(_fullDetails);
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine(_shortDescription);
    }

    abstract public void SetFullDetails();
}
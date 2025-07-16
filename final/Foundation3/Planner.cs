public class Planner
{
    private List<Event> _planner = new List<Event>();

    public Planner() { }

    public void AddEvent(Event newevent)
    {
        _planner.Add(newevent);
    }

    public void DisplayEventsList()
    {
        int i = 1;
        foreach (Event evento in _planner)
        {
            Console.WriteLine($"{i}). {evento.GetShortDescription()}");
            Console.WriteLine();
            i++;
        }
    }

    public int GetEventsListLength()
    {
        return _planner.Count();
    }

    public Event GetEvent(int index)
    {
        return _planner[index];
    }
}
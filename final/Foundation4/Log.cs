public class Log
{
    private List<Activity> _log = new List<Activity>();

    public Log() { }

    public void DisplayLog()
    {
        if (_log.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("There are no activities");
        }

        else
        {
            Console.Clear();
            foreach (Activity activity in _log)
            {
                activity.DisplaySummary();
                Console.WriteLine();
            }
        }
    }

    public void LogActivity(Activity activity)
    {
        _log.Add(activity);
        _log = _log.OrderBy(e => e.GetDate()).ToList();
    }
}
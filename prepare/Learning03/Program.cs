musing System;

class Program
{
    static void Main(string[] args)
    {
        public class Job
        {
            public string _company = "";
            public string _jobTitle = "";
            int _startYear = 0;
            int _endYear = 0;

            public Job()
            {
            }

            public void Display()
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
            }

        }

        public class Resume
        {
            public string _name = "";
            public List<string> _jobs = List<Job>();

            public Job()
            {
            }

            public void Display()
            {
                Console.WriteLine($"{_name}");
                for (int i = 0; i < _jobs.Length, i++);
            }



        }
    }
}
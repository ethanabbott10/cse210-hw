using System;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Playlist _playlist = new Playlist();
        _playlist.AddVideo(CreateVideo());
        _playlist.AddVideo(CreateVideo());
        _playlist.DisplayVideos();
    }

    static Video CreateVideo()
    {
        List<string> _nameBank = new List<string>{"Liam Smith", "Olivia Johnson", "Noah Brown", "Emma Taylor", "Ava Anderson", "William Thomas", "Sophia Jackson", "James White", "Isabella Harris", "Benjamin Martin", "Mia Lewis", "Elijah Walker", "Charlotte Hall", "Lucas Allen", "Amelia Young", "Henry King", "Evelyn Wright", "Alexander Scott", "Harper Green", "Michael Adams"};
        List<string> _titleBank = new List<string>{"Day in the Life of a Software Engineer", "I Tried Waking Up at 5AM for a Week", "Top 10 Programming Languages in 2025", "How to Start a YouTube Channel in 2025", "Building My First Mobile App – From Idea to Launch", "Minimalist Desk Setup Tour 2025", "React vs Angular: Which One Should You Learn?", "I Lived Like Elon Musk for 24 Hours", "Ultimate Guide to Budget Travel", "What's on My iPhone 2025", "Coding for 12 Hours Straight – Challenge", "5 Habits That Changed My Life", "How I Learned to Code (No Degree)", "My Productivity Routine – 2025 Edition", "Unboxing the Latest iPhone – Worth It?", "How to Build Passive Income Online", "Trying Viral TikTok Life Hacks", "I Built an AI That Writes My Emails", "How I Got 1,000 Subscribers in a Month", "What I Wish I Knew Before College"};
        List<string> _lengthBank = new List<string>{"00:45", "01:30", "02:45", "03:00", "05:00", "06:30", "08:00", "10:00", "12:15", "15:00", "17:15", "20:00", "22:18", "25:00", "30:00", "45:00", "59:00", "01:00"};
        List<string> _commentBank = new List<string>{"This video changed my life!", "I wasn’t expecting that ending 😂", "Who's watching this in 2025?", "Absolute masterpiece.", "This deserves way more views.", "I’ve watched this 10 times already!", "The editing is on point.", "Can we take a moment to appreciate the visuals?", "Came for the title, stayed for the content.", "Why is this not viral yet?", "I needed this today, thank you!", "That transition at 3:45 was 🔥", "Subbed immediately!", "This belongs on Netflix.", "The quality keeps getting better!", "You earned a like and a sub.", "Legendary content.", "How is this not trending?", "YouTube needs to recommend this to more people.", "Instant classic."};

        Random random = new Random();
        int _authorIndex = random.Next(_nameBank.Count);
        int _titleIndex = random.Next(_titleBank.Count);
        int _lengthIndex = random.Next(_lengthBank.Count);

        Video _video = new Video(_titleBank[_titleIndex], _nameBank[_authorIndex], _lengthBank[_lengthIndex]);

        for (int i = 0; i < 4; i++)
        {
            int _nameIndex = random.Next(_nameBank.Count);
            int _commentIndex = random.Next(_commentBank.Count);

            Comment _comment = new Comment(_nameBank[_nameIndex], _commentBank[_commentIndex]);

            _video.AddComment(_comment);
        }

        return _video;
    }
}
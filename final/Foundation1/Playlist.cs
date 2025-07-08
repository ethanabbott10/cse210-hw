public class Playlist
{
    List<Video> _videos = new List<Video>();

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void DisplayVideos()
    {
        Console.Clear();
        for (int i = 0; i < _videos.Count; i++)
        {
            _videos[i].DisplayVideo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
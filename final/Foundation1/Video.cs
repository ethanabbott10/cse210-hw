using System.Reflection.Metadata.Ecma335;

public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    private int GetCommentQuantity()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}\n{_author}\n{_length}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Comments({GetCommentQuantity()})");
        Console.WriteLine();
        
        for (int i = 0; i < _comments.Count; i++)
        {
            _comments[i].DisplayComment();
            Console.WriteLine();
        }
    }
}
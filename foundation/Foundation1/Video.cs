using System.Transactions;

public class Video
{
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        return _comments.Count;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display() {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length);
        Console.WriteLine("Comments: ");
        foreach (var comment in _comments)
        {
            comment.Display();
        }
    }
}
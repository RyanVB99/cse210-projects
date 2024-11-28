public class Comment
{
    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }
    private string _author;
    private string _content;

    public void Display()
    {
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Content: " + _content);
    }

}
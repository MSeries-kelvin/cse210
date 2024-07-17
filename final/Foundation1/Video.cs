public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    // Constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();
    }

    // Methods
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
}
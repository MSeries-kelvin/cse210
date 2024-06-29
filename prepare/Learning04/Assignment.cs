public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters & Setters
    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
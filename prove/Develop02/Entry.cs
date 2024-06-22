public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    private string _title;

    public Entry(string date, string promptText, string entryText, string title)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _title = title;
    }

    public void Display()
    {
        string entryString = $"Title: {_title}\nDate: {_date} - Prompt: {_promptText}\n{_entryText}\n";
        Console.WriteLine(entryString);
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetPromptText()
    {
        return _promptText;
    }

    public string GetEntryText()
    {
        return _entryText;
    }

    public string GetTitle()
    {
        return _title;
    }
}
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string date = entry.GetDate();
                string promptText = entry.GetPromptText();
                string entryText = entry.GetEntryText();
                string title = entry.GetTitle();
                string savableFormat = $"{date}~|~{promptText}~|~{entryText}~|~{title}";

                outputFile.WriteLine(savableFormat);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            string title = parts[3];

            _entries.Add(new Entry(date, promptText, entryText, title));
        }

    }
}
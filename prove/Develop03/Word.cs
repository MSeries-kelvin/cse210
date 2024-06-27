using System.Linq.Expressions;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructors
    public Word(string text)
    {
        _text = text;
    }

    // Methods
    public void Hide()
    {

    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return "";
    }
}
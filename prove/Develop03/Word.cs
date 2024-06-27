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
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenWord = "";

            foreach (char i in _text)
            {
                hiddenWord += "_";
            }

            return hiddenWord;
        }
        
        return _text;
    }
}
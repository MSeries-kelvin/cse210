public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Keeps track of words that are not hidden yet.
    // by storing their index
    private List<int> _indexesOfVisibleWords = new List<int>();

    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        int i = 0;

        foreach (string word in words)
        {
            _words.Add(new Word(word));

            _indexesOfVisibleWords.Add(i);
            i++;
        }
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            if (_indexesOfVisibleWords.Count > 0)
            {
                // pick a random word index from the list
                // of not hidden words
                int randomeWordIndex = randomGenerator.Next(_indexesOfVisibleWords.Count);
                randomeWordIndex = _indexesOfVisibleWords[randomeWordIndex];

                _words[randomeWordIndex].Hide();
                _indexesOfVisibleWords.Remove(randomeWordIndex);
            }
        }
    }

    public string GetDisplayText()
    {
        string printFormat = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            printFormat += word.GetDisplayText() + " ";
        }
        
        return printFormat;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
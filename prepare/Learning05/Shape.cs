public class Shape
{
    private string _color;

    // Constructors
    public Shape(string color)
    {
        _color = color;
    }

    // Methods
    public virtual double GetArea()
    {
        return 0;
    }

    // Getter and setters
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
}
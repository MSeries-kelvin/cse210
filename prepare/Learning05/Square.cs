public class Square : Shape
{
    private double _side;

    // Construtors
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Methods
    public override double GetArea()
    {
        return _side * _side;
    }

    // Getters and Setters
}
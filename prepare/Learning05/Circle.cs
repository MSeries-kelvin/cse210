public class Circle : Shape
{
    private double _radius;

    // Construtors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Methods
    public override double GetArea()
    {
        // throw new NotImplementedException();
        return Math.PI * (_radius * _radius);
    }

    // Getters and Setters
}
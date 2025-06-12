using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;

    public Square(string shape, string color, double side) : base(shape, color)
    {
        _side = side;
    }

    public override double CalculateArea()
    {
        return _side * _side;    
    }
}
public abstract class Shape
{
    private string _color;
    private string _shape;

    public Shape(string shape, string color)
    {
        _shape = shape;
        _color = color;
    }

    public string GetShape()
    {
        return _shape;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double CalculateArea();
}
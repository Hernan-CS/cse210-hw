using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Square", "Red", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Rectangle", "Green", 2, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("Circle", "Yellow", 5);
        shapes.Add(s3);

        foreach (Shape i in shapes)
        {
            string shape = i.GetShape();

            string color = i.GetColor();

            double area = Math.Round(i.CalculateArea());

            Console.WriteLine($"Shape: {shape} \nColor: {color} \nArea: {area} \n-----------------");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        Square square = new Square("burgundy", 10);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        Rectangle rectangle = new Rectangle("burgundy", 10, 10);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        Circle circle = new Circle("burgundy", 10);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        _shapes.Add(square);
        _shapes.Add(rectangle);
        _shapes.Add(circle);
        foreach (Shape shape in _shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
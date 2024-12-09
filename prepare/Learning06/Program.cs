using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 5));
        shapes.Add(new Square("Green", 5));
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetType().Name} is {shape.GetArea()}");
        }
        
    }
}
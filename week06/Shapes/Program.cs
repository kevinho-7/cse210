using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<Shapes> shapes = new List<Shapes>();

        Square s1 = new Square("red", 5);
        s1.SetName("Square");
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("blue", 4, 6);
        r1.SetName("Rectangle");
        shapes.Add(r1);

        Circle c1 = new Circle("yellow", 3);
        c1.SetName("Circle");
        shapes.Add(c1);


        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"The {shape.GetName()} has the color {shape.GetColor()} and the area is {shape.GetArea()}\n");
        }
    }
}
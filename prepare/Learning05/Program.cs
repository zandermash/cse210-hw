using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square mySquare = new Square("Red", 3);
        shapes.Add(mySquare);

        Circle myCircle = new Circle("Blue", 6);
        shapes.Add(myCircle);

        Rectangle myRectangle = new Rectangle("Green", 4, 5);
        shapes.Add(myRectangle);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}


using Inheritance.Models;

List<Shape> shapes = new List<Shape>();

Shape shape = new Point();
shapes.Add(shape);

Line line = new Line(4);
shapes.Add(line);
line.Color = "czerwony";



shape = new Rectangle(6, 123);
shapes.Add(shape);

Triangle triangle = new Triangle(2, 2, 90);
Console.WriteLine(   triangle.CalculateArea());
Shape2D shape2D = triangle;
Console.WriteLine(shape2D.CalculateArea());
/*Shape1D shape1D = triangle;
Console.WriteLine(shape1D.CalculateArea());*/

triangle.Color = "niebieski";

shapes.Add(triangle);




foreach (Shape s in shapes)
{
    Console.WriteLine(s.ToString());
}

List<IColor> coloredShapes = new List<IColor>();
/*coloredShapes.Add(line);
coloredShapes.Add(triangle);*/

foreach (Shape s in shapes)
{
    if(s is IColor)
    {
        coloredShapes.Add((IColor)s);
    }
}

foreach (Shape s in coloredShapes)
{
    Console.WriteLine(s.ToString());
}

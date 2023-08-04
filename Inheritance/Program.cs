

using Inheritance.Models;

List<Shape> shapes = new List<Shape>();

Shape shape = new Point();
shapes.Add(shape);

shape = new Line(4);
shapes.Add(shape);


shape = new Rectangle(6, 123);
shapes.Add(shape);

Triangle triangle = new Triangle(2, 2, 90);
Console.WriteLine(   triangle.CalculateArea());
Shape2D shape2D = triangle;
Console.WriteLine(shape2D.CalculateArea());
/*Shape1D shape1D = triangle;
Console.WriteLine(shape1D.CalculateArea());*/

shapes.Add(shape);




foreach (Shape s in shapes)
{
    Console.WriteLine(s.ToString());
}
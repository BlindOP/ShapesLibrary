// See https://aka.ms/new-console-template for more information
using ShapesLibrary;
var shapes = new List<IShape>();
shapes.Add(new Circle(2));
shapes.Add(new Circle(3));
shapes.Add(new Triangle(4,5,6));
shapes.Add(new Triangle(5,4,6));
shapes.Add(new Triangle(6,5,4));

var sumArea = 0.0;
foreach (var shape in shapes)
{
    sumArea += shape.GetArea();
}

Console.WriteLine(sumArea);
Console.ReadLine();
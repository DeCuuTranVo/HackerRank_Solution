/*
Create a C# program that represents the following UML class diagram. 
The diagram represents public, private, and protected attributes as well as class dependency and inheritance.

https://www.exercisescsharp.com/oop/shapes-class-diagram
*/


using System;

class Program {
    public static void Main(string[] args) {
        Location c1 = new Location(2.5, 3.5);
        Shape shape1 = new Rectangle(c1, 3, 4);

        Console.WriteLine(shape1.ToString());
        Console.WriteLine("Area " + shape1.Area());
        Console.WriteLine("Perimeter " + shape1.Perimeter());

        Location c2 = new Location(1, 1);
        Shape shape2 = new Circle(c2, 2);
        Console.WriteLine(shape2.ToString());
        Console.WriteLine("Area " + shape2.Area());
        Console.WriteLine("Perimeter " + shape2.Perimeter());

    }
}


/* Sample Solution 
public class Shape
{
    protected Location c;
 
    public string ToString()
    {
        return string.Empty;
    }
 
    public double Area()
    {
        return 0.000;
    }
 
    public double Perimeter()
    {
        return 0.000;
    }
}
 
public class Location
{
    private double x, y;
}
 
public class Rectangle : Shape
{
    protected double side1, side2;
}
 
public class Circle : Shape
{
    protected double radius;
}
*/
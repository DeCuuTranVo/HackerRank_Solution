using System;

class Circle: Shape {
    public static double pi = 3.14;
    protected double radius;

    public Circle(Location c, double radius): base(c) {
        this.radius = radius;
    }

    public override string ToString() {
        return "Circle at position ("+ this.c.X + ", " + this.c.Y+ ") with radius " + this.radius;
    }

    public override double Area() {
        return Circle.pi * this.radius * this.radius;
    }

    public override double Perimeter() {
        return Circle.pi * this.radius * 2;
    }
}
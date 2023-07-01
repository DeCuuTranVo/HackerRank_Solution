using System;

class Rectangle : Shape {
    protected double size1;
    protected double size2;

    public Rectangle(Location c, double size1, double size2) : base(c) {
        this.size1 = size1;
        this.size2 = size2;
    }

    public override string ToString() {
        return "Rectange at position (" + this.c.X + ", " + this.c.Y+ ") with height " + this.size1 + " and width " + this.size2; 
    }

    public override double Area() {
        return this.size1 * this.size2;
    }

    public override double Perimeter() {
        return 2 * (this.size1 + this.size2);

    }
}
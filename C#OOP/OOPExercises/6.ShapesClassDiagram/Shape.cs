using System;

abstract class Shape {
    protected Location c;

    public Shape(Location c) {
        this.c = c;
    }

    public abstract string ToString();

    public abstract double Area();

    public abstract double Perimeter();
}
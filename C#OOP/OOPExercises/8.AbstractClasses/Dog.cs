using System;

class Dog: Animal {
    public Dog(string name): base(name) {
        ;
    }

    public override void Eat()
    {
        Console.WriteLine("The Dog is Eating");
    }
}
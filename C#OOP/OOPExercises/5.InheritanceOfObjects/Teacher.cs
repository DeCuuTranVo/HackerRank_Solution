/*
    The Teacher classes inherit from the Person class.
    The Teacher class will include a public Explain() method that will write I'm explaining on the screen.
*/

using System;

class Teacher: Person {

    public Teacher(string name): base(name) {
        ;
    }

    public void Explain() {
        Console.WriteLine("I'm explaining");
    }
}
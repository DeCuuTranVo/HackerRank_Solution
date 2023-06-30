/*
    The Student classes inherit from the Person class.
    The Student class will include a public Study() method that will write I'm studying on the screen.
    Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

*/

using System;

class Student: Person {
    public Student(string name): base(name) {
        
    }

    public void Study() {
        Console.WriteLine("I'm studying");
    }

}
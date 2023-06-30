/*
    To do this, create a Person class that has 
        a Name property of type string, 
        a constructor that receives the name as a parameter and 
        overrides the ToString () method.
*/

using System;

class Person
{
    public string Name { get; set; }

    // Constructor 
    public Person(string name) {
        Name = name;
    }

    public override string ToString()
    {
        return "Hello! My name is " + Name;
    }
}
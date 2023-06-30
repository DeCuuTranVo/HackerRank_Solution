/*
The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.
*/

using System;

class Person
{
    public int Age { get; set; }

    // Constructor 
    public Person(int age) {
        Age = age;
    }

    public Person() {
        Age = 0;
    }

    public void Greet() {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int age) {
        Age = age;
    }
}
using System;
class Person
{
    public string Name {get; set;}
    public int Age { get; set;}

    // Constructor 
    public Person(string name, int age) {
        this.Name = name;
        this.Age = age;
    }

    public string ToString() {
        return this.Name + " - " + this.Age;
    }
}
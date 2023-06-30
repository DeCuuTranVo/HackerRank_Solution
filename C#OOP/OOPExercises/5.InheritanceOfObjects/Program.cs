// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/*
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
There will be two people of the Student type and one person of the Teacher type.

To do this, create a Person class that has 
    a Name property of type string, 
    a constructor that receives the name as a parameter and 
    overrides the ToString () method.

Then create two more classes that inherit from the Person class, they will be called Student and Teacher. 
The Student class has a Study method that writes by console that the student is studying. 
The Teacher class will have an Explain method that writes to the console that the teacher is explaining. 

Remember to also create two constructors on the child classes that call the parent constructor of the Person class.

End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.

// https://www.exercisescsharp.com/oop/inheritance-of-objects
*/

using System;

class Program {
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];

        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine("Please Input Your Name:")
            };
        }

        for (int i = 0; i < total; i++)
        {
            // Check class of current object, cast it to real class
            if (persons[i] is Student) {
                ((Student)persons[i]).Study();
            } 

            if (persons[i] is Teacher) {
                ((Teacher)persons[i]).Explain();
            }
        }

        Console.ReadLine();
    }
}
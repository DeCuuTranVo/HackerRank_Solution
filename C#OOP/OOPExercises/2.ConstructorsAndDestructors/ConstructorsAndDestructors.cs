/*
    Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
    To do this, first create a Person class that has a Name property of type string, 
    a constructor that receives the name as a parameter, 
    a destructor that assigns the name to empty and 
    overwrites the ToString () method.

    End the program by reading the people and executing the ToString () method on screen.

    View problem at: https://www.exercisescsharp.com/oop/constructors-destructors
*/
using System;
namespace ConstructorsAndDestructors
{
    class Person
    {
        public string Name { get; set; }

        // Constructor 
        public Person() {
            Name = "Anonymous";        
        }

        public Person(string personName) {
            if (personName == null) {
                throw new Exception("This field must not be null");
            }
            Name = personName;     
        }

        ~Person() {
            Name = null;
        }
        
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }

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
                Console.WriteLine(persons[i].ToString());
            }
    
            Console.ReadLine();
        }
    }
}


/*
using System;
 
public class ConstructorsAndDestructors
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    }
 
    public class Person
    {
        public string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
 
        ~Person()
        {
            Name = string.Empty;
        }
    }
}
*/
using System;

/*
    Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person. 
    To do this, first create a Person class that has a Name property of type string and override the ToString() method.
    End the program by reading people and executing the ToString() method on the screen.

    Question: https://www.exercisescsharp.com/oop/first-class-method-tostring

*/

namespace FirstClass
{
  class Person
  {
    private string name; // field

    // public string Name { get; set; }
    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    // Constructor 
    public Person() {
        name = "Anonymous";        
    }

    public Person(string personName) {
        if (personName == null) {
            throw new Exception("This field must not be null");
        }
        name = personName;        
    }
    
    public override string ToString()
    {
        return "Hello! My name is " + name;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
        Person[] people = new Person[3];

        // Loop three times
        for (int i = 0; i < 3; i++) {
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Create a new person from that name
            Person person;
            if (userName == null){
                person = new Person();
            } else {
                person = new Person(userName);
            }

            // Add that person object to array
            people[i] = person;
        }

        // Loop through the array and print those people's name
        for (int i = 0; i < people.Length; i++) {
            Console.WriteLine(people[i]);
        }
    }
  }
}

/* Sample solution

using System;
 
public class FirstClass
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine()
            };
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
 
        Console.ReadLine();
    }
 
    public class Person
    {
        public string Name { get; set; }
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}


*/
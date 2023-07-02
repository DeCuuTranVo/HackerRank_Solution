/*
Create a C# program that uses a Queue to store a list of people. 
First prepare a class called Person.cs with two properties (name and age) and a ToString() method to print the result.

Then define a Queue and request the information (name and age) of three people from the user, you will have to store the information in the queue. 
Remember that you can find the Queue object in the System.Collections namespace of the .NET Framework.

To end the program, print the data of the people walking the queue.
*/
using System;
using System.Collections;

class Program {
    public static void Main(string[] args) {
        Queue<Person> persons = new Queue<Person>();

        int total = 3;
        for (int i = 0; i < total; i++) {
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            Console.Write("Input age: ");
            int age = int.Parse(Console.ReadLine());

            Person aPerson = new Person(name, age);
            persons.Enqueue(aPerson);
        }

        // A queue can be enumerated without disturbing its contents.
        foreach(Person person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}

/*
using System;
using System.Collections;
 
public class QueueObjects
{
    public static void Main(string[] args)
    {
        Queue queue = new Queue();
        int total = 3;
 
        for (int i = 0; i < total; i++)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
 
            queue.Enqueue(new Person() {
                Name = name,
                Age = age
            });
        }
 
        for (int i = 0;i < total; i++)
        {
            Person p = (Person) queue.Dequeue();
            Console.WriteLine(p.ToString());
        }
    }
 
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
 
 
        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}
*/
/*
Create a C# program that uses a ArrayList to store a list of people. 
First prepare a class called Person.cs with two properties (name and age) and a ToString() method to print the result.

Then define a ArrayList and request the information (name and age) of three people from the user, you will have to store the information in the list. 
Remember that you can find the ArrayList object in the System.Collections namespace of the .NET Framework.

To end the program it prints the data of the people going through the list of data.
*/

using System;
using System.Collections;

class Program {
    public static void Main(string[] args) {
        ArrayList persons = new ArrayList();

        int total = 3;
        for (int i = 0; i < total; i++) {
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            Console.Write("Input age: ");
            int age = int.Parse(Console.ReadLine());

            Person aPerson = new Person(name, age);
            persons.Add(aPerson);
        }

        // Use for loop
        for (int i = 0; i < total; i++) {
            Person aPerson = (Person) persons[i];
            Console.WriteLine(aPerson.ToString());
        }

        // Use foreach loop
        foreach(Person item in persons )
        {
            Console.WriteLine(item.ToString());
        }
    }
}


/* Solution
using System;
using System.Collections;
 
public class ArrayListObjects
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
 
        int total = 3;
        for (int i = 0; i < total; i++)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
 
            list.Add(new Person() {
                Name = name,
                Age = age
            });
        }
 
        foreach (Person p in list)
        {
            Console.WriteLine(p.ToString());
        }
 
        Console.ReadLine();
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
/*
Create a C# program that implements an abstract class Animal that has a Name property of type text and three methods SetName (string name), GetName and Eat. 
The Eat method will be an abstract method of type void.

You will also need to create a Dog class that implements the above Animal class and the Eat method that says the dog is Eating.

To test the program ask the user for a dog name and create a new Dog type object from the Main of the program, 
    give the Dog object a name, 
    and then execute the GetName and Eat methods.

Problem: https://www.exercisescsharp.com/oop/abstract-classes
*/

using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter dog name: ");
        string dogName = Console.ReadLine();
        Dog newDog = new Dog(dogName);
        Console.WriteLine(newDog.GetName());
        newDog.Eat();
    }
}

/*
using System;
 
public class AbstractClass
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.SetName(Console.ReadLine());
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }
 
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
 
    public abstract class Animal
    {
        private string Name;
 
        public void SetName(string name)
        {
            Name = name;
        }
 
        public string GetName()
        {
            return Name;
        }
 
        public abstract void Eat();
    }
}
*/
/*
Create a C# program that simulates the operation of a stack using an array of integers. 

There will be a class called Stack with 2 properties, an array of integers and an integer to store the current position of the stack.

The stack must have a constructor where the size will be specified per parameter and two methods, one for Push() and one for Pop() the values. 
Remember that the new values are queued at the beginning of the stack and the last ones are unstacked.

To test, create a Stack object in the program's Main and try to stack and unstack some values.
*/

using System;
// using System.Collections;

class Program {
    public static void Main(string[] args) {
        Stack myStack = new Stack(100);
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        int removedValue10 = myStack.Pop();
        Console.WriteLine(removedValue10);
        int removedValue20 = myStack.Pop();
        Console.WriteLine(removedValue20);
        int removedValue30 = myStack.Pop();
        Console.WriteLine(removedValue30);
    }
}

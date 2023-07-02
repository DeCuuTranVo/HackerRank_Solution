/*
Create a C# program that simulates the operation of a queue using an array of integers. 
There will be a class called Queue with 2 properties,
     an array of integers and 
     an integer to store the current position of the queue values.

The queue must have a 
    constructor where the size of the queue will be specified per parameter and two methods, 
        one for Enqueue() and the other for 
        Unenqueue() the values. 
    Remember that the new values are glued at the end and the first ones are descoiled.

To test, create a Queue object in the program's Main and try to queue and unqueue some values.
*/

using System;
// using System.Collections;

class Program {
    public static void Main(string[] args) {
        Queue myQueue = new Queue(100);
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);
        int removedValue10 = myQueue.Dequeue();
        Console.WriteLine(removedValue10);
        int removedValue20 = myQueue.Dequeue();
        Console.WriteLine(removedValue20);
        int removedValue30 = myQueue.Dequeue();
        Console.WriteLine(removedValue30);
    }
}



/* Solution
using System;
 
public class QueueArrays
{
    public static void Main(string[] args)
    {
        int size = 2;
        Queue queue = new Queue(size);
 
        int val1 = 7, 
            val2 = 1;
 
        queue.Enqueue(val1);
        queue.Enqueue(val2);
 
        val1 = queue.Dequeue();
        val2 = queue.Dequeue();
 
        Console.WriteLine(val1);
        Console.WriteLine(val2);
    }
}
 
public class Queue
{
    private int[] queue;
    private int position;
    
    public Queue(int size)
    {
        position = -1;
        queue = new int[size];
    }
 
    public void Enqueue(int value)
    {
        position++;
        queue[position] = value;
    }
 
    public int Dequeue()
    {
        int aux = queue[0];
 
        for (int i = 0; i < position; i++)
        {
            queue[i] = queue[i + 1];
        }
 
        queue[position] = aux;
        position--;
 
        return queue[position + 1];
    }
}



*/
/*
There will be a class called Queue with 2 properties,
     an array of integers and 
     an integer to store the current position of the queue values.

The queue must have a 
    constructor where the size of the queue will be specified per parameter and two methods, 
        one for Enqueue() and the other for 
        Unenqueue() the values. 
    Remember that the new values are glued at the end and the first ones are descoiled.
*/
using System;
using System.Collections;

class Queue {
    private int[] arr;
    private int idx;

    public Queue(int queueSize) {
        this.arr = new int[queueSize];
        this.idx = -1;
    }

    public void Enqueue(int value) {
        this.arr[this.idx+1] = value;
        this.idx++;
    }

    public int Dequeue() {
        // Check empty queue
        if (this.idx == -1){
            throw new Exception("Empty queue can not be dequeued");
        }

        //  Get the value at index 0
        int headValue = this.arr[0];


        // Shift every value one index to the left
        for (int i = 0; i < this.idx; i++) {
            this.arr[i] = this.arr[i+1];
        }

        // Decrease this.idx by one value
        this.idx--;

        // Return the dequeued value
        return headValue;
    }
}
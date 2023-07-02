using System;
using System.Collections;

class Stack {
    private int[] arr;
    private int idx;

    public Stack(int stackSize) {
        this.arr = new int[stackSize];
        this.idx = -1;
    }

    public void Push(int value) {
        this.arr[this.idx+1] = value;
        this.idx++;
    }

    public int Pop() {
        // Check empty queue
        if (this.idx == -1){
            throw new Exception("Empty queue can not be dequeued");
        }

        //  Get the value at index idx
        int tailValue = this.arr[this.idx];

        // Decrease this.idx by one value
        this.idx--;

        // Return the dequeued value
        return tailValue;
    }
}
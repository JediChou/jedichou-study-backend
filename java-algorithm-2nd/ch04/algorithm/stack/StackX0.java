/*
 * File name    : StackX0.java
 * Description  : For StackApp.java. And it is a statck.
 * Source From  : from data structures & algorithms in java - page 83 to 84.
 */
package ch04.algorithm.stack;

public class StackX0 {

    private int maxSize;    // size of stack array
    private long[] stackArray;
    private int top;        // top of stack

    public StackX0(int s) {
        // 1. set array size
        // 2. create array
        // 3. no items yet
        maxSize = s;
        stackArray = new long[maxSize];
        top = -1;
    }

    public void push(long j) {
        // Put item on top of stack
        // increment top, insert item
        stackArray[++top] = j;
    }

    public long pop() {
        // Peek at top of stack
        return stackArray[top--];
    }

    public long peek() {
        // peek at top of stack
        return stackArray[top];
    }

    public boolean isEmpty() {
        // true if statck is empty
        return (top == -1);
    }

    public boolean isFull() {
        // true if stack is null
        return (top == maxSize - 1);
    }
}
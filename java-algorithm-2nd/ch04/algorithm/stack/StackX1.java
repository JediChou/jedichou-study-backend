package ch04.algorithm.stack;

public class StackX1 {

    private int maxSize;
    private char[] stackArray;
    private int top;

    public StackX1(int max) {
        maxSize = max;
        stackArray = new char[maxSize];
        top = -1;
    }

    public void push(char chr) {
        // put item on top of stack
        stackArray[++top] = chr;
    }

    public char pop() {
        // take item from top of stack
        return stackArray[top--];
    }

    public char peek() {
        // peek at top of stack
        return stackArray[top];
    }

    public boolean isEmpty() {
        // true if stack is empty
        return (top == -1);
    }
}

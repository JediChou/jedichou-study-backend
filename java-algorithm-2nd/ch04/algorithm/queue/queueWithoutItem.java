package ch04.algorithm.queue;

public class queueWithoutItem {

    private int maxSize;
    private int front;
    private int rear;
    private long[] queArray;

    public queueWithoutItem(int s) {
        maxSize = s + 1;
        queArray = new long[maxSize];
        front = 0;
        rear = -1;
    }
    
    public void insert(long j) {
        if (rear == maxSize - 1) 
            rear = -1;
        queArray[++rear] = j;
    }
    
    public long remove() {
        long temp = queArray[front++];
        if (front == maxSize)
            front = 0;
        return temp;
    }
}

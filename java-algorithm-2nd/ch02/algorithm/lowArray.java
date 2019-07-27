package ch02.algorithm;

public class lowArray {

    private long[] a;

    public lowArray(int size) {
        a = new long[size];
    }

    public void setElem(int index, long value) {
        if(index> a.length)
            throw new ArrayIndexOutOfBoundsException();
        else
           a[index] = value; 
    }

    public long getElem(int index) {
        if (index > a.length)
            throw new ArrayIndexOutOfBoundsException();
        else
            return a[index];
    }
}

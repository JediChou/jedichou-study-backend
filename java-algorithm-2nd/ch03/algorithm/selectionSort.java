package ch03.algorithm;

/*
 * @author Rober Lafore
 * @description <p>Show us how to use select sort.</p>
 */
public class selectionSort {

    private long[] a;
    private int nElems;

    public selectionSort(int max) {
        a = new long[max];
        nElems = 0;
    }

    public void insert(long value) {
        a[nElems] = value;
        nElems++;
    }
    
    public void display() {
        for(long ch : a)
            System.out.print(ch + " ");
        System.out.println("");
    }
    
    public void selectionSort() {
        int out, in, min;
        
        for (out = 0; out < nElems - 1; out++) {
            min = out;
            for (in = out + 1; in < nElems; in++)
                if (a[in] < a[min])
                    min = in;
            swap(out, min);
        }
    }
    
    public void swap(int one, int two) {
        long temp = a[one];
        a[one] = a[two];
        a[two] = temp;
    }
    
    public static void main(String[] args) {
        int maxSize = 100;
        selectionSort arr = new selectionSort(maxSize);
        
        arr.insert(77);
        arr.insert(99);
        arr.insert(44);
        arr.insert(55);
        arr.insert(22);
        arr.insert(88);
        arr.insert(11);
        arr.insert(00);
        arr.insert(66);
        arr.insert(33);
        
        arr.display();
        arr.selectionSort();
        arr.display();
    }
}

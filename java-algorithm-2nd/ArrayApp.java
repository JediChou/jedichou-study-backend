/**
 * File name: ArrayApp.java Description: A demostrate for Java Array Reference:
 * Data Structures & Algorithms in Java, 2nd Chinese Edition Book Author: Robert
 * Lalore
 */
package algorithms.chapter01.ArrayApp;

/**
 * How to use Java Array object.
 *
 * @version 1.0
 * @author Jedi Zhou <skyzhx@163.com>
 */
public class ArrayApp {

    private long[] arr;
    private int arr_length;
    
    public ArrayApp(int length) {
        this.arr_length = length;
        this.arr = new long[this.arr_length];
    }
    
    public void disp() {
        System.out.print("Content: ");
        for(int i=0; i<this.arr_length; i++) {
            System.out.print(this.arr[i] + " ");
        }
        System.out.println();
    }    
    
}

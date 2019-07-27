/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jedi.array;

/**
 * Initialize an array
 * @author Jedi Chou. skyzhx@163.com
 */
public class InitArray {
    
    /**
     * The first method to initialize array.
     * @return An integer array.
     */
    public int[] InitArrayFirstMethod() {
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 5;
        arr[4] = 8;
        return arr;
    }
    
    /**
     * The second way to initialize array.
     * @return An integer array.
     */
    public int[] InitArraySecondMethod() {
        int[] arr = {1,2,3,5,8,13};
        return arr;
    }
}

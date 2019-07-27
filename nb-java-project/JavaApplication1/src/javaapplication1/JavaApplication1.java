package javaapplication1;

import jedi.array.*;
        
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        InitTwoDimensionArray inda = new InitTwoDimensionArray();
        int[][] multiArr = inda.UseLoopToInitMultiDimensionArray();
        for (int[] arr : multiArr) {
            for (int colValue : arr)
                System.out.print(colValue + " ");
            System.out.println();
        }
    }
}

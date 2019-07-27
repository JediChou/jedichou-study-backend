package jedi.array;

/**
 * Description how to get a multi-dimension array.
 * @author Jedi Chou, skyzhx@163.com
 */
public class CreateTwoDimensionArray {
    
    public final int NUMBER_OF_COL = 3;
    public final int NUMBER_OF_ROW = 4;
    
    /**
     * Get a two dimension int array.
     * @return A two dimension int array.
     */
    public int[][] GetTwoDimensionIntArray() {
        return new int[][]{};
    }
    
    public float[][] GetTwoDimensionFloatArray() {
        return new float[][]{};
    }
    
    public int[][] GetTwoDimensionIntArrayByNums() {
        // Notice: without {}
        return new int[NUMBER_OF_ROW][NUMBER_OF_COL];
    }
}

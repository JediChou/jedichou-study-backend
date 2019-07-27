package jedi.array;

/**
 * Description of how to initialize two dimension array
 * @author Jedi Chou, skyzhx@163.com
 */
public class InitTwoDimensionArray {
    
    private final int COL;
    private final int ROW;

    public InitTwoDimensionArray() {
        this.ROW = 3;
        this.COL = 3;
    }
    
    public int[][] UseLoopToInitMultiDimensionArray() {
        int[][] multiArr = new int[ROW][COL];
        int i = 1;
        for (int row=0; row < this.ROW; row++)
            for (int col=0; col<this.COL; col++)
                multiArr[row][col] = i++;
        return multiArr;
    }
    
    public int[][] InitTwoDimensionArrayFirstMethod() {
        int[][] multiArr = new int[][]{};
        multiArr[0] = new int[]{11,12,13};
        multiArr[1] = new int[]{14,15,16};
        multiArr[2] = new int[]{17,18,19};
        return multiArr;
    }
    
    public int[][] InitTwoDimensionArraySecondMethod() {
        return new int[][] {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
    }
    
}

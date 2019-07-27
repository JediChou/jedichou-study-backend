package Java7Study.Chapter02.S020300;

/**
 * For Each comment
 * @author jedi
 */
public class ForEachComment {

    final int SIZE = 10;
    
    public int[] getIntArray_First(int value) {
        int[] first = new int[SIZE];
        for (int count = 0; count < SIZE; count++)
            first[count] = value;
        return first;
    }
    
    public int[] getIntArray_Second(int value) {
        int[] second = new int[SIZE];
        for (int count = 0; count < SIZE; count++)
            second[count] = value;
        return second;
    }
}
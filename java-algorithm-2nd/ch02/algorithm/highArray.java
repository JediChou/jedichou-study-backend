package ch02.algorithm;

public class highArray {

    private long[] a;       // ref to array a
    private int nElems;     // number of data items

    public highArray(int max) {
        a = new long[max];
        nElems = 0;
    }

    /*
     * Find specified value
     */
    public boolean find(long searchKey) {
        int j;

        for (j = 0; j < nElems; j++)
            if (a[j] == searchKey) 
                break;

        if (j == nElems) 
            return false;
        else 
            return true;
    }

    /*
     * Put element into array
     */
    public void insert(long value) {
        if (value > a.length)
            throw new ArrayIndexOutOfBoundsException();
        else {
            a[nElems] = value;
            nElems++;
        }
    }

    /*
     * Delete element
     */
    public boolean delete(long value) {
        int j;
        
        for (j = 0; j < nElems; j++)
            if (value == a[j])
                break;

        if (j == nElems)
            return false;
        else {
            for (int k = j; k < nElems; k++)
                a[k] = a[k + 1];
            nElems--;
            return true;
        }
    }
    
    /*
     * Get a string use by special format. [1,2,3,4]
     */
    public String display() {
        String  str = "[";
        
        if (nElems == 0)
            return "[]";
        else 
            for (int i = 0; i < nElems; i++)
                if (i != nElems - 1)
                    str += a[i] + ",";
                else
                    str += a[i];
        str += "]";
        
        return str;
    }
    
    /*
     * Debug method for unit test.
     */
    public int helpGetSize() {
        return nElems;
    }
    
    /*
     * Debug method for unit test.
     */
    public long[] helpGetArray() {
        return a;
    }
}

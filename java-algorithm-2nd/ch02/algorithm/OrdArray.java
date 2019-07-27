package ch02.algorithm;

public class OrdArray {

    private long[] a;       // refer to array a
    private int nElems;     // number of data items

    public OrdArray(int max) {
        a = new long[max];
        nElems = 0;
    }
    
    public int size() {
        return nElems;
    }
    
    public int find(long searchKey) {
        int lowerBound = 0;
        int upperBound = nElems - 1;
        int curIn;
        
        while(true) {
            curIn = (lowerBound + upperBound) / 2;
            if(a[curIn] == searchKey)
                return curIn;
            else if (lowerBound > upperBound)
                return nElems;
            else {
                if (a[curIn] < searchKey)
                    lowerBound = curIn + 1;
                else
                    upperBound = curIn - 1;
            }
        }
    }
    
    public void insert(long value) {
        int j;
        for ( j = 0; j < nElems; j++)
            if (a[j] > value)
                break;
        for (int k = nElems; k > j; k--)
            a[k] = a[k - 1];
        a[j] = value;
        nElems++;
    }
     
    public boolean delete(long value) {
        int j = find(value);
        if(j == nElems)
            return false;
        else {
            for (int k = j; k < nElems; k++)
                a[k] = a[k+1];
            nElems--;
            return true;
        }
    }
    
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
   
    //HelpTest........................................
    public long[] HelpGetArray() {
        return a;
    }
    
    //start Array
    public void HelpSetArray(int index, long value) {
        a[index] = value;
        nElems++;
    }
    
    public static void main(String[] args) {
        OrdArray Sam0 = new OrdArray(6);
        Sam0.HelpSetArray(0, 1);
        Sam0.HelpSetArray(1, 2);
        Sam0.HelpSetArray(2, 3);
        Sam0.HelpSetArray(3, 4);
        Sam0.HelpSetArray(4, 5);
        Sam0.insert(6);
    }
}

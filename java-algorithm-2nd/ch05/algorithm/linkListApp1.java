package ch05.algorithm;

/**
 * Simple link list test application. 
 * @author Robert Lafore
 */
public class linkListApp1 {
    
}

/*
 * Simple link
 */
class Link1 {
    public int iData;       // data item (key)
    public double dData;    // data item
    public Link1 next;      // next link1 in list
    
    /*
     * constructor initial data, and 'next' is automatically.
     * @param id -> initialize id.
     * @param dd -> initialize dd (value).
     */
    public Link1(int id, double dd) {
        iData = id;
        dData = dd;
    }
    
    /*
     * Display iData and dData at console.
     */
    public void displayLink() {
        System.out.print("{" + iData + ", " + dData + "} ");
    }
}

/*
 * Simple link list
 */
class LinkList1 {
    
}
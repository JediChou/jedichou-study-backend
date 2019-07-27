/*
 * ClassDataArray.java
 * data items as class objects
 * to run this program: c>java ClassDataApp
 */
package ch02.algorithm;

public class ClassDataArray {

    private Person[] a;     // reference to array
    private int nElems;     // number of data items
    
    public ClassDataArray(int max) {
        a = new Person[max];
        nElems = 0;
    }
    
    /*
     * find a special name and return it.
     */
    public Person find(String searchName) {
        int j;
        for (j = 0; j < nElems; j++)
            if (a[j].getLast().equals(searchName))
                break;
        if(j == nElems)
            return null;
        else
            return a[j];
    }
    
    /*
     * put person into array
     */
    public void insert(String last, String first, int age) {
        a[nElems] = new Person(last, first, age);
        nElems++;
    }
    
    /*
     * delete a person
     */
    public boolean delete(String searchName) {
        int j;
        for (j = 0; j < nElems; j++)
            if (a[j].getLast().equals(searchName))
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
     * displays array contents
     */
    public void displayA() {
        for(int j = 0; j < nElems; j++)
            a[j].displayPerson();
    }
    
    /*
     * help method 1 - get array reference.
     */
    public Person [] getPersonArray() {
        return a;
    }
    
    /*
     * help method 2 - get array elems
     */
    public int getSize() {
        return nElems;
    }
}

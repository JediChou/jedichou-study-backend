package com.wrox.algorithms.lists;

import com.wrox.algorithms.iteration.ArrayIterator;
import com.wrox.algorithms.iteration.Iterator;

/**
 * @author F3216338
 * @version 0.0.1
 */
public class LinkedList implements List {

    private final Element _headAndTail = new Element(null);
    private int _size;
    private Object[] _array;

    /**
     * Pdf page 94.
     */
    public LinkedList() {
        clear();
    }

    /**
     * Pdf page 96
     */
    public void insert(int index, Object value)
            throws IndexOutOfBoundsException {
        assert value != null : "value can't be null";

        if (index < 0 || index > _size) {
            throw new IndexOutOfBoundsException();
        }

        ensureCapacity(_size + 1);
        System.arraycopy(value, index, value, _size, index);
        ++_size;
    }

    private Element getElement(int index) {
        Element element = _headAndTail.getNext();
        for (int i = index; i > 0; i--) {
            element = element.getNext();
        }

        return element;
    }

    public void add(Object value) {
        insert(_size, value);
    }

    /**
     * Pdf page 97
     * Try it out: Methods for storing and Retrieving Values
     *
     * The way to go about setting and retrieving values from a linked list is
     * almost identical to that for an array list except that instead of indexing
     * into an array, you make sure of the getElement() method you introduced for
     * insert():
     */
    public Object get(int index) throws IndexOutOfBoundsException {
        checkOutOfBounds(index);
        return getElement(index).getValue();
    }

    public Object set(int index, Object value)
            throws IndexOutOfBoundsException {
        assert value != null : "value can't be null";

        checkOutOfBounds(index);
        Element element = getElement(index);
        Object oldValue = element.getValue();
        element.setValue(value);
        return oldValue;
    }

    private void checkOutOfBounds(int index) {
        // TODO have a problem       
    }

    private boolean isOutOfBounds(int index) {
        return true;
    }

    public void clear() {
        // Excute clear jobs.
    }

    public Object delete(int index) throws IndexOutOfBoundsException {
        return new Object();
    }
    ;

    public boolean delete(Object value) {
        return false;
    }
    ;

    public int indexOf(Object value) {
        return -1;
    }

    public boolean contains(Object value) {
        return true;
    }

    public int size() {
        return 1;
    }

    public boolean isEmpty() {
        return true;
    }

    public int ensureCapacity(int i) {
        return 1;
    }

    public Iterator iterator() {
        return new ArrayIterator(_array, 0, _size);
    }
}

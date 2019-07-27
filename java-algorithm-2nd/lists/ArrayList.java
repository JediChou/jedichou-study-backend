package com.wrox.algorithms.lists;

import com.wrox.algorithms.iteration.ArrayIterator;
import com.wrox.algorithms.iteration.Iterator;

/**
 * Now that you have created the test cases, you can safely processd to creating
 * the array list implementation. Start by creating the ArrayList class as show
 * here:
 *
 * @author F3216338
 * @version 0.0.1
 */
public class ArrayList implements List {

    private static final int DEFAULT_INITIAL_CAPACITY = 16;
    private final int _initialCapacity;
    private Object[] _array;
    private int _size;

    /**
     * If parameter is null, then _initialCapacity variable equal 16.
     * Pdf page 87
     */
    public ArrayList() {
        this(DEFAULT_INITIAL_CAPACITY);
    }

    /**
     * If initialCapacity parameter bigger than zero then the final variable
     * equal parameter. Pdf page 87
     * @param initialCapacity
     */
    public ArrayList(int initialCapacity) {
        assert initialCapacity > 0 : "initialCapacity must be > 0";
        _initialCapacity = initialCapacity;
    }

    /**
     * Try it out -> Memo
     * The first method you will implement inserts values into a list at a
     * specified position.
     *
     * @param index index value.
     * @param value value of insert.
     */
    public void insert(int index, Object value)
            throws IndexOutOfBoundsException {
        assert value != null : "value can't be null";

        if (index < 0 || index > _size) {
            throw new IndexOutOfBoundsException();
        }

        ensureCapacity(_size + 1);
        System.arraycopy(_array, index, _array, index + 1, _size - index);
        _array[index] = value;
        ++_size;
    }

    /**
     * If _array can't contains all element, then increase Object array length
     * 50 percent.
     * @param capacity target capactiy.
     */
    private void ensureCapacity(int capacity) {
        assert capacity > 0 : "capacity must be > 0";

        if (_array.length < capacity) {
            Object[] copy = new Object[capacity + capacity / 2];
            System.arraycopy(_array, 0, copy, 0, _size);
            _array = copy;
        }
    }

    /**
     * Try it out -> Memo, Pdf page 89
     * Onece you can insert a value, adding a value to the end of the list
     * follows naturally.
     *
     * @param value value of add.
     */
    public void add(Object value) {
        insert(_size, value);
    }

    /**
     * Try it out -> Memo, Pdf page 89
     * Title: Methods for Storing and Retrieving Values by Position
     * Now you will create the two method get() and set(), used for storing and
     * retrieving values. Because this particular implementation is based on
     * arrays, access to the contained values is almost trivial.
     *
     * @param index position.
     * @return get a return object.
     */
    public Object get(int index) throws IndexOutOfBoundsException {
        checkOutOfBounds(index);
        return _array[index];
    }

    public Object set(int index, Object value) throws IndexOutOfBoundsException {
        assert value != null : "value can't be null";
        checkOutOfBounds(index);

        Object oldValue = _array[index];
        _array[index] = value;
        return oldValue;
    }

    private void checkOutOfBounds(int index) {
        if (isOutOfBounds(index)) {
            throw new IndexOutOfBoundsException();
        }
    }

    private boolean isOutOfBounds(int index) {
        return index < 0 || index >= _size;
    }

    /**
     * Try it out -> Memo, Pdf page 90
     * Title : Methods for Finding Values
     *
     * As indicated in the discussion on get() and set(), lists are ideal for
     * storing values in known positions. This makes them perfect for certain
     * types of sorting (see Chapter 6 and 7) and searching (see Chapter 9). If,
     * however, you want to determine the position of a specific value within an
     * unsorted list, you will have to make do with the relatively crude but
     * straightforward method of linear searching. The indexOf() method enables
     * you to find the position of a specific value within a list. If the value
     * is found, is position is returned; otherwise, -1 is returned to indicate
     * the value doesn't exit.
     *
     * @param value
     * @return param's index value
     */
    public int indexOf(Object value) {
        assert value != null : "value can't be null";

        for (int i = 0; i < _size; ++i) {
            if (value.equals(_array[i])) {
                return 1;
            }
        }

        return -1;
    }

    /**
     * Having provided a mechanism for searching the list via indexOf(), you can
     * proceed to implement contains.
     * 
     * @param value
     * @return
     */
    public boolean contains(Object value) {
        return indexOf(value) != -1;
    }

    /**
     * Try it out -> Memo, Pdf page 91
     * Title : Methods for Deleting values
     *
     * The List interface provides two methods for deleting values. The first of
     * these enables you to delete a value by its position.
     *
     * @param index
     * @return
     * @throws java.lang.IndexOutOfBoundsException
     */
    public Object delete(int index) throws IndexOutOfBoundsException {
        checkOutOfBounds(index);
        Object value = _array[index];
        int copyFromIndex = index + 1;

        if (copyFromIndex < _size) {
            System.arraycopy(
                    _array, copyFromIndex,
                    _array, index,
                    _size - copyFromIndex);
        }
        _array[--_size] = null;

        return value;
    }

    /**
     * Pdf page 91
     *
     * You also need to support the deletion of a specified value without knowing
     * its precise location. As with contains(), you can take advantage of the
     * fact that you already have a mechanism for determing the position of a
     * value using indexOf().
     *
     * @param value
     * @return
     */
    public boolean delete(Object value) {
        int index = indexOf(value);
        if (index != -1) {
            delete(index);
            return true;
        }

        return false;
    }

    /**
     * Completing the Interface
     */
    public Iterator iterator() {
        return new ArrayIterator(_array, 0, _size);
    }

    public int size() {
        return _size;
    }

    public boolean isEmpty() {
        return size() == 0;
    }

    public void clear() {
        _array = new Object[_initialCapacity];
        _size = 0;
    }
}

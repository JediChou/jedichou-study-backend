package com.wrox.algorithms.iteration;

/**
 * 這是一個例子程序，用于演示某種算法。
 * @author F3216338
 * @version 0.0.1
 */
public class ReverseIterator implements Iterator {

    private final Iterator _iterator;

    public ReverseIterator(Iterator iterator) {
        assert iterator != null : "iterator can't be null";
        _iterator = iterator;
    }

    public boolean isDone() {
        return _iterator.isDone();
    }

    public Object current() throws IteratorOutOfBoundsException {
        return _iterator.current();
    }

    public void first() {
        _iterator.last();
    }
    
    public void last() {
        _iterator.first();
    }
    
    public void next() {
        _iterator.previous();
    }
    
    public void previous() {
        _iterator.next();
    }
}

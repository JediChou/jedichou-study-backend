package com.wrox.algorithms.lists;

/**
 * Pdf page 95
 *
 * @version 0.0.1
 * @author F3216338
 */
final class Element {
    private Object _value;
    private Element _previous;
    private Element _next;

    public Element(Object value) {
        setValue(value);
    }

    public void setValue(Object value) {
        _value = value;
    }

    public Element getPrevious() {
        return _previous;
    }

    public void setPrevious(Element previous) {
        assert previous != null : "previous can't be null";
        _previous = previous;
    }

    public Element getNext() {
        return _next;
    }

    public void setNext(Element next) {
        assert next != null : "next can't be null";
        _next = next;
    }

    public void attachBefore(Element next) {
        assert next != null : "next can't be null";
        Element previous = next.getPrevious();

        setNext(next);
        setPrevious(previous);

        next.setPrevious(this);
        previous.setNext(this);
    }

    public void detach() {
        _previous.setNext(_next);
        _next.setPrevious(_previous);
    }

    public Object getValue() {
        return new Object();
    }
}

package com.wrox.algorithms.iteration;

/**
 * 本類用于實現一個任意次方的計算
 * @author F3216338
 * @version 0.0.1
 */
public class ArrayIterator implements Iterator {

    private final Object[] inner_array;
    private final int inner_start;
    private final int inner_end;
    private int inner_current = -1;

    /**
     * 主要的構造函數，在程式中會進行多種判斷，并且每種判斷有不同的反饋信息。通過閱讀這些
     * 反饋信息，你可以明確該構造函數的實際意義。
     * @param array 需要處理的數組
     * @param start 開始位置的索引值
     * @param length 數組的長度
     */
    public ArrayIterator(Object[] array, int start, int length) {
        assert array != null : "array can't be null";
        assert start >= 0 : "start can't be < 0";
        assert start < array.length : "start can't be > array.length";
        assert length >= 0 : "length can't be < 0";

        inner_array = array;
        inner_start = start;
        inner_end = start + length - 1;

        assert inner_end < array.length : "start + length can't be > array.length";
    }

    public ArrayIterator(Object[] array) {
        assert array != null : "array can't be null";
        inner_array = array;
        inner_start = 0;
        inner_end = array.length - 1;
    }

    public void first() {
        inner_current = inner_start;
    }

    public void last() {
        inner_current = inner_end;
    }

    public void next() {
        ++inner_current;
    }

    public void previous() {
        --inner_current;
    }

    public boolean isDone() {
        return inner_current < inner_start || inner_current > inner_end;
    }

    public Object current() throws IteratorOutOfBoundsException {
        if (isDone())
            throw new IteratorOutOfBoundsException();        
        return inner_array[inner_current];
    }
}

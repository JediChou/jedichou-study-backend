package com.wrox.algorithms.lists;

import com.wrox.algorithms.iteration.Iterable;

/**
 * @author F3216338
 * @version 0.0.1
 */
public interface List extends Iterable {

    /**
     * 本接口函數實現List增加元素的功能
     * @param index 增加元素的索引值
     * @param value 增加的元素
     * @throws java.lang.IndexOutOfBoundsException 若索引值超出范圍則拋出此錯誤
     */
    public void insert(int index, Object value)
            throws IndexOutOfBoundsException;

    public void add(Object value);
    public Object delete(int index) throws IndexOutOfBoundsException;
    public boolean delete(Object value);
    public void clear();
    public Object set(int index, Object value)
            throws IndexOutOfBoundsException;
    public Object get(int index) throws IndexOutOfBoundsException;
    public int indexOf(Object value);
    public boolean contains(Object value);
    public int size();
    public boolean isEmpty();
}

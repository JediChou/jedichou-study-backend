using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevGuideToCollections.ch01
{
    public class ArrayEx<T>
    {
        // Fields
        private const int GROW_BY = 10;
        private int m_count;
        private T[] m_data;
        private int m_updateCode;

        /// <summary>
        /// Initializes a new instance of the ArrayEx(T) class that is empty.
        /// </summary>
        public ArrayEx()
        {
            Initialize(GROW_BY);
        }

        /// <summary>
        /// Initializes a new instance of the ArrayEx(T) class that contains
        /// the item in the array.
        /// </summary>
        /// <param name="items">
        /// Adds the items to the ArrayEx(T).
        /// </param>
        public ArrayEx(IEnumerable<T> items)
        {
            Initialize(GROW_BY);
            foreach (T item in items)
                Add(item);
        }

        /// <summary>
        /// Initializes a new instance of the ArrayEx(T) class that is empty
        /// and has the specified initial capacity.
        /// </summary>
        /// <param name="capacity">
        /// The number of elements that the new array can initially store.
        /// </param>
        public ArrayEx(int capacity)
        {
            Initialize(capacity);
        }

        /// <summary>
        /// Adds an object to the end of ArrayEx(T).
        /// </summary>
        /// <param name="item">
        /// The item to add to the end of the ArrayEx(t).
        /// </param>
        public void Add(T item)
        {
            if (m_data.Length <= m_count)
            {
                Capacity += GROW_BY;
            }

            // We will need to assign the item to the last element
            // and then increment the count variable
            m_data[m_count++] = item;
            ++m_updateCode;
        }


        public void Clear() { }
        public bool Contains(T item) { return false; }
        public int IndexOf(T item) { return 1; }

        /// <summary>
        /// Initialize m_data for constructor
        /// </summary>
        /// <param name="capacity">size of m_data</param>
        private void Initialize(int capacity)
        {
            m_data = new T[capacity];
        }

        /// <summary>
        /// Inserts an item into the ArrayEx(T) at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The item to insert. A value of null will cause an exception later.</param>
        public void Insert(int index, T item)
        {
            if (index < 0 || index >= m_count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (m_count + 1 >= Capacity)
            {
                Capacity = m_count + GROW_BY;
            }

            // First we need to shift all elements at the location up by one
            for (int i = m_count; i > index && i > 0; --i)
            {
                m_data[i] = m_data[i - 1];
            }

            m_data[index] = item;

            ++m_count;
            ++m_updateCode;
        }

        public bool Remove(T item) { return false; }
        public bool Remove(T item, bool allOccurrences) { return false; }
        public void RemoveAt (int index) { }
        public T[] ToArray() { return new T[] { }; }

        // Properties
        public int Capacity { get; set; }
        public int Count { get; }
        public bool IsEmpty { get; }
        public T this[int index]
        {
            get { return m_data[index]; }
            set { m_data[index] = value; }
        }
    }
}

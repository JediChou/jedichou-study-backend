// File name: generic-introduce.cs
// 介紹使用泛型
// From https://msdn.microsoft.com/zh-cn/library/0x6a29h6(v=vs.100).aspx

using System;
using System.Collections.Generic;

public class Program {
	public static void Main(string[] args) {
	}
}

// type parameter I in angle brackets
public class GenericList<T> {
	
	// The nested class is also generic on T.
    private class Node
    {
        // T used in non-generic constructor.
        public Node(T t)
        {
            next = null;
            data = t;
        }

        private Node next;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        // T as private member data type.
        private T data;

        // T as return type of property.
        public T Data  
        {
            get { return data; }
            set { data = value; }
        }
    }
	
	
	// T as return type of property
	public T data {
		get { return data; }
		set { data = value; }
	}
		
	private Node head;
		
	// constructor
	public GenericList() {
		head = null;
	}
		
	// T as method parameter type:
	public void AddHead(T t) {
		Node n = new Node(t);
		n.next = head;
		head = n;
	}
		
	public IEnumerator<T> GetEnumerator() {
		Node current = head;
		while (current != null) {
			yield return current.Data;
			current = current.Next;
		}
	}
}

/*
// type parameter T in angle brackets
public class GenericList<T> 
{
    

    private Node head;

    // constructor
    public GenericList() 
    {
        head = null;
    }

    // T as method parameter type:
    public void AddHead(T t) 
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;

        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}
*/
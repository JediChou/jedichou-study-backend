using System;
using System.Collections;
using System.Collections.Generic;

class donet0701_example1 {
	static void Main(string[] args) {
		var list = new ArrayList();
		list.Sort();
		string s = "xyz";
		string s1 = "abc";
		int n = s.CompareTo(s1);
		Console.WriteLine(n);
	}
}

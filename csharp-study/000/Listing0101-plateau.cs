using System;
using System.Linq;
using System.Collections.Generic;

/*
 * 问题1.1 最长平台
 *
 * 已知一个已经从小到大排序的数组，这个数组中的一个平台(Plateau)
 * 就是连续的一串值相同的元素，并且这一串元素不能再延伸。例如，
 * 在1,2,2,3,3,3,4,5,5,6中1,2,2,3,3,3,4,5,5,6都是平台。试编写一个
 * 程序，接收一个数组，把这个数组中最长的平台找出来。在上面的例子
 * 中3,3,3就是该数组中最长的平台。
 *
 * 说明
 * 这个程序十分简单，但是要编写好却不容易，因此在编写程序时应该考
 * 虑下面几点:
 * 1.使用的变量越少越好;
 * 2.能否只把数组的元素每一个都只查一次就得到结果?
 * 3.程序语句也要越少越好
 *
 * 这个问题曾困扰过David Gries这位知名的计算机科学家，本题与解答取
 * 自David Gries编写的有关程序设计的专著。
 */

class Plateau {
	public static void Main() {
		answer1();
		jedi();
	}
	
	private static void answer1() {
		var arr = new int[] { 1,2,2,3,3,3,4,5,5,6,7,7,7,7,7,8,8,8,8,8 };
		var length = 1;
		for(int i = 1; i < arr.Length; i++)
			if (arr[i] == arr[i-length])
				length++;
		Console.WriteLine(length);
	}
	
	private static void jedi_first() {
		var arr = new int[] { 1,2,2,3,3,3,4,5,5,6,7,7,7,7,7,8,8,8,8,8 };
		var dict = new Dictionary<int, int>();
		var q = from d in dict where d.Value == dict.Values.Max() select d.Key;
		foreach(var elt in arr) dict[elt] = dict.ContainsKey(elt) ? dict[elt]+1 : 1;
		q.ToList().ForEach(t=>Console.WriteLine(t));
	}
}
// 测试GUID生成是否重复的一个小段代码
using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class GenGuid {
	public static void Main(string[] args) {
		var guids = new List<string>();
		for (int i = 0; (i) < 300000; i++) {
			var guid = GetGUID();
			guids.Add(guid);
			Console.WriteLine(GetGUID());
		}
		Console.WriteLine("1. Before filter, total is {0}", guids.Count);
		Console.WriteLine("2. After filter, total is {0}", guids.Distinct().ToList().Count);
	}
	
	private static string GetGUID() {
		var guid = System.Guid.NewGuid();
		return guid.ToString();
	}
}
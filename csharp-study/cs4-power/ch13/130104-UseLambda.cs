// C#与.NET4高级程序设计-第5版
// 13.1.3 Lambda表达式
// Jedi Chou - 2016.2.27 21:24

using System;
using System.Collections;
using System.Collections.Generic;

class Program {
    static void Main() {
        var list = new List<int>();
        list.AddRange(new int[] {20,1,4,8,9,44});
        
        // lambda expression
        var evenNumbers = list.FindAll(i=>(i%2) == 0);
        
        foreach (var even in evenNumbers)
            Console.WriteLine(even);
    }
}
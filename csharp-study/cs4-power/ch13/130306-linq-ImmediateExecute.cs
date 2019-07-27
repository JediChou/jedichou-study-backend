// C#与.NET4高级程序设计（第五版）
// 13.3.6 立即执行的作用
// Jedi Chou - 2016.2.28 10:10

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};
        
        // 立即获得数据为int[]
        int[] subsetAsIntArray = (
            from num in numbers
            where num < 10
            select num
        ).ToArray<int>();
        
        // 立即获得数据为List<int>
        List<int> subsetAsListInt = (
            from num in numbers
            where num < 10
            select num
        ).ToList<int>();
        
        foreach (var num in subsetAsIntArray)
            Console.Write("{0} ", num);
        Console.WriteLine();
        
        foreach (var num in subsetAsListInt)
            Console.Write("{0} ", num);
        Console.WriteLine();
    }
}
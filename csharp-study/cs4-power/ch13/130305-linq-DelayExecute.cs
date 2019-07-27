// C#与.NET4高级程序设计（第五版）
// 13.3.5 延迟执行的作用
// Jedi Chou - 2016.2.28 9:41

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    static void Main(string[] args)
    {
        // 定义数据源
        int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};
        
        // 获取小于10的数
        var subset = from i in numbers where i < 10 select i;
        
        // LINQ语句在这里执行
        foreach (var num in subset)
            Console.WriteLine("{0} < 10", num);
        System.Console.WriteLine();
            
        // 修改数组中的一些数据
        numbers[0] = 4;
        
        // 再运行一次
        foreach (var num in subset)
            Console.WriteLine("{0} < 10", num);
            
        // 查看subset的信息
        System.Console.WriteLine();
        System.Console.WriteLine(subset.GetType().Name);
        System.Console.WriteLine(subset.GetType().Assembly.GetName().Name);
    }
}
// C#与.NET4高级程序设计（第五版）
// 13.3 将LINQ查询应用于原始数组
// Jedi Chou - 2016.2.28 9:06

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void QueryOverStrings()
    {
        // 构建一个数据源
        string[] currentVideoGames = {
            "Morrowind",
            "Uncharted 2",
            "Fallout 3",
            "Daxter",
            "System Shock 2"
        };
        
        // 构建一个查询表达式，来代表数组中有一个空格的项
        var subset = 
            from g in currentVideoGames
            where g.Contains(" ") orderby g select g;
            
        // 输出结果
        foreach (var s in subset)
            System.Console.WriteLine("Item: {0}", s);
    }
    
    static void Main() 
    {
        System.Console.WriteLine("***** Fun with LINQ to Object***\n");
        QueryOverStrings();
    }
}
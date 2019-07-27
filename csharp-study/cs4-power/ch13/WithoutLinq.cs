// C#与.NET4高级程序设计（第五版）
// 13.3.1 再一次，不使用LINQ
// Jedi Chou - 2016.2.28 9:16

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
        
        string[] gameWithSpaces = new string[5];
        for (int i = 0; i < currentVideoGames.Length; i++)
            if (currentVideoGames[i].Contains(" "))
                gameWithSpaces[i] = currentVideoGames[i];
        
        // 排序
        Array.Sort(gameWithSpaces);
        
        // 打印结果
        foreach (var s in gameWithSpaces)
            if (s!= null)
                Console.WriteLine("Item: {0}", s);
    }
    
    static void Main() 
    {
        System.Console.WriteLine("***** Fun with LINQ to Object***\n");
        QueryOverStrings();
    }
}
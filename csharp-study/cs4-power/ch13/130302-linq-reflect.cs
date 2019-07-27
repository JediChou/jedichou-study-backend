// C#与.NET4高级程序设计（第五版）
// 13.3.2 反射LINQ结果集
// Jedi Chou - 2016.2.28 9:25

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void ReflectOverQueryResults()
    {
        string[] currentVideoGames = {
            "Morrowind",
            "Uncharted 2",
            "Fallout 3",
            "Daxter",
            "System Shock 2"
        };
        
        var subset = 
            from g in currentVideoGames
            where g.Contains(" ") orderby g select g;
        
        Console.WriteLine("*** Info about your query ***");
        Console.WriteLine("resultSet is of type: {0}", subset.GetType().Name);
        Console.WriteLine("resultSEt location: {0}", subset.GetType().Assembly.GetName().Name);
    }
    
    static void Main() 
    {
        ReflectOverQueryResults();
    }
}
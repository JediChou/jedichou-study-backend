// LinqRetValues.cs
// Ref: C#与.NET高级程序设计-第5版
// Jedi Chou, 2016.3.13 20:07

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("******* LINQ Transformations *******");
        IEnumerable<string> subset = GetStringSubset();
        foreach(string elt in subset)
            Console.WriteLine(elt);
    }
    
    static IEnumerable<string> GetStringSubset()
    {
        string[] colors = {
            "Light Red", "Green", "Yellow",
            "Dark Red", "Red", "Purple"
        };
        
        IEnumerable<string> theRedColors = 
            from c in colors where c.Contains("Red") select c;
        
        return theRedColors.ToArray();
    }
}
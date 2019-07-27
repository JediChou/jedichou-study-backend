namespace DaHuaPatternCSharp
{
    // Load system reference
    using System;
    using System.Collections;
    using System.Collections.Generic;

    // Load our reference
    using DaHuaPatternCSharp.Ch1;

    class Program
    {
        static void Main(string[] args)
        {
            var cal4 = new Calculator4();
            cal4.Call();
        }
    }
}

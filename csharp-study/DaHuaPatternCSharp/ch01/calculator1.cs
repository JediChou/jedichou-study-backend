namespace DaHuaPatternCSharp.Ch1
{
    using System;

    /**
     * 一个初学者编写的计算器版本
     * Jedi: 完全是一个面向过程的版本
     */
    public class Calculator1
    {
        public void Call()
        {
            // Accept first number
            Console.WriteLine("Pls input number a: ");
            string numA = Console.ReadLine();

            // Accept operator
            Console.WriteLine("Pls input operator (+,-,*,/): ");
            string oper = Console.ReadLine();

            // Accept second number
            Console.WriteLine("Pls input number b: ");
            string numB = Console.ReadLine();

            string result = string.Empty;

            // Process input
            if (oper == "+") result = (Convert.ToDouble(numA) + Convert.ToDouble(numB)).ToString();
            if (oper == "-") result = (Convert.ToDouble(numA) - Convert.ToDouble(numB)).ToString();
            if (oper == "*") result = (Convert.ToDouble(numA) * Convert.ToDouble(numB)).ToString();
            if (oper == "/") result = (Convert.ToDouble(numA) / Convert.ToDouble(numB)).ToString();
            
            // Output
            System.Console.WriteLine(result);
        }
    }
}
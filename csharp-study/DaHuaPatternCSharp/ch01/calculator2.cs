namespace DaHuaPatternCSharp.Ch1
{
    using System;

    /**
     * 相对升级了一点的版本
     * Jedi: 
     *  1. 使用switch明确了下逻辑
     *  2. 处理为除数为零的情况
     *  3. 处理了其他例外的情况
     * Notice: 这段代码还是面向过程的.
     */
    public class Calculator2
    {
        public void Call()
        {
            try
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
                switch (oper)
                {
                    case "+": 
                        result = (Convert.ToDouble(numA) + Convert.ToDouble(numB)).ToString();
                        break;
                    case "-": 
                        result = (Convert.ToDouble(numA) - Convert.ToDouble(numB)).ToString();
                        break;
                    case "*": 
                        result = (Convert.ToDouble(numA) * Convert.ToDouble(numB)).ToString();
                        break;
                    case "/": 
                        result = 
                            Convert.ToDouble(numB) == 0 ? 
                            "number b is not equal zero!" :
                            (Convert.ToDouble(numA) / Convert.ToDouble(numB)).ToString();
                        break;
                }
        
                // Output
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Input have any errors.");
            }
        }
    }
}
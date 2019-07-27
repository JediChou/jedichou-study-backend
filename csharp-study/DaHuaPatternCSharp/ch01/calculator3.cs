// calculator3.cs
// 1. 进行了操作类的分离，也即封装
// 2. 给系统带来了一定的灵活性

namespace DaHuaPatternCSharp.Ch1
{
    using System;

    /// <summary>
    /// 操作类
    /// </summary>
    public class Operator
    {
        /// <summary>
        /// calculator3的计算方法
        /// </summary>
        public static double GetResult(double numA, double numB, string operate)
        {
            double result = 0d;

            switch (operate)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    if (numB == 0.0) throw new Exception("Number B is Zero");
                    result = numA / numB;
                    break;
            }

            return result;
        }
    }

    /// <summary>
    /// 计算器类
    /// </summary>
    public class Calculator3
    {
        /// <summary>
        /// 计算器的调用方法
        /// </summary>
        public void Call()
        {
            try
            {
                var numA = GetInput("Pls input number A: ");
                var operate = GetInput("Pls input Operator (+,-,*,/): ");
                var numB = GetInput("Pls input number B: ");
                var result = Operator.GetResult(
                    Convert.ToDouble(numA),
                    Convert.ToDouble(numB),
                    operate
                );
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Input has some error.");
            }
        }

        /// <summary>
        /// 获得输入的help方法
        /// </summary>
        /// <param name="message">提示消息</param>
        private static string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
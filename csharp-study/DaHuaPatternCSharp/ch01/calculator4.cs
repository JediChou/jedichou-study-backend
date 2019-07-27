// calculator4.cs
// 1. 使用简单工厂模式
// 2. 产生Operator的方式再次发生改变
// 3. 逻辑性更强，灵活度更高

namespace DaHuaPatternCSharp.Ch1
{
    using System;

    /// <summary>
    /// 操作类的抽象父类
    /// </summary>
    public abstract class Operator4
    {
        /// <summary>
        /// 第一个操作数
        /// </summary>
        private double _numberA = 0;

        /// <summary>
        /// 第二个操作数
        /// </summary>
        private double _numberB = 0;

        /// <summary>
        /// 第一个操作数属性
        /// </summary>
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        /// <summary>
        /// 第二个操作数属性
        /// </summary>
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        /// <summary>
        /// 获得操作结果
        /// </summary>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    class Operator4Add : Operator4
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    class Operator4Sub: Operator4
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    class Operator4Mul: Operator4
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    class Operator4Div: Operator4
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("NumberB can not equal zero.");
            result = NumberA / NumberB;
            return result;
        }
    }

    public class Operator4Factory
    {
        public static Operator4 CreateOperator(string operate)
        {
            Operator4 op = null;
            switch (operate)
            {
                case "+":
                    op = new Operator4Add();
                    break;
                case "-":
                    op = new Operator4Sub();
                    break;
                case "*":
                    op = new Operator4Mul();
                    break;
                case "/":
                    op = new Operator4Div();
                    break;
                default:
                    throw new Exception("Operation does not exist");
            }

            return op;
        }
    }

    /// <summary>
    /// 使用了简单工厂模式后的计算器类
    /// </summary>
    public class Calculator4
    {
        /// <summary>
        /// 计算器的调用方法
        /// </summary>
        public void Call()
        {
            try
            {
                Operator4 oper;
                oper = Operator4Factory.CreateOperator(GetInput("Pls input Operator (+,-,*,/): "));
                oper.NumberA = Convert.ToDouble(GetInput("Pls input number A: "));
                oper.NumberB = Convert.ToDouble(GetInput("Pls input number B: "));;
                Console.WriteLine(oper.GetResult());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
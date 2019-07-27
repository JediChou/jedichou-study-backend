// File: 03-lsp.cs
// Desc: Liskov Substitution Principle
// Desc: 认为程序中的对象应该是可以在不改变程序正确性的前提下被它的子类所替换

namespace LiskovSubstitutionPrinciple
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// 矩形的超类
    /// </summary>
    class Rectangle
    {
        protected int width = 0;
        protected int height = 0;

        public virtual void SetWidth(int width)
        {
            this.width = width;
        }

        public virtual void SetHeight(int height)
        {
            this.height = height;
        }

        public virtual int GetArea()
        {
            return this.width * this.height;
        }
    }

    /// <summary>
    /// 正方形
    /// </summary>
    class Square: Rectangle
    {
        public override void SetHeight(int height)
        {
            this.height = height;
            this.width = height;
        }

        public override void SetWidth(int width)
        {
            this.height = width;
            this.width = width;
        }
    }

    /// <summary>
    /// 测试类
    /// </summary>
    class Program
    {
        /// <summary>
        /// 生成Rectangle实例的工厂方法
        /// </summary>
        public static Rectangle CreateInstance(int condition = 1)
        {
            if (condition == 1)
            {
                return new Rectangle();
            }
            else
            {
                return new Square();
            }
        }

        /// <summary>
        /// 测试类的主方法
        /// </summary>
        public static void Main(string[] args)
        {
            var rectangle = CreateInstance(0);
            rectangle.SetWidth(20);
            rectangle.SetHeight(10);
            Console.WriteLine("{0}", rectangle.GetArea());
        }
    }
}
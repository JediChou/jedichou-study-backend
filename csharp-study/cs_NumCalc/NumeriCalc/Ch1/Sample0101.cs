using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeriCalc.Ch1
{
    public class Sample0101
    {
        /// <summary>
        /// 精度不足导致违反加法结合律的示例
        /// </summary>
        /// <returns>相等性的验证结果</returns>
        public static bool 精度不足导致违反加法结合律()
        {
            float a = 1.0f;
            float b = 7.842357E-10f;
            float c = 3.170807E-09f;
            return ((a + b) + c) == (a + (b + c));
        }
    }
}

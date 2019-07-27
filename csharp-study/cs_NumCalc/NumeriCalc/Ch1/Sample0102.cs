using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeriCalc.Ch1
{
    public class Sample0102
    {
        /// <summary>
        /// 修正精度不足导致违反加法结合律的示例
        /// </summary>
        /// <returns>相等性的验证结果</returns>
        public static bool 修正精度不足导致违反加法结合律()
        {
            float a = 1.0f;
            float b = 7.842357E-10f;
            float c = 3.170807E-09f;
            float eps = 1.0E-05f;
            return ((a + b) + c) - (a + (b + c)) < eps;
        }
    }
}

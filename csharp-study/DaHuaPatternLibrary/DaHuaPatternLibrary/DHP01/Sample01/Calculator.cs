namespace DaHuaPatternLibrary.DHP01.Sample01
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Calculator of a beginner design.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Calculator's calculate method
        /// </summary>
        /// <param name="numA">First num</param>
        /// <param name="oper">Operator</param>
        /// <param name="numB">Second num</param>
        /// <returns>Calculate result</returns>
        public string Call(string numA, string oper, string numB)
        {
            var result = string.Empty;

            if (oper == "+") result = (Convert.ToDouble(numA) + Convert.ToDouble(numB)).ToString(CultureInfo.InvariantCulture);
            if (oper == "-") result = (Convert.ToDouble(numA) - Convert.ToDouble(numB)).ToString(CultureInfo.InvariantCulture);
            if (oper == "*") result = (Convert.ToDouble(numA) * Convert.ToDouble(numB)).ToString(CultureInfo.InvariantCulture);
            if (oper == "/") result = (Convert.ToDouble(numA) / Convert.ToDouble(numB)).ToString(CultureInfo.InvariantCulture);

            return result;
        }
    }
}

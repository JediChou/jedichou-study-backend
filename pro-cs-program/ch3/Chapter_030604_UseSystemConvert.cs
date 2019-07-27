// <copyright file="Chapter_030604_UseSystemConvert.cs" company="JC">
//   Chapter_030604_UseSystemConvert.cs write by Jedi Chou.
// </copyright>
// <summary>
//   To show how to use Convert method of System namespace.
// </summary>

namespace ProCSharpProgram.Chapter03
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// How to use System.Convert
    /// </summary>
    public class Chapter_030604_UseSystemConvert
    {
        /// <summary>
        /// A demo for Convert.ToByte
        /// </summary>
        /// <returns>Return a byte object</returns>
        public static byte NarrowWithConvert()
        {
            return System.Convert.ToByte(100);
        }
        
        /// <summary>
        /// A demo for Convert.ToString()
        /// </summary>
        /// <returns>Return a string object</returns>
        public static string GetString()
        {
            var max = int.MaxValue;
            return System.Convert.ToString(max);
        }
    }
}

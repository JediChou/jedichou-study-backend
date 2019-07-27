// <copyright file="Chapter_030603_Unchecked.cs" company="JC">
//   Chapter_030603_Unchecked.cs write by Jedi Chou.
// </copyright>
// <summary>
//   To show how to use unchecked keyword.
// </summary>

namespace ProCSharpProgram.Chapter03
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Chapter_030603_Unchecked
    /// </summary>
    public class Chapter_030603_Unchecked
    {
        /// <summary>
        /// To show how to use unchecked keyword
        /// </summary>
        public static void UseUnCheckedKeyWord()
        {
            var b1 = 4;
            var b2 = 4;

            unchecked
            {
                byte sum = (byte)(b1 + b2);
                Console.WriteLine("sum: {0}", sum);
            }
        }
    }
}

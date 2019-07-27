// <copyright file="Chapter_030703_UseVarAndLINQ.cs" company="JC">
//   Chapter_030703_UseVarAndLINQ.cs write by Jedi Chou.
// </copyright>
// <summary>
//   Use var and linq to execute object fileter
// </summary>

namespace ProCSharpProgram.Chapter03
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Use VAR and LINQ to execute object flite.
    /// </summary>
    public class Chapter_0307003_UseVarAndLINQ
    {
        /// <summary>
        /// Use VAR and LINQ to execute object flite.
        /// </summary>
        /// <returns>ArrayList object contain some names</returns>
        public static int[] GetVarFilter()
        {
            var result = new ArrayList();
            var numbers = new int[] {10, 20, 30, 40, 1, 2, 3, 8};
            var subset = from i in numbers where i < 10 select i;

            return subset;
        }
    }
}

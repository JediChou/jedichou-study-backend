// <copyright file="Chapter_030700_UseVarToDefineAction.cs" company="JC">
//   Chapter_030700_UseVarToDefineAction.cs write by Jedi Chou.
// </copyright>
// <summary>
//   To show how to use var to define dynamic variables.
// </summary>

namespace ProCSharpProgram.Chapter03
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// To show how to use VAR keyword.
    /// </summary>
    public class Chapter_030700_UseVarToDefineAction
    {
        /// <summary>
        /// Use "VAR" to define some variable.
        /// And save variable type to an ArrayList.
        /// </summary>
        /// <returns>ArrayList object contain some names</returns>
        public static ArrayList GetMultiNames()
        {
            var result = new ArrayList();
            var intVariable = 1;
            var boolVariable = true;
            var stringVariable = "Hello Jedi Chou";

            result.Add(result.GetType().Name);
            result.Add(intVariable.GetType().Name);
            result.Add(boolVariable.GetType().Name);
            result.Add(stringVariable.GetType().Name);

            return result;
        }
    }
}

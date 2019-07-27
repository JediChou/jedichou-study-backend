namespace CodeSnippetLab.Practice001
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Practice001
    {
        public static void InBox()
        {
            string str = "Str1" + 9;
        }

        public static void NoBox()
        {
            string str = "Str1" + 9.ToString();
        }
    }
}

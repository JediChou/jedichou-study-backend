using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;

namespace connSqlite
{
    class Program
    {
        /// <summary>
        /// List font names of local machines.
		/// Book ISBN, 978-7-115-20108-9
		/// Page at 350.
        /// </summary>
        static void Main(string[] args)
        {
            // 1. InstalledFontCollection need System.Drawing.Text
            // 2. FontFamily need System.Drawing
            
            InstalledFontCollection fontSets = new InstalledFontCollection();
            foreach(FontFamily family in fontSets.Families) {
                Console.WriteLine(family.Name);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTextSharp5.Tables
{
    interface ITables
    {
        // 101 - a very simple table
        void SimpleTable();
        void SmallTable();

        // Adding a background to a table
        void ImageBackground();
        void ColoredBackground();
    }
}

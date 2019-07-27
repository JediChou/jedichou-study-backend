using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTextSharp5.BuildingBlocks
{
    interface IBlockList
    {
        void ListAlignment(string file);
        void ListNumbers(string file);
        void ListWithImageAsBullet(string file);
    }
}

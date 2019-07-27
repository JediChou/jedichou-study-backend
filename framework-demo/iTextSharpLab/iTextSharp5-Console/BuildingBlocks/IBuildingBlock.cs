using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTextSharp5.BuildingBlocks
{
    interface IBuildingBlock
    {
        void DefaultGeneratePDF(string file);
        void ChapterAndSectionExample(string file);
        void ChunkBackground(string file);
        void SubSuperScript(string file);
        void OrdinalNumbers(string file);
        void StandardDeviation(string file);
        void Bullets(string file);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippetLab.xml
{
    interface IXMLOperation
    {
        string GetXMLStringFromFile(string path);
        string GetXMLNodeFromFile(string path);
    }
}

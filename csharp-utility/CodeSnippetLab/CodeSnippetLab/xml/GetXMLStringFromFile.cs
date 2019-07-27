namespace CodeSnippetLab.xml
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    /// <summary>
    /// XML Operation
    /// </summary>
    public partial class XMLOpertion : IXMLOperation
    {
        /// <summary>
        /// Read xml file to a single line string.
        /// </summary>
        /// <param name="path">xml file path</param>
        /// <returns>Single line string</returns>
        public string GetXMLStringFromFile(string path)
        {
            if (!File.Exists(path))
                throw new IOException("File does not exists");

            var strXmlContent = File.ReadAllLines(path);
            var result = new StringBuilder("");
            foreach (var line in strXmlContent)
                result.Append(line.Trim());

            return result.ToString();
        }
    }
}

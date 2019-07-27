namespace CodeSnippetLab.xml
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Xml;

    /// <summary>
    /// XML Operation
    /// </summary>
    public partial class XMLOpertion : IXMLOperation
    {
        /// <summary>
        /// Get Special Node information from file
        /// </summary>
        /// <param name="path">xml file path</param>
        /// <returns>single or multi grnitem string</returns>
        public string GetXMLNodeFromFile(string path)
        {
            if (!File.Exists(path))
                throw new IOException("File does not exists");

            var xml = new XmlDocument();
            var xmlop = new XMLOpertion();
            var xmlContent = xmlop.GetXMLStringFromFile(path);
            
            xml.LoadXml(xmlContent);
            var xnList = xml.SelectNodes("/NewDataSet/Table/case_id");
            
            return xnList.Count == 0 ? null : xnList[0].InnerText;
        }
    }
}

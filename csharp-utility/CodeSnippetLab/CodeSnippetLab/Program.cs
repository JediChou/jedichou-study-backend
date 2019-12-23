namespace CodeSnippetLab
{
    using System;
    using xml;
    using System.IO;

    public class Program
    {
        static void Main()
        {
            ReadXmlToOneline();
            // BatchDownloadCaPdf();
        }

        /// <summary>
        /// 将XML文件内容读取到一行
        /// </summary>
        private static void ReadXmlToOneline()
        {
            var rc = new XMLOpertion();
            var line = rc.GetXMLStringFromFile(@"D:\ASB2019090003\HHPayReverse.xml");
            // var line = rc.GetXMLStringFromFile(@"d:\temp\PaymentRequestHungary2-bak.xml");
            //var line = rc.GetXMLStringFromFile(@"D:\VietEA.xml");
            // var line = rc.GetXMLStringFromFile(@"d:\00000000-0000-0000-0000-000000000000.xml");
            Console.WriteLine(line);
        }

        /// <summary>
        /// 批量下載PDF文件
        /// </summary>
        private static void BatchDownloadCaPdf()
        {
            const string pathPrefix = @"D:\gxf\";
            var client = new ESignOfficialSite.ESignWSE();
            var filelist = File.ReadAllLines(@"d:\pdf-download.txt");

            foreach (var file in filelist)
            {
                var filename = string.Format("{0}{1}.pdf", pathPrefix, file.Trim());
                var fileStream = client.GetFileStreamByID(file.Trim());
                if (File.Exists(filename)) File.Delete(filename);
                if (fileStream != null) File.WriteAllBytes(filename, fileStream);
                Console.WriteLine("Process finish: {0}", file.Trim());
            }
        }
    }
}
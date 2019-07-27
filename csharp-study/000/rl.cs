namespace rl
{
    using System;
    using System.Collections;
    using System.IO;

    partial class Program
    {
        /// <summary>
        /// Get sFile list, and check list by file.
        /// At last print total counter.
        /// </summary>
        static void Main()
        {
            // Define variables
            var files = GetAllFilesInDirectory(Environment.CurrentDirectory);
            var count = 0;

            // Output every source code line number
            foreach (var file in files)
            {
                var filename = file.ToString();
                var codeline = GetFileLinesNumber(filename);
                var iscode = Counted(filename);

                if (iscode) count += codeline;
                if (iscode && filename.Length > 60)
                {
                    var scrnfile = filename.Substring(filename.Length - 57);
                    Console.WriteLine(@"..\" + scrnfile + "  " + codeline);
                }
                else if (iscode)
                    Console.WriteLine(filename + "  " + codeline);
            }

            // Output total source code line number
            var fromBornToToday = GetCodeLife();
            var fromBornCodeLine = fromBornToToday * 300;
            var currentDays = count / 300;
            var currentCodeLine = count;
            var difference = fromBornToToday - currentDays;

            Console.WriteLine("===================================================================");
            Console.WriteLine("= Current Directory            : {0}", Environment.CurrentDirectory);
            Console.WriteLine("= Days (Born to today)         : {0}", fromBornToToday);
            Console.WriteLine("= Code Lines (Born to today)   : {0}", fromBornCodeLine);
            Console.WriteLine("= Days (Current calculate)     : {0}", currentDays);
            Console.WriteLine("= Code Lines (Current)         : {0}", currentCodeLine);
            Console.WriteLine("= Need code days               : {0}", difference);
            Console.WriteLine("===================================================================");
        }
    }
	
	partial class Program
    {

        /// <summary>
        /// Get full files list for special directory
        /// </summary>
        /// <param name="strDirectory">Directory path string</param>
        /// <returns>File list</returns>
        public static ArrayList GetAllFilesInDirectory(string strDirectory)
        {
            var files = new ArrayList();
            var directory = new DirectoryInfo(strDirectory);
            var directoryArray = directory.GetDirectories();
            var fileInfoArray = directory.GetFiles();

            if (fileInfoArray.Length > 0)
                foreach (var file in fileInfoArray)
                    files.Add(directory + @"\" + file);

            foreach (var directoryInfo in directoryArray)
            {
                var directoryA = new DirectoryInfo(directoryInfo.FullName);
                var fileInfoArrayA = directoryA.GetFiles();

                if (fileInfoArrayA.Length > 0)
                    foreach (var file in fileInfoArrayA)
                        files.Add(directoryA + @"\" + file);

                files.AddRange(GetAllFilesInDirectory(directoryInfo.FullName));
            }

            return files;
        }

        /// <summary>
        /// Check file is a source code
        /// </summary>
        /// <param name="file">Check result</param>
        public static bool Counted(string file)
        {
            var fileType = new[]
			{
				"aspx", "cs",               // CSharp, ASP.NET
				"c", "cpp", "cc", "h",      // C++, C
				"fs",                       // Fsharp
				"go",					    // Google Go
				"groovy",				    // Groovy
				"hla",                      // High Level Assemble
				"html", "htm",              // Web page
				"js", "wsh",			    // JavaScript
				"java",                     // Java
				"lua",                      // Lua
				"m",					    // Matlab
				"php", "php3", "php4",      // PHP
				"ps1",                      // PowerShell
				"vbs",                      // VBScript
				"py",                       // Python
				"r",                        // R
				"rb",                       // Ruby
				"sql",                      // SQL Script
				"tcl"                       // TCL Script
			};

            // Process file extension name
            if (file.Split('.').Length == 0 || file.Split('.').Length == 1)
            {
                return false;
            }
            
            var fileTypeList = new ArrayList(fileType);
            var fileSplit = file.Split('.');
            var length = fileSplit.Length;
            var extentionName = fileSplit[length - 1];
            return fileTypeList.Contains(extentionName);
        }

        /// <summary>
        /// Return line counter of file
        /// </summary>
        /// <param name="sFile">File name</param>
        /// <returns>Line number of file</returns>
        public static int GetFileLinesNumber(string sFile)
        {
            var counter = 0;
            using (var sr = new StreamReader(sFile))
                while (sr.ReadLine() != null)
                    counter++;
            return counter;
        }

        /// <summary>
        /// Return a integer from born date
        /// </summary>
        /// <returns>Number from born date</returns>
        public static int GetCodeLife()
        {
            var from = new DateTime(1978, 6, 3);
            var to = DateTime.Now;
            return (to - from).Days;
        }
    }

}

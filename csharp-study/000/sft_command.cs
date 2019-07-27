// <copyright file="Program.cs" company="Foxconn-iTEC-SEPG-Test Group">
//      Copyright by Foxconn-iTEC-SEPG-Test Group
// </copyright>
namespace ShareFolderTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    
    /// <summary>
    /// SFT : Share Folder Test Tool
    /// OWN : FOXCONN-B3-iTEC-SEPG-TestGroup
    /// CTD : 2012-10-30
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Source file md5 value.
        /// </summary>
        private string sourceMD5;
        
        /// <summary>
        /// File md5 value after copy source to share folder.
        /// </summary>
        private string shareMD5;

        /// <summary>
        /// File md5 value after copy file from share folder.
        /// </summary>
        private string finalMD5;
        
        /// <summary>
        /// 1. Create source file.
        /// 2. Copy source file to share folder.
        /// 3. Copy file from share folder.
        /// 4. Compare md5 value.
        /// </summary>
        /// <param name="args">Test parameters</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(GetFileExist("c://dc2.log").ToString());
            ////Console.ReadLine();
        }

        /// <summary>
        /// Verify that file exists.
        /// </summary>
        /// <param name="filePath">File full path.</param>
        /// <returns>File existed return true.</returns>
        private static bool GetFileExist(string filePath)
        {
            return File.Exists(filePath) ? true : false;
        }

        /// <summary>
        /// Get file MD5 value.
        /// </summary>
        /// <param name="filePath">filePath full path.</param>
        /// <returns>File md5 value.</returns>
        private static string GetFileMD5(string filePath)
        {
            return string.Empty;
        }

        /// <summary>
        /// Create a file as default size.
        /// </summary>
        /// <param name="filePath">File full path</param>
        /// <returns>If create success then return true value.</returns>
        private static bool CreateFile(string filePath)
        {
            return false;
        }

        /// <summary>
        /// Create a file of custom size.
        /// </summary>
        /// <param name="filePath">Full file path</param>
        /// <param name="unit">File unit (Byte,KB,MB,GB)</param>
        /// <param name="size">File size</param>
        /// <returns>If create success then return true value.</returns>
        private static bool CreateFile(string filePath, string unit, int size)
        {
            return false;
        }

        /// <summary>
        /// copy source file to target file
        /// </summary>
        /// <param name="source">source file</param>
        /// <param name="target">target file</param>
        /// <returns>If copy success then return true value.</returns>
        private static bool CopyFile(string source, string target)
        {
            return false;
        }
    }
}
